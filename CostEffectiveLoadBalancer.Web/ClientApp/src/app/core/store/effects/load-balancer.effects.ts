import { Injectable } from '@angular/core';
import { Effect, ofType, Actions } from '@ngrx/effects';
import { Store, select } from '@ngrx/store';
import { of } from 'rxjs';
import { switchMap, map, withLatestFrom } from 'rxjs/operators';

import { IAppState } from '../state/app.state';
import { 
    GetProviders,
    GetProvidersSuccess,
    ELoadBalancerActions
} from '../actions/load-balancer.actions';
import { LoadBalancerService } from '../../services/load-balancer.service';

export class UserEffects {
    @Effect()
    getProviders$ = this._actions$.pipe(
      ofType<GetProviders>(ELoadBalancerActions.GetProviders),
      switchMap(() => this._loadBalancerService.getProviders()),
      switchMap((providers) => of(new GetProvidersSuccess(providers)))
    );

    constructor(
      private _loadBalancerService: LoadBalancerService,
      private _actions$: Actions,
      private _store: Store<IAppState>
    ) {}
  }