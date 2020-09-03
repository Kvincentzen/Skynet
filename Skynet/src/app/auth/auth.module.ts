import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AppRoutingModule } from '../app-routing.module';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { TicketsComponent } from '../tickets/tickets.component';


@NgModule({
  declarations: [LoginComponent, RegisterComponent, TicketsComponent],
  imports: [
    CommonModule,
    AppRoutingModule
  ],
  exports: [
  LoginComponent,
  RegisterComponent,
  TicketsComponent,
  AppRoutingModule
  ]
})
export class AuthModule { }
