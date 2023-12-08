import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { ModalFicheComponent } from '../modal-fiche/modal-fiche.component';
import { MyserviceService } from '../myservice.service';//service
import { Router } from '@angular/router';
import { CookieService} from 'ngx-cookie-service';//cookie
import {User} from './user';
@Component({
  selector: 'app-tab3',
  templateUrl: 'tab3.page.html',
  styleUrls: ['tab3.page.scss']
})
export class Tab3Page implements OnInit {
  DBUser: any;
  constructor(private cookieService: CookieService,public modalCtrl: ModalController,private myService: MyserviceService,private _router: Router) {
    
  }
  ngOnInit() {
    this.checkCookie();
    this.getUserById();
    
    
  }
  async presentModal() {
    const modal = await this.modalCtrl.create({
      component: ModalFicheComponent,
      cssClass: 'my-custom-class'
    });
    return await modal.present();
  }
  toBool() {
    /*this.DBUser.beton=(this.DBUser.beton=='true');
    this.DBUser.carrosserie=(this.DBUser.carrosserie=='true');
    this.DBUser.electronique=(this.DBUser.electronique=='true');
    this.DBUser.joints=(this.DBUser.joints=='true');
    this.DBUser.menuisier=(this.DBUser.menuisier=='true');
    this.DBUser.meubles=(this.DBUser.meubles=='true');
    this.DBUser.monter=(this.DBUser.monter=='true');
    this.DBUser.moteur=(this.DBUser.moteur=='true');
    this.DBUser.papier=(this.DBUser.papier=='true');
    this.DBUser.pneus=(this.DBUser.pneus=='true');
    this.DBUser.vidange=(this.DBUser.vidange=='true');*/
  }
  logout() {
    //localStorage.removeItem('token');
    this.cookieService.delete('token','/');
    this.cookieService.delete('_id','/');
    this._router.navigate(['']);
  }
  getUserById() {
    this.myService.getUserById() //check cookie
    .subscribe(
      data => { 
        this.DBUser=data;
        //this.toBool();
        console.log(this.DBUser);
        console.log(this.DBUser.moteur);
      },
      error =>  this._router.navigate(['/'])
    )
  }
  checkCookie() {
    if(this.cookieService.get('_id')==null) {
      this._router.navigate(['/']);
    }
  }
}
