import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutRoutingModule } from './layout-routing.module';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { UsuarioComponent } from './pages/usuario/usuario.component';
import { ProductoComponent } from './pages/producto/producto.component';
import { PedidoComponent } from './pages/pedido/pedido.component';
import { HistorialPedidoComponent } from './pages/historial-pedido/historial-pedido.component';
import { ReporteComponent } from './pages/reporte/reporte.component';
import { SharedModule } from '../../modules/reutilizable/shared/shared.module'

@NgModule({
  declarations: [
    DashboardComponent,
    UsuarioComponent,
    ProductoComponent,
    PedidoComponent,
    HistorialPedidoComponent,
    ReporteComponent
  ],
  imports: [
    CommonModule,
    LayoutRoutingModule,
    SharedModule
  ]
})
export class LayoutModule { }
