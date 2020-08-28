import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { User } from './user';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {
		private usersUrl = 'https://localhost:5001/api/User';
	//private usersUrl = 'https://localhost:44395/api/User';
  constructor(
  	private http: HttpClient) {
  	 }
  getUsers(){
  	return this.http.get<User[]>(this.usersUrl);
  }
}
//c:\javapath\Skynet\Skynet