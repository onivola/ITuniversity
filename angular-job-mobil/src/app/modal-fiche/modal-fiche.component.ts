import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { FormBuilder,FormGroup,FormControl, Validators } from '@angular/forms';
import {UserEdit} from './user-edit';
import { MyserviceService } from '../myservice.service';//service
import { Router } from '@angular/router';
import { CookieService} from 'ngx-cookie-service';//cookie
import { ToastController } from '@ionic/angular';
@Component({
  selector: 'app-modal-fiche',
  templateUrl: './modal-fiche.component.html',
  styleUrls: ['./modal-fiche.component.scss'],
})
export class ModalFicheComponent implements OnInit {
  editSuccessMSG='';
  editErrorMSG='';
  DBUser:any;
  editForm=new FormGroup({
    prenom: new FormControl('', [Validators.required,Validators.maxLength(50)]),
    nom: new FormControl('', [Validators.required,Validators.maxLength(50)]),
    mdp: new FormControl('', [Validators.required,Validators.minLength(6),Validators.maxLength(12)]),
    phone: new FormControl('', [Validators.required,Validators.minLength(10),Validators.maxLength(12)]),
    adresse: new FormControl('', [Validators.required,Validators.maxLength(50)]),
    presentation: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required]),
    iam: new FormControl('', [Validators.required]),
    profil: new FormControl('', [Validators.required]),

     //Bricolage	
     meubles: new FormControl(),
     menuisier: new FormControl(),
     beton: new FormControl(),
     papier: new FormControl(),
     joints: new FormControl(),
     electronique: new FormControl(),
       //Mécanique	
     monter: new FormControl(),
     vidange: new FormControl(),
     moteur: new FormControl(),
     pneus: new FormControl(),
     carrosserie: new FormControl(),
   
   
  })
  get prenom() { return this.editForm.get('prenom');}
  get nom() { return this.editForm.get('nom');}
  get mdp() { return this.editForm.get('mdp');}
  get phone() { return this.editForm.get('phone');}
  get adresse() { return this.editForm.get('adresse');}
  get presentation() { return this.editForm.get('presentation');}
  get email() { return this.editForm.get('email');}
  get iam() { return this.editForm.get('iam');}
  get profil() { return this.editForm.get('profil');}

  //Bricolage	
  get meubles(){ return this.editForm.get('meubles');}
  get menuisier(){ return this.editForm.get('menuisier');}
  get beton(){ return this.editForm.get('beton');}
  get papier(){ return this.editForm.get('papier');}
  get joints(){ return this.editForm.get('joints');}
  get electronique(){ return this.editForm.get('electronique');}
    //Mécanique	
  get monter(){ return this.editForm.get('monter');}
  get vidange(){ return this.editForm.get('vidange');} 
  get moteur(){ return this.editForm.get('moteur');}
  get pneus(){ return this.editForm.get('pneus');}
  get carrosserie(){ return this.editForm.get('carrosserie');}
  
  constructor(public toastController: ToastController,public modalCtrl: ModalController,private cookieService: CookieService,private myService: MyserviceService,private _router: Router) { 
    
  }

  userEditModel = new UserEdit('vola@ymail.com','Vola','RAZAFY','','0344164941','sdf','15B05','sdfsdf',true,false,true,false,false,false,true,false,false,false,false);
  dismiss() {
    // using the injected ModalController this page
    // can "dismiss" itself and optionally pass back data
    this.modalCtrl.dismiss({
      'dismissed': true
    });
  }
  ngOnInit() {
    this.checkCookie();
    this.getUserById();
  }
  editSubmit() {
    console.log(this.DBUser);
    console.log(this.editForm.value);
    this.myService.putUserById(this.editForm.value) .subscribe(
      data => {
        this.presentToast('success','Modification avec success');
      },
      error => {
        this.presentToast('danger','Erreur de connexion');
      }
    );
    //alert(1);
  }
  //TOAST
  async presentToast(couleur,msg) {
    const toast = await this.toastController.create({
      message: msg,
      duration: 2000,
      color:couleur
    });
    toast.present();
  }

  async presentToastWithOptions() {
    const toast = await this.toastController.create({
      header: 'Toast header',
      message: 'Click to Close',
      position: 'top',
      buttons: [
        {
          side: 'start',
          icon: 'star',
          text: 'Favorite',
          handler: () => {
            console.log('Favorite clicked');
          }
        }, {
          text: 'Done',
          role: 'cancel',
          handler: () => {
            console.log('Cancel clicked');
          }
        }
      ]
    });
    toast.present();
  }
  getUserById() {
    this.myService.getUserById() //check cookie
    .subscribe(
      data => { 
        this.DBUser=data;
        this.DBUser.mdp='';
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
