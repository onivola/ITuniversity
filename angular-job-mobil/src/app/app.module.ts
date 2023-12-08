import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';  
import { RouteReuseStrategy } from '@angular/router';

import { IonicModule, IonicRouteStrategy } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import {FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http'
import {ConnexionComponent} from './connexion/connexion.component';
import {ModalFicheComponent} from './modal-fiche/modal-fiche.component';
import {ModalOffreComponent} from './modal-offre/modal-offre.component';
import { MyserviceService } from 'src/app/myservice.service';
import { CookieService} from 'ngx-cookie-service';//cookie
//import {Tab1Page} from './tab1/tab1.page';
@NgModule({
  declarations: [AppComponent,ConnexionComponent,ModalFicheComponent,ModalOffreComponent],
  entryComponents: [],
  imports: [HttpClientModule, BrowserModule, IonicModule.forRoot(),CommonModule, AppRoutingModule,ReactiveFormsModule],
  providers: [
    CookieService,
    MyserviceService,
    StatusBar,
    SplashScreen,
    { provide: RouteReuseStrategy, useClass: IonicRouteStrategy }
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
