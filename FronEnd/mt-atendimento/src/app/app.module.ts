import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { MainComponent } from './main/main.component';
import { FaleConoscoComponent } from './fale-conosco/fale-conosco.component';
import { ChatComponent } from './chat/chat.component';
import { SituacaoLinhasComponent } from './situacao-linhas/situacao-linhas.component';
import { RegistarManifestacaoComponent } from './registar-manifestacao/registar-manifestacao.component';
import { ConsultarManifestacaoComponent } from './consultar-manifestacao/consultar-manifestacao.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    MainComponent,
    FaleConoscoComponent,
    ChatComponent,
    SituacaoLinhasComponent,
    RegistarManifestacaoComponent,
    ConsultarManifestacaoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
