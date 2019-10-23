import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClientComponent } from './Client.component';
import { ClientRoutingModule } from './Client-routing.module';
import { DateTimeFormatPipePipe } from '../_helps/DateTimeFormatPipe.pipe';

@NgModule({
  imports: [
    CommonModule,
    ClientRoutingModule
  ],
  declarations: [
    ClientComponent,
    DateTimeFormatPipePipe
  ]
})
export class ClientModule { }
