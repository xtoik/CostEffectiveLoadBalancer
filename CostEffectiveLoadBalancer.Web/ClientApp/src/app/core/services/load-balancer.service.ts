import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from '../../../environments/environment';
import { IProviderHttp } from '../../models/http-models/provider-http.interface';

@Injectable()
export class LoadBalancerService {
  providerApiUrl = `${environment.apiUrl}provider`;

  constructor(private _http: HttpClient) { }

  getProviders(): Observable<IProviderHttp[]> {
    return this._http.get<IProviderHttp[]>(
      `${this.providerApiUrl}`
    );
  }
}