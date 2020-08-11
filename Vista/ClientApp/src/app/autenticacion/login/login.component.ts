import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UsuarioService } from './../../servicios/usuario.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  form: FormGroup;
  mensajeError: boolean;

  constructor(
    private formBuilder: FormBuilder,
    private usuarioService: UsuarioService,
    private router: Router
  ) {
    this.buildForm();
  }

  ngOnInit() {
  }

  guardar(event: Event) {
    event.preventDefault();
    if (this.form.valid) {
      const value = this.form.value;
      this.usuarioService.login(value.usuario, value.contrasena);
        //.subscribe(result => {
        //  if (result != null) {
        //    this.router.navigate(['./home']);
        //  } else {
        //    this.mensajeError = true;
        //  }
        //});
    }
  }

  private buildForm() {
    this.form = this.formBuilder.group({
      Usuario: ['', [Validators.required]],
      Contrasena: ['', [Validators.required]]
    });
  }

}
