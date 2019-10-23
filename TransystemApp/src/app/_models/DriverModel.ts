import { TruckModel } from './TruckModel';

export interface DriverModel {
    Id: number ;
    CreateDate: Date;
    UpdateDate: Date ;
    DeleteDate: Date;
    IsDeleted: number;
    Name: string;
    DocumentNumber: string;
    BirthDate: Date;
    DriverLicense: string ;
    Trucks: TruckModel[];


}
