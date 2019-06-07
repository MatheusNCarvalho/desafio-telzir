import { EDdds } from './models/EDdds';
import { Component } from '@angular/core';
import { EPlanoFaleMais } from './models/EPlanoFaleMais';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  keys = Object.keys;
  dddsId = EDdds;
  planoFaleMaisId = EPlanoFaleMais;

}
