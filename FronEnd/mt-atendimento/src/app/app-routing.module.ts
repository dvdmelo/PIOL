import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChatComponent } from './chat/chat.component';
import { ConsultarManifestacaoComponent } from './consultar-manifestacao/consultar-manifestacao.component';
import { FaleConoscoComponent } from './fale-conosco/fale-conosco.component';
import { MainComponent } from './main/main.component';
import { RegistarManifestacaoComponent } from './registar-manifestacao/registar-manifestacao.component';

export const routes : Routes = [
	  {path: '', component: MainComponent },     
    {path: 'fale-conosco', component: FaleConoscoComponent },     
    {path: 'registar-manifestacao', component: RegistarManifestacaoComponent },     
    {path: 'consultar-manifestacao', component: ConsultarManifestacaoComponent },     
    {path: 'chat', component: ChatComponent },     
    
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
