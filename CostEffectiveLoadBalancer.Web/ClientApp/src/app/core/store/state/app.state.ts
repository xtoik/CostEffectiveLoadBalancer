import { RouterReducerState } from '@ngrx/router-store';

import { IUserState, initialUserState } from './user.state';
import { ILoadBalancerState, initialLoadBalancerState } from './load-balancer.state';

export interface IAppState {
    router?: RouterReducerState;
    user: IUserState;
    loadBalancer: ILoadBalancerState;
}

export const initialAppState: IAppState = {
    user: initialUserState,
    loadBalancer : initialLoadBalancerState
};

export function getInitialState() : IAppState {
    return initialAppState;
}