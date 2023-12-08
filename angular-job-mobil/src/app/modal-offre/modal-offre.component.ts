import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { FormBuilder,FormGroup,FormControl, Validators } from '@angular/forms';
import {Offre} from './Offre';
import { MyserviceService } from '../myservice.service';//service
import { Router } from '@angular/router';
import { CookieService} from 'ngx-cookie-service';//cookie
@Component({
  selector: 'app-modal-offre',
  templateUrl: './modal-offre.component.html',
  styleUrls: ['./modal-offre.component.scss'],
})
export class ModalOffreComponent implements OnInit {
  //cemail='';
  constructor(public modalCtrl: ModalController,private cookieService: CookieService,private myService: MyserviceService,private _router: Router) { 
   /* this.myService.getUsername() //check cookie
    .subscribe(
      data => { 
        this.cemail=data.toString();
        console.log(this.cemail);
      },
      error => this._router.navigate(['/'])
    )*/
  }
  /*offreForm=new FormGroup({
    gain: new FormControl('', [Validators.required,Validators.maxLength(50)]),
    comment: new FormControl('', [Validators.required,Validators.maxLength(50)]),
  })
  get gain() { return this.offreForm.get('gain');}
  get categorie2() { return this.offreForm.get('categorie2');}
  OffreModel = new Offre('1','2');
  dismiss() {
    // using the injected ModalController this page
    // can "dismiss" itself and optionally pass back data
    this.modalCtrl.dismiss({
      'dismissed': true
    });
  }*/
  ngOnInit() {}
  /*Submit() {
    console.log(this.OffreModel);
    alert(1);
  }
*/
}
