import { NgModule } from '@angular/core';
// routermodule og routes for at kunne lave og huske vores routes
import { RouterModule, Routes } from '@angular/router';
//skal importere de components vi skal bruge for at kunne refere til dem
import { Test1Component } from './test1/test1.component';
import { Test2Component } from './test2/test2.component';
import { HomeComponent } from './home/home.component';

//"Redirect" redirecter den til vores start side, Vi skal dog lave vores start side og refere til den ellers kan den ikke finde den
const routes: Routes = [
  { path: '', redirectTo: 'Home', pathMatch: 'full'},
  { path: 'Test1', component: Test1Component },
  { path: 'Test2', component: Test2Component },
  { path: 'Home', component: HomeComponent },
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }
