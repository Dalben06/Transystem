import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Client } from '../_models/Client';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  baseURL = 'https://localhost:44385/api/client';
constructor(private http: HttpClient) { }

getClient(): Observable<Client[]> {
  return this.http.get<Client[]>(this.baseURL);
}

getClientByTema(Name: string): Observable<Client[]> {
  return this.http.get<Client[]>(`${this.baseURL}/getByName/${Name}`);
}

getClientById(id: number): Observable<Client> {
  return this.http.get<Client>(`${this.baseURL}/${id}`);
}

postClient(Client: Client): Observable<Client> {
  return this.http.post<Client>(this.baseURL, Client);
}
deleteClient(id: number): Observable<Client> {
  return this.http.delete<Client>(`${this.baseURL}/${id}`);
}

  EditClient(model: Client): Observable<Client> {
    return this.http.put<Client>(`${this.baseURL}/${model.id}`, model);
  }

}
