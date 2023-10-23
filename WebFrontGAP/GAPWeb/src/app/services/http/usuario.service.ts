import { Injectable } from '@angular/core';
import { map, tap, catchError } from 'rxjs/operators';
import { Observable, throwError } from 'rxjs';
import { ApiService } from './api.service';
import { Usuario } from '../../core/models/usuario'
import * as Url from '../../core/constants/api.constants';
import { Sesion } from 'src/app/core/models/sesion';
import { FiltroRegistrarUsuario } from 'src/app/core/models/filtro-registrar-usuario';
import { RegistroUsuarioResponse } from 'src/app/core/models/registro-usuario-response';
import { ConsultaUsuario } from 'src/app/core/models/consulta-usuario';
import { ConsultaUsuarios } from 'src/app/core/models/consulta-usuarios';
import { FiltroEliminarUsuario } from 'src/app/core/models/filtro-eliminar-usuario';
import { EliminarUsuarioResponse } from 'src/app/core/models/eliminar-usuario-response';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  constructor(private apiService: ApiService) { }

  getAllUsersAsync(): Observable<ConsultaUsuarios[]> {
    return this.apiService.query(Url.Usuario.GET_USERS, '')
      .pipe(tap(data => data));
  }

  getUsersAsync(idUSuario: number): Observable<ConsultaUsuario> {
    return this.apiService.query(Url.Usuario.GET_USER, {idUSuario})
    .pipe(tap(data => data));
  }

  getLoginAsync(logUsuario: string, contrasena:string): Observable<Sesion> {
      const queryString = { logUsuario, contrasena };
      return this.apiService.query(Url.Usuario.GET_LOGIN_USER, queryString)
                            .pipe(tap(data => data));
  }

  postUserAsync(filtro: FiltroRegistrarUsuario) : Observable<RegistroUsuarioResponse>  {
    return this.apiService.post(Url.Usuario.POST_USER, filtro)
                          .pipe(tap(data => data));
  }

  deleteUserAsync(filtro: FiltroEliminarUsuario) : Observable<EliminarUsuarioResponse>  {
    return this.apiService.post(Url.Usuario.DELETE_USER, filtro)
                          .pipe(tap(data => data));
  }


  // consultarActaTransferencia(filtro: FiltroTransferencia): Observable<ConsultaActaTransferencia[]> {
  //     return this.apiService.query(Url.ActaTransferencia.CONSULTA_TRANSFERENCIA, filtro)
  //                           .pipe(tap(data => data));
  // }

  // getNuevoNroActa(codempresa: string , codCartera: string): Observable<number> {
  //     const queryString =  {codempresa, codCartera};
  //     return this.apiService.query(Url.ActaTransferencia.GET_NUEVO_NRO_ACTA, queryString)
  //                           .pipe(tap(data => data));
  // }

  // getMaximoNroOperacion(codempresa: string , codCartera: string, nroActa: number): Observable<number> {
  //     const queryString = { codempresa, codCartera, nroActa };
  //     return this.apiService.query(Url.ActaTransferencia.GET_MAXIMO_NRO_OPERACION, queryString)
  //                           .pipe(tap(data => data));
  // }

  // validarExisteNroOperacion(codempresa: string , codCartera: string, nroActa: number, nroOperacion): Observable<boolean> {
  //     const queryString = { codempresa, codCartera, nroActa, nroOperacion };
  //     return this.apiService.query(Url.ActaTransferencia.VALIDAR_EXISTE_NRO_OPERACION, queryString)
  //                           .pipe(tap(data => data));
  // }

  // obtenerActaTransferencia(codempresa: string , codCartera: string, nroActa: number, codUsuario: number): Observable<ActaTransferencia> {
  //     const queryString = { codempresa, codCartera, nroActa, codUsuario };
  //     return this.apiService.query(Url.ActaTransferencia.OBTENER_ACTA_TRANSFERENCIA, queryString)
  //                           .pipe(tap(data => data));
  // }

  // registrarActaTransferencia(request: ActaTransferenciaRequest): Observable<TransaccionReponse> {
  //     return this.apiService.post(Url.ActaTransferencia.REGISTRAR_ACTA_TRANSFERENCIA, request)
  //                           .pipe(tap(data => data));
  // }

  // ValidarActasPendiente(actaTransferencia: ActaTransferenciaPartial): Observable<ValidacionActaResponse> {
  //     return this.apiService.post(Url.ActaTransferencia.VALIDAR_ACTA_PENDIENTE, actaTransferencia)
  //                           .pipe(tap(data => data));
  // }

  // validarActaTransferencia(request: ValidacionActaRequest): Observable<ValidacionActaResponse> {
  //     return this.apiService.post(Url.ActaTransferencia.VALIDAR_ACTA_TRANSFERENCIA, request)
  //                           .pipe(tap(data => data));
  // }

  // actualizarActaEnTransito(actaTransferencia: ActaTransferenciaPartial): Observable<TransaccionReponse> {
  //     return this.apiService.post(Url.ActaTransferencia.ACTUALIZAR_ACTA_EN_TRANSITO, actaTransferencia)
  //                           .pipe(tap(data => data));
  // }




}
