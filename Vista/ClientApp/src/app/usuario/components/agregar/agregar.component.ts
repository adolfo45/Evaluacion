import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Usuarios } from './../../../modelos/Usuarios';
import { UsuarioService } from './../../../servicios/usuario.service';

@Component({
  selector: 'app-agregar',
  templateUrl: './agregar.component.html',
  styleUrls: ['./agregar.component.css']
})
export class AgregarComponent implements OnInit {

  form: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private usuarioService: UsuarioService
  ) {
    this.buildForm();
  }

  ngOnInit() {
  }

  guardar(event: Event) {
    event.preventDefault();
    if (this.form.valid) {
      const usuario: Usuarios = this.form.value;
      this.usuarioService.crearUser(usuario);
        //.subscribe(usuario => {
        //  console.log(usuario);
        //});
    }
  }

  save(event: Event) {
    event.preventDefault();
    this.usuarioService.prueba();
  }

  private buildForm() {
    this.form = this.formBuilder.group({
      UsuarioId: [0],
      Usuario: ['', [Validators.required]],
      Contrasena: ['', [Validators.required]],
      CorreoElectronico: ['', [Validators.required, Validators.email]],
      Sexo: ['', [Validators.required]],
      Estatus: [false],
      FechaCreacion: ['']
    });
  }

  get UsuarioField() {
    return this.form.get('Usuario');
  }
  get ContrasenaField() {
    return this.form.get('Contrasena');
  }
  get CorreoField() {
    return this.form.get('CorreoElectronico');
  }
  get SexoField() {
    return this.form.get('Sexo');
  }
  get ActivoField() {
    return this.form.get('Estatus');
  }
}
