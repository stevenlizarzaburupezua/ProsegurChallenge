import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './layout.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { HistorialPedidoComponent } from './pages/historial-pedido/historial-pedido.component';
import { PedidoComponent } from './pages/pedido/pedido.component';
import { ProductoComponent } from './pages/producto/producto.component';
import { ReporteComponent } from './pages/reporte/reporte.component';
import { UsuarioComponent } from './pages/usuario/usuario.component';

const routes: Routes = [{

  path:"",
  component:LayoutComponent,
  children:[
    {path:'dashboard',component:DashboardComponent},
    {path:'usuarios',component:UsuarioComponent},
    {path:'productos',component:ProductoComponent},
    {path:'pedido',component:PedidoComponent},
    {path:'historial_pedido',component:HistorialPedidoComponent},
    {path:'reporte',component:ReporteComponent},
  ]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LayoutRoutingModule { }
