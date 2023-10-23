import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Sesion } from 'src/app/core/models/sesion';
import { DatePipe } from '@angular/common';


@Injectable({
  providedIn: 'root'
})
export class UtilidadService {

  public sesion: Sesion | undefined;

  constructor(private _snackBar:MatSnackBar,
    private datePipe: DatePipe) { }

  tryParseDate(fecha: Date, format: string): string {
    try {
      const converted = this.datePipe.transform(fecha, format);
      return converted != null ? converted : '';
    } catch (e) {
      return '';
    }
  }

  saveUserSession(userSession:Sesion){
    debugger;
    localStorage.setItem("user",JSON.stringify(userSession));
  }

  getUserSession(){
    const dataCadena = localStorage.getItem("user");
    const usuario = JSON.parse(dataCadena!);
    return usuario
  }

  deleteUserSession(){
    localStorage.removeItem("user");
  }

}
