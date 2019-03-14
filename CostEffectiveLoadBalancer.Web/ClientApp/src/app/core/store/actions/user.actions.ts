import { Action } from '@ngrx/store';

import { IUser } from '../../../models/user.interface';
import { IUserLogin } from '../../../models/user-login.interface'

export enum EUserActions {
    LoginUser = '[User] Login User',    
    LoginUserSuccess = '[User] Login User Success',
    LoginUserFailure = '[User] Login User Failure',
    LogoffUser = '[User] Logoff User',
    LogoffUserSuccess = '[User] Logoff User Success',
    LogoffUserFailure = '[User] Logoff UserFailure'
}

export class LoginUser implements Action {
    public readonly type = EUserActions.LoginUser;
    constructor(public payload: IUserLogin) {}
}

export class LoginUserSuccess implements Action {
    public readonly type = EUserActions.LoginUserSuccess;
    constructor(public payload: IUser) {}
}

export class LoginUserFailure implements Action {
    public readonly type = EUserActions.LoginUserFailure;
    constructor(public payload: string) {}
}

export class LogoffUser implements Action {
    public readonly type = EUserActions.LogoffUser;
    constructor(public payload: number) {}
}

export class LogoffUserSuccess implements Action {
    public readonly type = EUserActions.LogoffUserSuccess;
}

export class LogoffUserFailure implements Action {
    public readonly type = EUserActions.LogoffUserFailure;
    constructor(public payload: string) {}
}

export type UserActions = 
    | LoginUser | LoginUserSuccess | LoginUserFailure 
    | LogoffUser | LogoffUserSuccess | LogoffUserFailure;