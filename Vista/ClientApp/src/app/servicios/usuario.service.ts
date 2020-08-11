import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Usuarios } from './../modelos/Usuarios';
import { environment } from './../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  urlBase: string = "";

  constructor(
    private http: HttpClient
  ) {
 
  }

  crearUser(usuarios: Usuarios) {
    console.log(usuarios);
    //return this.http.post(`${environment.url_api}/Usuario/agregar`, usuarios);
  }

  prueba() {
    console.log("prueba");
    this.http.get(`${environment.url_api}/usuario/index`);
  }

  login(usuario: string, contrasena: string) {
    //return this.http.get(`${environment.url_api}/Usuario/login/${usuario}/${contrasena}`);
  }
}
