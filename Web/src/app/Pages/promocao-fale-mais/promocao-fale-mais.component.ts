import { TarifasSerivce } from './../../services/tarifas.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { EDdds } from 'src/app/models/EDdds';
import { EPlanoFaleMais } from 'src/app/models/EPlanoFaleMais';
import { PromocaoFaleMaisService } from 'src/app/services/promocao.falemais.service';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-promocao-fale-mais',
  templateUrl: './promocao-fale-mais.component.html',
  styleUrls: ['./promocao-fale-mais.component.css']
})
export class PromocaoFaleMaisComponent implements OnInit {
  public keys = Object.keys;
  public dddsId = EDdds;
  public planoFaleMaisId = EPlanoFaleMais;
  public distinguished: any[] = [];
  public data: any[] = [];

  public form: FormGroup;
  public distinguishedDisabled: boolean = false;

  constructor(private fb: FormBuilder,
    private tarrifasService: TarifasSerivce,
    private promocaoFaleMaisService: PromocaoFaleMaisService) {

  }
  ngOnInit(): void {
    this.iniciarFormulario();
  }

  public realizarCalculo(): void {
    if (this.form.valid && this.form.dirty) {
      this.promocaoFaleMaisService.calcularPromocao(this.form.value).subscribe(
        () => { this.onSaveComplete(); },
        () => { this.showErrorMessage(); }
      );
      return;
    }
  }

  carregarDestinos(value: any) {
    this.distinguishedDisabled = true;
    this.tarrifasService.getDestinos(value).subscribe(
      data => {
        this.distinguished = data;
        this.form.controls.distinguishedId.reset();
      },
      () => { this.showErrorMessage(); }
    )
  }

  private onSaveComplete(): void {
    this.promocaoFaleMaisService.verCalculos().subscribe(
      data => {
        this.showSuccessMessge();
        this.data = data;
      }
    );
  }

  private iniciarFormulario(): void {
    this.form = this.fb.group({
      originId: ['', Validators.compose([
        Validators.required
      ])],
      distinguishedId: ['', Validators.compose([
        Validators.required
      ])],
      time: ['', Validators.compose([
        Validators.required
      ])],
      planSpeakMoreId: ['', Validators.compose([
        Validators.required
      ])]
    });
  }

  private showErrorMessage() {
    Swal.fire({
      type: 'error',
      title: 'Oops...',
      text: 'Ocorreu um erro ao conectar no serviço. Entre em contato com o administrador!'
    });
  }

  private showSuccessMessge() {
    Swal.fire({
      type: 'success',
      position: 'top-end',
      showConfirmButton: false,
      title: ':D',
      text: 'Calculo realizado com sucesso!',
      timer: 1500
    });
  }
}
