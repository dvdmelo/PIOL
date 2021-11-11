import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, AbstractControl} from '@angular/forms'
import { RegistarManifestacao } from './registar-manifestacao.model';
import { RegistarManifestacaoService } from './registar-manifestacao.service';

@Component({
  selector: 'mt-registar-manifestacao',
  templateUrl: './registar-manifestacao.component.html'
})
export class RegistarManifestacaoComponent implements OnInit {
  
  registarManifestacaoForm: FormGroup;
  NumeroProtocolo: string="";
  isSuccess: boolean = false;
  isError: boolean = false;

  constructor(private formBuilder: FormBuilder,
    private registarManifestacaoService: RegistarManifestacaoService) {
 
    this.registarManifestacaoForm = this.formBuilder.group ({
      Assunto: this.formBuilder.control('', [Validators.required, Validators.minLength(5), Validators.maxLength(30)]),
      Mensagem: this.formBuilder.control('',[Validators.required, Validators.minLength(5),Validators.maxLength(500)])      
  })
}

  ngOnInit(): void {
   
  }

  showSuccess(){

    if(this.registarManifestacaoForm.get("Assunto")?.value != "") {
      this.isSuccess == false;      
    }

     return (this.isSuccess == true );
  }

  showError(){
    return  this.isError;
  }
  registarManifestacao(registar: RegistarManifestacao){

    this.isSuccess=false;
    this.isError=false;

    try
    {
      this.registarManifestacaoService.registarManifestacao(registar).subscribe( (registarResponse: any)=> {
        console.log("retorno");
        console.log(registarResponse);
        this.NumeroProtocolo = registarResponse.numeroProtocolo;      
        this.isSuccess = true;
        this.registarManifestacaoForm.reset();
        
      });
    } catch(e){
    this.isError = true;
    }
    // order.orderItems = this.cartItems()
    //   .map((item: CarItem)=> new OrderItem(item.quantity,item.menuItem.id))

    //   this.orderService.checkOrder(order)
    //       .subscribe( (orderId: string)=> {
    //         this.router.navigate(['/order-summary'])            
    //         this.orderService.clear()
    //       })

      console.log(registar)
  }

  inputChange(){
    this.isError = false;
    this.isSuccess = false;
  }
}
