import { Injectable } from '@angular/core';
import { Effect, ofType, Actions } from '@ngrx/effects';
import { Store, select } from '@ngrx/store';
import { of } from 'rxjs';
import { switchMap, map, withLatestFrom } from 'rxjs/operators';

import { IAppState } from '../state/app.state';
import { 
    LoginUserSuccess,
    LoginUserFailure,
    LogoffUserSuccess,
    LogoffUserFailure,
    EUserActions,
    LoginUser,
    LogoffUser
} from '../actions/user.actions';
import { UserService } from '../../services/user.service';

export class UserEffects {
    @Effect()
    userLogin$ = this._actions$.pipe(
      ofType<LoginUser>(EUserActions.LoginUser),
      map(action => action.payload),
      switchMap(loginInfo => this._userService.loginUser(loginInfo)),
      switchMap((user) => of(new LoginUserSuccess(user)))
    );
  
    @Effect()
    userLogoff$ = this._actions$.pipe(
        ofType<LogoffUser>(EUserActions.LogoffUser),
        map(action => action.payload),
        switchMap(userId => this._userService.logoffUser(userId)),
        switchMap(ok => of(new LogoffUserSuccess()))
      );
  
    constructor(
      private _userService: UserService,
      private _actions$: Actions,
      private _store: Store<IAppState>
    ) {}
  }