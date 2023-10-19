import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { RegistroSistemaComponent } from './components/registro-sistema/registro-sistema.component';

const routes: Routes = [
  {path:"", component:LoginComponent,pathMatch:"full"},
  {path:"login", component:LoginComponent,pathMatch:"full"},
  {path:"registro-sistema", component:RegistroSistemaComponent,pathMatch:"full"},
  {path:"pages",loadChildren:() => import("./components/layout/layout.module").then(m => m.LayoutModule)},
  {path:'**',redirectTo:'login',pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
