import { ELoadBalancerActions, LoadBalancerActions } from '../actions/load-balancer.actions';
import { initialLoadBalancerState, ILoadBalancerState } from '../state/load-balancer.state';

export const loadBalancerReducers = (
    state = initialLoadBalancerState,
    action: LoadBalancerActions
): ILoadBalancerState => {
    switch (action.type) {
        case ELoadBalancerActions.GetProvidersSuccess: {
            return {
                ...state,
                providers: action.payload
            };
        }
        
        default:
            return state;
    }
};