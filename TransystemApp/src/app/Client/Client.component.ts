import { Component, OnInit } from '@angular/core';
import { ClientService } from '../_services/client.service';
import { Client } from '../_models/Client';

@Component({
  selector: 'app-Client',
  templateUrl: './Client.component.html',
  styleUrls: ['./Client.component.css']
})
export class ClientComponent implements OnInit {

  Clients: Client[];
  Client: Client;
  ClientsFiltrados: Client[];
  constructor(
    private _clientService: ClientService
  ) { }

  ngOnInit() {
    this.getClients();
  }

  getClients() {
    this._clientService.getClient().subscribe(
      // tslint:disable-next-line: variable-name
      (_Clients: Client[]) =>
       { this.Clients = _Clients; console.log(_Clients); this.ClientsFiltrados = this.Clients; },
    error => { console.log(error); });
  }

  getClientById(id: number): any {

    return this._clientService.getClientById(id).subscribe(
      // tslint:disable-next-line: variable-name
      (_Clients: Client) =>
      { this.Client = _Clients;
        console.log(_Clients);
      },
      error => { console.log(error); });
  }

  // editarClient(template: any, Client: Client) {
  //   this.modoSalvar = 'put';
  //   this.openModal(template);
  //   this.Client = Client;
  //   this.registerForm.patchValue(this.Client);
  // }

  // novoClient(template: any) {
  //   this.modoSalvar = 'post';
  //   this.openModal(template);
  // }

  // excluirClient(template: any, Client: Client) {
  //   this.openModal(template);
  //   this.Client = Client;
  //   this.bodyDeletarClient = `Tem certeza que deseja excluir o Client: ${Client.Name}, Código: ${Client.tema}`;
  // }

  // confirmeDelete(template: any) {
  //   this._ClientServive.deleteClient(this.Client.Id).subscribe(
  //     () => {
  //       template.hide();
  //       this.getClients();
  //     }, error => {
  //       console.log(error);
  //     }
  //   );
  // }

}
