import { Component, inject, Inject, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Rol } from 'src/app/core/models/rol';
import { Usuario } from 'src/app/core/models/usuario';
import { UsuarioService } from 'src/app/services/http/usuario.service';
import { RolService } from 'src/app/services/http/rol.service';
import { UtilidadService } from 'src/app/modules/reutilizable/utilidad.service';
import { RegistroUsuarioResponse } from 'src/app/core/models/registro-usuario-response';
import { FiltroRegistrarUsuario } from 'src/app/core/models/filtro-registrar-usuario';

@Component({
  selector: 'app-modal-user',
  templateUrl: './modal-user.component.html',
  styleUrls: ['./modal-user.component.css']
})

export class ModalUserComponent implements OnInit {

  showLoading: boolean = false;
  formularioUsuario: FormGroup;
  hidePassword: boolean = true;
  tituloAccion: string = "Agregar";
  botonAccion: string = "Guardar";
  listaRoles: Rol[];
  registroUsuarioResponse: RegistroUsuarioResponse;
  
  public usuario: Usuario ;

  constructor(
    private modalActual: MatDialogRef<ModalUserComponent>,
    @Inject(MAT_DIALOG_DATA) public datosUsuario: Usuario,
    private fb: FormBuilder,
    private _rolService: RolService,
    private _userService: UsuarioService,
    private _utilidadService: UtilidadService,

  ) {

    this.formularioUsuario = this.fb.group({
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
      this.formularioUsuario.patchValue({
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
    
    const filtro = this.obtenerFiltroRegistroUSuario();

    this._userService.postUserAsync(filtro).subscribe((registroUsuarioResponse: RegistroUsuarioResponse) => {
      if (registroUsuarioResponse.transactionSuccess == true) {
        console.log("DDDDD")
        this.showLoading = false;
        return;
      }

      this.showLoading = false;
    });
  
  }

  obtenerFiltroRegistroUSuario(): FiltroRegistrarUsuario {
    const filtro = new FiltroRegistrarUsuario();
 
    filtro.id == null ? 0 : this.datosUsuario.id;
    filtro.primerNombre = this.formularioUsuario.value.primerNombre;
    filtro.segundoNombre = this.formularioUsuario.value.segundoNombre;
    filtro.primerApellido = this.formularioUsuario.value.primerApellido;
    filtro.segundoApellido = this.formularioUsuario.value.segundoApellido;
    filtro.logUsuario = this.formularioUsuario.value.logUsuario;
    filtro.contrasena = this.formularioUsuario.value.contrasena;
    filtro.direccion = this.formularioUsuario.value.direccion;
    filtro.telefono = this.formularioUsuario.value.telefono;
    filtro.fechaRegistroCadena=  this._utilidadService.tryParseDate(this.formularioUsuario.value.fechaRegistroCadena, 'dd/MM/yyyy');
    filtro.imagen= this.formularioUsuario.value.imagen;
    filtro.email= this.formularioUsuario.value.email;

    return filtro;
  }

}
