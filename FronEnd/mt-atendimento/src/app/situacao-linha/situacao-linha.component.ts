import { Component, OnInit } from '@angular/core';
import { SituacaoLinhaModel } from './situacao-linha.model';
import { SituacaoLinhaService } from './situacao-linha.service';

@Component({
  selector: 'mt-situacao-linha',
  templateUrl: './situacao-linha.component.html'
})
export class SituacaoLinhaComponent implements OnInit {

  linhas!: SituacaoLinhaModel[];
  constructor(private situacaoLinhaService: SituacaoLinhaService) {

    this.situacaoLinhaService.obterSituacaoLinhas().subscribe( (situacaoregistarResponse:  SituacaoLinhaModel[])=> {
      console.log("retorno");
      console.log(situacaoregistarResponse);      
      
      this.linhas = situacaoregistarResponse;

    });

   }

  ngOnInit(): void {
  }

}
