export interface ConsultaUsuario {
    id:number;
    logUsuario:string;
    primerNombre:string;
    segundoNombre:string;
    primerApellido:string;
    segundoApellido:string;
    email:string;  
    direccion:string; 
    telefono:string;
    flgActivo:boolean;
    imagen:string;
    idRol:number;
    rolDescripcion:string;
    fechaRegistroCadena:string;
}
