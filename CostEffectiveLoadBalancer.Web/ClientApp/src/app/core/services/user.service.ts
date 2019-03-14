import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from '../../../environments/environment';
import { IUserHttp } from '../../models/http-models/user-http.interface';
import { IUserLogin } from '../../models/user-login.interface';
import { LoginUser } from '../store/actions/user.actions';

@Injectable()
export class UserService {
  userApiUrl = `${environment.apiUrl}user`;

  constructor(private _http: HttpClient) { }

  loginUser(loginInfo: IUserLogin): Observable<IUserHttp> {
    return this._http.post<IUserHttp>(
      `${this.userApiUrl}/login`, 
      loginInfo
    );
  }

  logoffUser(userId: number): Observable<Boolean> {
    this._http.post(
      `${this.userApiUrl}/logoff`,
      {
          'userId': userId
      }
    )
    return new Observable(observer => observer.next(true));
  }
}