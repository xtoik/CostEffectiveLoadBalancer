import { ActionReducerMap } from '@ngrx/store';
import { routerReducer } from '@ngrx/router-store';

import { IAppState } from '../state/app.state';
import { userReducers } from './user.reducers';
import { loadBalancerReducers } from './load-balancer.reducers';

export const appReducers: ActionReducerMap<IAppState, any> = {
    router: routerReducer,
    user: userReducers,
    loadBalancer: loadBalancerReducers
};
