import { Component, OnInit } from '@angular/core';
import { FormBuilder,FormGroup,FormControl, Validators } from '@angular/forms';
import { NavController, NavParams } from '@ionic/angular';
import { CommonModule } from '@angular/common';
import {UserModel} from './user-model';
import {UserSing} from './user-sing';
import { CookieService} from 'ngx-cookie-service';
//INJECTED SERVICE
import { MyserviceService } from 'src/app/myservice.service';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastController } from '@ionic/angular';
@Component({
  selector: 'app-connexion',
  templateUrl: './connexion.component.html',
  styleUrls: ['./connexion.component.scss'],
})
export class ConnexionComponent implements OnInit {
  Date : any;
  singSuccessMSG = '';
  logSuccessMSG ='';
  singForm=new FormGroup({
    prenom: new FormControl('', [Validators.required,Validators.maxLength(50)]),
    nom: new FormControl('', [Validators.required,Validators.maxLength(50)]),
    email: new FormControl('', [Validators.required,Validators.email]),
    mdp: new FormControl('', [Validators.required,Validators.minLength(6),Validators.maxLength(12)]),
    phone: new FormControl('', [Validators.required,Validators.minLength(10),Validators.maxLength(12)]),
    adresse: new FormControl('', [Validators.required,Validators.maxLength(50)]),
    iam: new FormControl('par'),
    //profil: new FormControl('', [Validators.required])
  })
  get prenom() { return this.singForm.get('prenom');}
  get nom() { return this.singForm.get('nom');}
  get email() { return this.singForm.get('email');}
  get mdp() { return this.singForm.get('mdp');}
  get phone() { return this.singForm.get('phone');}
  get adresse() { return this.singForm.get('adresse');}
  get iam() { return this.singForm.get('iam');}

  logForm=new FormGroup({
    email1: new FormControl('', [Validators.required,Validators.email]),
    mdp1: new FormControl('', [Validators.required,Validators.minLength(6),Validators.maxLength(12)]),
    //profil: new FormControl('', [Validators.required])
  })
  get email1() { return this.logForm.get('email1');}
  get mdp1() { return this.logForm.get('mdp1');}
  //get profil() { return this.singForm.get('profil');}
  constructor(public toastController: ToastController,private cookieService: CookieService,private myService: MyserviceService,private _router: Router,private _activatedRoute: ActivatedRoute) {
   
    
   }


  
  UserlogModel = new UserModel('',''); //object user login
  UserSingModel = new UserSing('','','','','','','','');
 
  ngOnInit() {
    this.checkCookie();
  }
  checkCookie() {
    if(this.cookieService.get('_id')!='') {
      this.getUserById();
    }
  }
  getUserById() {
    this.myService.getUserById() //check cookie
    .subscribe(
      data => { 
        this._router.navigate(['/tabs/tab1']);
      },
      error =>  {
        this.cookieService.delete('token','/');
        this.cookieService.delete('_id','/');
      }
    )
  }
  checkIam(event){ 
    this.UserSingModel.iam=event.detail.value;
    console.log(this.UserSingModel.iam)
  }
  checkProfil(event){ 
    this.UserSingModel.profil=event.detail.value;
    console.log(this.UserSingModel.profil);
  }
    public logSubmit() {
      console.log(this.logForm.value);
      console.log(JSON.parse(JSON.stringify(this.UserlogModel))); //object to JSON
      this.myService.login(JSON.parse(JSON.stringify(this.UserlogModel)))
      .subscribe(
        data => { ///ok
          console.log(data);
          this.cookieService.set('token',String(data),1,'/'); //create,set cookie
          //localStorage.setItem('token',data); //save token
          this.getUsername();
        },
        error => {
          this.presentToast('danger','Email ou mot de passe incorrecte');
        }
      );
    }
    public singSubmit() {
      console.log(this.singForm.value);
      console.log(JSON.parse(JSON.stringify(this.UserSingModel)));
      //console.log(this.singForm.);
      this.myService.submitRegister(JSON.parse(JSON.stringify(this.UserSingModel)))
      .subscribe(
        data => {
          this.presentToast('success','Vous êtes inscrit');
        },
        error => {
          if(error.error.message=='inscrit') {
            this.presentToast('danger','Vous êtes déjà inscrit');
          } else {
            this.presentToast('danger','Erreur de connexion');
          }
         
        }
      );
      //console.log(this.UserSingModel);
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
    getUsername() {
      this.myService.getUsername()
      .subscribe(
        data => { 
          this.Date=data;
          console.log(this.Date._id);
          this.cookieService.set('_id',this.Date._id,1,'/');
          this._router.navigate(['/tabs/tab1']);
        },
        error => this._router.navigate(['/'])
      )
    }
}
