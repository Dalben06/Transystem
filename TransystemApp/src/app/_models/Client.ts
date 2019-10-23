import { AddressModel } from './AddressModel';

export interface Client {

    id: number;
    createDate: Date;
    updateDate: Date;
    deleteDate: Date;
    isDeleted: number;
    name: string;
    documentNumber: string;
    isTypePerson: number;
    addresses: AddressModel[];
}
