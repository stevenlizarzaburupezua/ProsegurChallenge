import { DetallePedido } from "./detalle-pedido";

export interface Pedido { 
    idVenta:number,
    numeroDocumento:string,
    tipoPago:string,
    fechaRegistroCadena:string,
    totalCadena:string,
    detallePedido: DetallePedido[]
}
