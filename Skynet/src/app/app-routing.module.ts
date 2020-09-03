import { NgModule } from '@angular/core';
// routermodule og routes for at kunne lave og huske vores routes
import { RouterModule, Routes } from '@angular/router';
//skal importere de components vi skal bruge for at kunne refere til dem

//Components der skal routes
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './auth/components/login/login.component';
import { RegisterComponent } from './auth/components/register/register.component';
import { TicketsComponent } from './tickets/tickets.component';
//"Redirect" redirecter den til vores start side, Vi skal dog lave vores start side og refere til den ellers kan den ikke finde den
const routes: Routes = [
	{ path: '', redirectTo: 'Home', pathMatch: 'full'},

	{ path: 'Home', component: HomeComponent},

	{ path: 'Login', component: LoginComponent},

	{ path: 'Register', component: RegisterComponent},

	{ path: 'Tickets', component: TicketsComponent}
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }
