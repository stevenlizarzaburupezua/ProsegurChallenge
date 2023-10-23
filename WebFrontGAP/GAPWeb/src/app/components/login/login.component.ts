import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Login } from 'src/app/core/models/login';
import { UsuarioService } from 'src/app/services/http/usuario.service';
import { UtilidadService } from 'src/app/modules/reutilizable/utilidad.service';
import { Usuario } from 'src/app/core/models/usuario';
import { Sesion } from 'src/app/core/models/sesion';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  formularioLogin: FormGroup;
  hidePassword: boolean = true;
  showLoading: boolean = false;
  public sesion: Sesion | undefined;


  constructor(
    private fb: FormBuilder,
    private router: Router,
    private _userService: UsuarioService,
    private _utilidadService: UtilidadService,

  ) {
    this.formularioLogin = this.fb.group({
      logUsuario: ["", Validators.required],
      contrasena: ["", Validators.required]
    })
  }

  ngOnInit(): void {
  }

  login() {

    this.showLoading = true;

    const request: Login = {
      logUsuario: this.formularioLogin.value.logUsuario,
      contrasena: this.formularioLogin.value.contrasena
    }

    this._userService.getLoginAsync(request.logUsuario, request.contrasena).subscribe((responseSesion: Sesion) => {
      if (responseSesion != null && responseSesion.idUsuario !== 0) {
        this._utilidadService.saveUserSession(responseSesion)
        this.showLoading = false;
        this.sesion = responseSesion;
        return;
      }

      this.showLoading = false;
    });

  }

}
