import { IProvider } from '../../../models/provider.interface';

export interface ILoadBalancerState {
    providers: IProvider[];
}

export const initialLoadBalancerState: ILoadBalancerState = {
    providers: null
};