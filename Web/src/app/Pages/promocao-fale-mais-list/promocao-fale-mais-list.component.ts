
import { Component, OnInit, Input } from '@angular/core';
import { PromocaoFaleMaisService } from 'src/app/services/promocao.falemais.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-promocao-fale-mais-list',
  templateUrl: './promocao-fale-mais-list.component.html',
  styleUrls: []
})
export class PromocaoFaleMaisListComponent implements OnInit {
  @Input() data: any[] = [];

  constructor(private promocaoFaleMaisService: PromocaoFaleMaisService) { }

  ngOnInit() {

    this.promocaoFaleMaisService.verCalculos().subscribe(
      data => {
        this.data = data;
      },
      () => { this.showErrorMessage() }
    )
  }


  private showErrorMessage() {
    Swal.fire({
      type: 'error',
      title: 'Oops...',
      text: 'Ocorreu um erro ao conectar no serviço. Entre em contato com o administrador'
    });
  }
}
