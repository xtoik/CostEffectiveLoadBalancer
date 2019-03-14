import { Action } from '@ngrx/store';

import { IProvider } from '../../../models/provider.interface';

export enum ELoadBalancerActions {
    GetProviders = '[LB] Get Providers',
    GetProvidersSuccess = '[LB] Get Providers Success'
}

export class GetProviders implements Action {
    public readonly type = ELoadBalancerActions.GetProviders;
}

export class GetProvidersSuccess implements Action {
    public readonly type = ELoadBalancerActions.GetProvidersSuccess;
    constructor(public payload: IProvider[]) {}
}

export type LoadBalancerActions =
    | GetProviders | GetProvidersSuccess;