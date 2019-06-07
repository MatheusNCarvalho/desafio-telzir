import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { CollapseModule } from 'ngx-bootstrap/collapse';

import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';
registerLocaleData(localePt);

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuSuperiorComponent } from './shared/menu-superior/menu-superior.component';

import { FrameLessPageComponent } from './Pages/frame-less-page/frame-less-page.component';
import { PromocaoFaleMaisComponent } from './Pages/promocao-fale-mais/promocao-fale-mais.component';
import { FramePageComponent } from './Pages/frame-page/frame-page.component';
import { PromocaoFaleMaisListComponent } from './Pages/promocao-fale-mais-list/promocao-fale-mais-list.component';
import { TarifasSerivce } from './services/tarifas.service';
import { PromocaoFaleMaisService } from './services/promocao.falemais.service';

import { SweetAlert2Module } from '@toverux/ngx-sweetalert2';

@NgModule({
  declarations: [
    AppComponent,
    MenuSuperiorComponent,
    FramePageComponent,
    FrameLessPageComponent,
    PromocaoFaleMaisComponent,
    PromocaoFaleMaisListComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    CollapseModule.forRoot(),
    HttpClientModule,
    SweetAlert2Module.forRoot({
      buttonsStyling: false,
      customClass: 'modal-content',
      confirmButtonClass: 'btn btn-primary',
      cancelButtonClass: 'btn'
    })
  ],
  providers: [
    TarifasSerivce,
    PromocaoFaleMaisService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
