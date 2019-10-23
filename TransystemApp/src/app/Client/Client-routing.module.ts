import { Routes, RouterModule } from '@angular/router';
import { ClientComponent } from './Client.component';
import { NgModule } from '@angular/core';

export const ClientRoutes: Routes = [
	{
		path: 'client',
		component: ClientComponent,
		children: [
		  {
			path: '', 
			component: ClientComponent 
		  }
		]
	}
];

@NgModule({
  imports: [
    RouterModule.forChild(ClientRoutes)
  ],
  exports: [
    RouterModule
  ]
})
export class ClientRoutingModule {}