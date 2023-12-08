import { Component } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { ModalOffreComponent } from '../modal-offre/modal-offre.component';
import { MyserviceService } from '../myservice.service';//service
import { Router } from '@angular/router';
import { CookieService} from 'ngx-cookie-service';//cookie
import {Poste} from './poste';
import { JobPipe } from './job-pipe';
@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page {
  DBPoster: any;
  DBUser: any;
  adresse = '';
  search: string;
  constructor(public modalCtrl: ModalController,private cookieService: CookieService,private myService: MyserviceService,private _router: Router) {
    
  }
  ngOnInit() {
    this.checkCookie();
    this.getUserById();
    this.getPost();
  }
  async presentModal() {
    const modal = await this.modalCtrl.create({
      component: ModalOffreComponent,
      cssClass: 'my-custom-class'
    });
    return await modal.present();
  }
  getPost() {
    this.myService.getPoster() //check cookie
    .subscribe((res) => {
      
      this.DBPoster=res;

      console.log(this.DBPoster);
    })
  }
  getUserById() {
    this.myService.getUserById() //check cookie
    .subscribe(
      data => { 
        this.DBUser=data;
        console.log(this.DBUser);
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
