import { Injectable } from '@angular/core'
import { HttpClient , HttpHeaders } from '@angular/common/http'

import { Observable} from 'rxjs';


import { MT_API } from '../app.api'
import { RegistarManifestacao } from './registar-manifestacao.model'


@Injectable({ providedIn: 'root' })
export class RegistarManifestacaoService {

	constructor(private http: HttpClient){}




    registarManifestacao(registarManifestacao: RegistarManifestacao):Observable<RegistarManifestacao>{ 
        const headers= new Headers()
        console.log('registarManifestacao');
        console.log(`${MT_API}`);

        console.log(registarManifestacao);

        headers.append('content-type', 'application/json')
        const httpOptions = {
            headers: new HttpHeaders({
              'Content-Type':  'application/json'
            })};

            
          return this.http.post<RegistarManifestacao>(`https://localhost:44388/v1/atendimentos`,registarManifestacao, httpOptions)

    
          
      }

}

