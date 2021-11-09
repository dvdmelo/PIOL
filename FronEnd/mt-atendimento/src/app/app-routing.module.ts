import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FaleConoscoComponent } from './fale-conosco/fale-conosco.component';
import { MainComponent } from './main/main.component';

export const routes : Routes = [
	  {path: '', component: MainComponent },     
    {path: 'fale-conosco', component: FaleConoscoComponent },     
    
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
