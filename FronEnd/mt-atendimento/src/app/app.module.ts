import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import {Observable} from 'rxjs'


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { MainComponent } from './main/main.component';
import { FaleConoscoComponent } from './fale-conosco/fale-conosco.component';
import { ChatComponent } from './chat/chat.component';
import { SituacaoLinhasComponent } from './situacao-linhas/situacao-linhas.component';
import { RegistarManifestacaoComponent } from './registar-manifestacao/registar-manifestacao.component';
import { ConsultarManifestacaoComponent } from './consultar-manifestacao/consultar-manifestacao.component';
import { InputcontainerComponent } from '../app/shared/input-container/input-container.component';
import { RegistarManifestacaoService } from './registar-manifestacao/registar-manifestacao.service'


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    MainComponent,
    FaleConoscoComponent,
    ChatComponent,
    SituacaoLinhasComponent,
    RegistarManifestacaoComponent,
    ConsultarManifestacaoComponent,
    InputcontainerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
