import { Injectable } from '@angular/core'
import { HttpClient , HttpHeaders } from '@angular/common/http'

import { Observable} from 'rxjs';


import { MT_API_ATENDIMENTO } from '../app.api'
import { ConsultarManifestacao } from './consultar-manifestacao.model'


@Injectable({ providedIn: 'root' })
export class ConsultarManifestacaoService {

	constructor(private http: HttpClient){}


    consultarManifestacao(numeroProtocolo: number):Observable<ConsultarManifestacao>{ 
        const headers= new Headers()
        console.log('consultarManifestacao');
        console.log(`${MT_API_ATENDIMENTO}`);
        console.log(numeroProtocolo);

        headers.append('content-type', 'application/json')
        const httpOptions = {
            headers: new HttpHeaders({
              'Content-Type':  'application/json'
            })};
            
         return this.http.get<ConsultarManifestacao>(`${MT_API_ATENDIMENTO}/v1/atendimentos/${numeroProtocolo}`, httpOptions);             
          }

}

