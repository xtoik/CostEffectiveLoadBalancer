import { IUser } from '../../../models/user.interface';

export interface IUserState {
    currentUser: IUser;
}

export const initialUserState: IUserState = {
    currentUser: null
};