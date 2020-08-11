import { Data } from "@angular/router";

export interface Usuarios {
  UsuarioId: number;
  CorreoElectronico: string;
  Usuario: string;
  Contrasena: string;
  Estatus: boolean;
  Sexo: number;
  FechaCreacion: Data;
}
