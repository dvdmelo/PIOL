import { Injectable } from '@angular/core'
import { HttpClient , HttpHeaders } from '@angular/common/http'

import { MT_API_TELEMETRIA } from '../app.api'

import { Observable} from 'rxjs';
import { SituacaoLinhaModel } from './situacao-linha.model';


@Injectable({ providedIn: 'root' })
export class SituacaoLinhaService {

	constructor(private http: HttpClient){}



    obterSituacaoLinhas():Observable<SituacaoLinhaModel>{ 
        const headers= new Headers()
        console.log('situacaoLinhaService');
        console.log(`${MT_API_TELEMETRIA}`);

        headers.append('content-type', 'application/json')
        const httpOptions = {
            headers: new HttpHeaders({
              'Content-Type':  'application/json'
            })};

        return this.http.get<SituacaoLinhaModel>(`${MT_API_TELEMETRIA}/v1/telemetriaLinhas/situacaolinhas`, httpOptions)           
    
          
      }

}
