import { Component, inject, Inject, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Rol } from 'src/app/core/models/rol';
import { Usuario } from 'src/app/core/models/usuario';
import { UsuarioService } from 'src/app/services/http/usuario.service';
import { RolService } from 'src/app/services/http/rol.service';
import { UtilidadService } from 'src/app/modules/reutilizable/utilidad.service';

@Component({
  selector: 'app-modal-user',
  templateUrl: './modal-user.component.html',
  styleUrls: ['./modal-user.component.css']
})

export class ModalUserComponent implements OnInit {

  showLoading: boolean = false;
  formularioLogin: FormGroup;
  hidePassword: boolean = true;
  tituloAccion: string = "Agregar";
  botonAccion: string = "Guardar";
  listaRoles: Rol[];
  public usuario: Usuario ;

  constructor(
    private modalActual: MatDialogRef<ModalUserComponent>,
    @Inject(MAT_DIALOG_DATA) public datosUsuario: Usuario,
    private fb: FormBuilder,
    private _rolService: RolService,
    private _userService: UsuarioService,
    private _utilidadService: UtilidadService,

  ) {

    this.formularioLogin = this.fb.group({
      logUsuario: ["", Validators.required],
      contrasena: ["", Validators.required],
      primerNombre: ["", Validators.required],
      primerApellido: ["", Validators.required],
      email: ["", Validators.email],
      segundoNombre: [""],
      segundoApellido: [""],
      direccion: [""],
      telefono: [""],
      fechaRegistroCadena: [""],
      imagen: [""],
    });

    if (this.datosUsuario != null) {
      this.tituloAccion = "Editar";
      this.botonAccion = "Actualizar";
    }

    this._rolService.getAllRolesAsync().subscribe((roles: Rol[]) => {
      if (roles.length == 0) {

        this.showLoading = false;
        return;
      }


      this.showLoading = false;
    });


  }

  ngOnInit(): void {
    if (this.datosUsuario != null) {
      this.formularioLogin.patchValue({
        logUsuario: this.datosUsuario.logUsuario,
        contrasena: this.datosUsuario.contrasena,
        primerNombre: this.datosUsuario.primerNombre,
        primerApellido: this.datosUsuario.primerApellido,
        email: this.datosUsuario.email,
        segundoNombre: this.datosUsuario.segundoNombre,
        segundoApellido: this.datosUsuario.segundoApellido,
        direccion: this.datosUsuario.direccion,
        telefono: this.datosUsuario.telefono,
        fechaRegistroCadena: this.datosUsuario.fechaRegistroCadena,
        imagen: this.datosUsuario.imagen,
      });
    }
  }

  SaveOrUpdateUser() {
   
    this.usuario.id == null ? 0 : this.datosUsuario.id;
    this.usuario.primerNombre = this.formularioLogin.value.primerNombre;
    this.usuario.segundoNombre = this.formularioLogin.value.segundoNombre;
    this.usuario.primerApellido = this.formularioLogin.value.primerApellido;
    this.usuario.segundoApellido = this.formularioLogin.value.segundoApellido;
    this.usuario.logUsuario = this.formularioLogin.value.logUsuario;
    this.usuario.contrasena = this.formularioLogin.value.contrasena;
    this.usuario.direccion = this.formularioLogin.value.direccion;
    this.usuario.telefono = this.formularioLogin.value.telefono;
    this.usuario.fechaRegistroCadena= this.formularioLogin.value.fechaRegistroCadena;
    this.usuario.imagen= this.formularioLogin.value.imagen;
    this.usuario.email= this.formularioLogin.value.email;
  
  }

}
