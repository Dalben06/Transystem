import { TrailerModel } from './TrailerModel';

export interface TruckModel {

    Id: number ;
    CreateDate: Date ;
    UpdateDate: Date ;
    DeleteDate: Date ;
    IsDeleted: number ;
    DriverId: number ;
    PlaceTruck: string ;
    ModelTruck: string ;
    Trailers: TrailerModel[] ;
}
