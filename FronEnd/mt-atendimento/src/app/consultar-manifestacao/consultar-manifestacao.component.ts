import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, AbstractControl} from '@angular/forms'
import { ConsultarManifestacao } from './consultar-manifestacao.model';
import { ConsultarManifestacaoService } from './consultar-manifestacao.service';

@Component({
  selector: 'mt-consultar-manifestacao',
  templateUrl: './consultar-manifestacao.component.html'
})
export class ConsultarManifestacaoComponent implements OnInit {


  consultarManifestacaoForm: FormGroup;
  manifestacao!: ConsultarManifestacao;
  NumeroProtocolo: string="";
  isError: boolean = false;
  isShowRegister: boolean = false;
  isNotRegister: boolean = false;

  constructor(private formBuilder: FormBuilder,
    private consultarManifestacaoService: ConsultarManifestacaoService) {
 
    this.consultarManifestacaoForm = this.formBuilder.group ({
      NumeroProtocolo: this.formBuilder.control('', [Validators.required]),
  })
}

  ngOnInit(): void {
   
  }


  showError(){
    return  this.isError;
  }

  showNotRegister(){
    return  this.isNotRegister;
  }
  showRegister(){
    return  this.isShowRegister;
  }
  
  consultarManifestacao(){

    this.isError=false;
    this.isShowRegister = false;
    this.isNotRegister = false;

    try
    {
      const numeroProtocolo= this.consultarManifestacaoForm.get("NumeroProtocolo")?.value; 
      this.consultarManifestacaoService.consultarManifestacao(numeroProtocolo).subscribe( (registarResponse:  ConsultarManifestacao)=> {
        console.log("retorno");
        console.log(registarResponse);
        this.manifestacao = registarResponse;  
  ;    
        if(registarResponse!= null && registarResponse.Id >0){
          console.log("tem")
          this.isShowRegister = true;
        }else{
          console.log("não tem")
          this.isNotRegister = true;

        }
        
      });
    } catch(e){
    this.isError = true;
    }
    
  }

  inputChange(){
    this.isError = false;
  }

}
