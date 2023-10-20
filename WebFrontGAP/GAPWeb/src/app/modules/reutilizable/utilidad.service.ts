import { Injectable } from '@angular/core';

import { MatSnackBar } from '@angular/material/snack-bar';
import { Sesion } from 'src/app/core/models/sesion';

@Injectable({
  providedIn: 'root'
})
export class UtilidadService {

  constructor(private _snackBar:MatSnackBar) { }

  saveUserSession(userSession:Sesion){
    localStorage.setItem("user",JSON.stringify(userSession));
  }

  getUserSession(){

    const dataCadena = localStorage.getItem("user");

    const usuario = JSON.parse(dataCadena!);
    return usuario

  }

  deleteUserSession(){
    localStorage.removeItem("usuer");
  }

}
