import { Component, AfterViewInit, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialog } from '@angular/material/dialog';

import { ModalUserComponent } from '../../modals/modal-user/modal-user.component';
import { ConsultaUsuario } from 'src/app/core/models/consulta-usuario';
import { RegistroUsuarioResponse } from 'src/app/core/models/registro-usuario-response';
import { FiltroRegistrarUsuario } from 'src/app/core/models/filtro-registrar-usuario'; 
import { UtilidadService } from 'src/app/modules/reutilizable/utilidad.service';
import { UsuarioService } from 'src/app/services/http/usuario.service';

import Swal from 'sweetalert2';
import { Usuario } from 'src/app/core/models/usuario';
import { ConsultaUsuarios } from 'src/app/core/models/consulta-usuarios';
import { FiltroModificarUsuario } from 'src/app/core/models/filtro-modificar-usuario';
import { FiltroEliminarUsuario } from 'src/app/core/models/filtro-eliminar-usuario';
import { EliminarUsuarioResponse } from 'src/app/core/models/eliminar-usuario-response';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent implements OnInit,AfterViewInit {

  columnasTable: string[]= ['nombreCompleto','correo','roDescripcion','estado','acciones'];
  dataInicio: Usuario[] = [];
  listaUsuarios: ConsultaUsuarios[];
  dataListaUsuarios = new  MatTableDataSource(this.dataInicio);
  @ViewChild(MatPaginator) paginacionTabla!:MatPaginator;



  constructor(
    private dialog: MatDialog,
    private _userService:UsuarioService,
    private _utilidadService:UtilidadService
  ){}

  getUsersAsync(){

    this._userService.getAllUsersAsync().subscribe((usersResponse: ConsultaUsuarios[]) => {
      if (usersResponse.length != 0) {
        this.listaUsuarios = usersResponse
       
        return;
      }


 
    });

  }

  ngOnInit(): void {
    this.getUsersAsync()
  }

  ngAfterViewInit(): void {
      this.dataListaUsuarios.paginator = this.paginacionTabla
  }

  aplicarFiltroTabla(event: Event){
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataListaUsuarios.filter = filterValue.trim().toLocaleLowerCase();
  }

  rewUser(){
    this.dialog.open(ModalUserComponent, {
      disableClose:true
    }).afterClosed().subscribe(result => {
      if(result === "true") this.getUsersAsync();
    })
  }

  editUser(usuario:FiltroModificarUsuario){
    this.dialog.open(ModalUserComponent, {
      disableClose:true,
      data:usuario
    }).afterClosed().subscribe(result => {
      if(result === "true") this.getUsersAsync();
    })
  }

  deleteUser(usuario:FiltroEliminarUsuario){
    Swal.fire({
      title: '¿Desea eliminar el usuario?',
      text: usuario.logUsuario,
      icon: "warning",
      confirmButtonColor: "#3085d6",
      confirmButtonText: "Si, eliminar",
      showCancelButton: true,
      cancelButtonColor: '#d33',
      cancelButtonText: 'No, volver'
    }).then((result)=>{
      if(result.isConfirmed){
        
        this._userService.deleteUserAsync(usuario).subscribe((usersResponse: EliminarUsuarioResponse) => {
          if (usersResponse.id != 0) {
            this.getUsersAsync();
            return;
          }
          
        });
      }

    });
  }

}
