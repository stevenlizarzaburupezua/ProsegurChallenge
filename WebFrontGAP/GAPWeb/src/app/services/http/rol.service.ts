import { Injectable } from '@angular/core';
import { Rol } from 'src/app/core/models/rol';
import { ApiService } from './api.service';
import * as Url from '../../core/constants/api.constants';
import { Observable, throwError } from 'rxjs';
import { map, tap, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RolService {
  constructor(private apiService: ApiService) { }

  getAllRolesAsync(): Observable<Rol[]> {
    return this.apiService.query(Url.Rol.GET_ROLES, '')
      .pipe(tap(data => data));
  }

  ggetRolAsync(idRol: number): Observable<Rol> {
    return this.apiService.query(Url.Rol.GET_ROL, {idRol})
    .pipe(tap(data => data));
  }

}
