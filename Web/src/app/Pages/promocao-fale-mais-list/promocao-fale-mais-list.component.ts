import { Component, OnInit, Input } from '@angular/core';
import { PromocaoFaleMaisService } from 'src/app/services/promocao.falemais.service';

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
      }
    )

  }

}
