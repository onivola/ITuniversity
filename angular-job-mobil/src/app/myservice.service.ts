import { Injectable } from '@angular/core';
import { HttpClient,HttpParams } from '@angular/common/http';
import {UserEdit} from './modal-fiche/user-edit';
import {Poste} from './tab1/poste';
import { CookieService} from 'ngx-cookie-service'; //npm install ngx-cookie-service
@Injectable({
  providedIn: 'root'
})
export class MyserviceService { //ng g s myservice
  //url = 'http://localhost:3000';///////////////// URL SERVICE
  url = 'https://itu-res-api.herokuapp.com';///////////////// URL SERVICE
  
  constructor(private cookieService: CookieService,private _http:HttpClient) { }
  /////////////////////////////////USERS///////////////////////////
  //REGISTRE
  submitRegister(body:any) {
    return this._http.post(this.url+'/users/register',body,{
      observe:'body'
    })
  }
  //LOGIN
  login(body:any) {
    return this._http.post(this.url+'/users/login',body,{
      observe:'body'
    })
  }
  //getToken
  getUsername() {
    return this._http.get(this.url+'/users/username', {
      observe:'body',
      params: new HttpParams().append('token',this.cookieService.get('token'))
    });
  }
  //getToken
  getUserById() {
    return this._http.get(this.url+'/users/getById/'+this.cookieService.get('_id'), {
      observe:'body',
      params: new HttpParams().append('token',this.cookieService.get('token'))
    });
  }
  //update user
  putUserById(UserEdit: UserEdit) {
    return this._http.put(this.url+'/users/'+this.cookieService.get('_id'),UserEdit, {
      observe:'body',
      params: new HttpParams().append('token',this.cookieService.get('token'))
    });
  }
  /////////////////////////////////POSTERS///////////////////////////
  CreatePoster(Poste: Poste) {
    return this._http.post(this.url+'/posters/poster',Poste,{
      observe:'body',
      params: new HttpParams().append('token',this.cookieService.get('token'))
    })
  }
  getPoster() {
    return this._http.get(this.url+'/posters', {
      observe:'body',
      params: new HttpParams().append('token',this.cookieService.get('token'))
    });
  }
}

/*

http://localhost:3000/users/getById/5f89d0aca80be8d754bfabd0?token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjp7Il9pZCI6IjVmODlkMGFjYTgwYmU4ZDc1NGJmYWJkMCIsIm5vbSI6IlJBS09UTyIsImVtYWlsIjoibWFuamFAeW1haWwuY29tIiwibWRwIjoiJDJiJDEwJGlLbktEck5ZdHMvRWdMM0xoLkRseE9JYngxVE9SRFVza294dnlwelkwU3dBeUo1V3pBZEdpIiwicGhvbmUiOiIwMzQ0MTY0OTEwIiwiaWFtIjoicGFyIiwiYWRyZXNzZSI6ImFudHNpcmFiZSIsInByb2ZpbCI6InBvc3RldXIiLCJwcmVzZW50YXRpb24iOiIiLCJtZXVibGVzIjoiZmFsc2UiLCJtZW51aXNpZXIiOiJmYWxzZSIsImJldG9uIjoiZmFsc2UiLCJwYXBpZXIiOiJmYWxzZSIsImpvaW50cyI6ImZhbHNlIiwiZWxlY3Ryb25pcXVlIjoiZmFsc2UiLCJtb250ZXIiOiJmYWxzZSIsInZpZGFuZ2UiOiJmYWxzZSIsIm1vdGV1ciI6ImZhbHNlIiwicG5ldXMiOiJmYWxzZSIsImNhcnJvc3NlcmllIjoiZmFsc2UiLCJkYXRlIjoiMjAyMC0xMC0xNlQxNjo1NjoxMi4xNTJaIiwiX192IjowfSwiaWF0IjoxNjAyOTI0MjQzLCJleHAiOjE2MDI5MzUwNDN9.VTR4XaBIZQltSpvCn6gGjsWA2U3qWWtfhll0KaAkJSw
*/