import { PromocaoFaleMaisComponent } from './Pages/promocao-fale-mais/promocao-fale-mais.component';
import { FramePageComponent } from './Pages/frame-page/frame-page.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: FramePageComponent,
    children: [
      { path: '', component: PromocaoFaleMaisComponent }
    ]
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
