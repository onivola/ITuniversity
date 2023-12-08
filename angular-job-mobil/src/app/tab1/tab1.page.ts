import { Component } from '@angular/core';
import { FormBuilder,FormGroup,FormControl, Validators } from '@angular/forms';
import {Poste} from './poste';
import { CookieService} from 'ngx-cookie-service';
import { MyserviceService } from '../myservice.service';//service
import { Router } from '@angular/router';
import { ToastController } from '@ionic/angular';
@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page {
  //cookie
  PostSuccessMSG='';
  DBUser: any;
  posteForm=new FormGroup({
    categorie1: new FormControl('',Validators.required),
    categorie2: new FormControl('',Validators.required),
    titre: new FormControl('', [Validators.required,Validators.maxLength(50)]),
    budjet: new FormControl('', [Validators.required,Validators.maxLength(50)]),
    description: new FormControl('', [Validators.required,Validators.maxLength(300)]),
    personne: new FormControl('',Validators.required),
    datejob: new FormControl('',Validators.required),
  })
  get categorie1() { return this.posteForm.get('categorie1');}
  get categorie2() { return this.posteForm.get('categorie2');}
  get prenom() { return this.posteForm.get('prenom');}
  get budjet() { return this.posteForm.get('budjet');}
  get description() { return this.posteForm.get('description');}
  get personne() { return this.posteForm.get('personne');}
  get datejob() { return this.posteForm.get('datejob');}

  
  constructor(public toastController: ToastController,private cookieService: CookieService,private myService: MyserviceService,private _router: Router) {
    
  }
  ngOnInit() {
    this.checkCookie();
    this.getUserById();
  }

  PosteModel = new Poste('','','','','','','','','','10-10-2020');
  Submit() {
    this.PosteModel.id_user = this.DBUser._id;
    this.PosteModel.adresse = this.DBUser.adresse;
    this.PosteModel.phone = this.DBUser.phone;
    console.log(this.PosteModel);
    console.log(this.posteForm.value);
    
   
    console.log(JSON.parse(JSON.stringify(this.PosteModel))); //object to JSON
    this.myService.CreatePoster(JSON.parse(JSON.stringify(this.PosteModel)))
    .subscribe(
      data => {
        this.presentToast('success','Job poster avec success');
      },
      error => {
        this.presentToast('danger','Erreur de modification');
      }
    ); 
  
  }

  mecanique = ['Monter, démonter', 'Vidange', 'Mécanique moteur', 'Changer pneus','Carrosserie'];
  mecaniqueVal = ['monter', 'vidange', 'moteur', 'pneus','carrosserie'];
  bricolage = ['Montage de meubles', 'Menuisier, ébéniste', 'Béton','Papier peint','Pose de joints', 'Electronique'];
  bricolageVal = ['meubles', 'menuisier', 'beton', 'papier','joints','electronique'];
  categorie = Object.assign([], this.mecanique);
  categorieVal = Object.assign([], this.mecaniqueVal);
  checkCat(event){ 
    console.log(event.detail.value);
   
    if(event.detail.value=='mecanique') {
      
      this.categorie = Object.assign([], this.mecanique);
      this.categorieVal = Object.assign([], this.mecaniqueVal);
      this.PosteModel.categorie2=this.mecaniqueVal[0];
    } else {
      this.categorie = Object.assign([], this.bricolage);
      this.categorieVal = Object.assign([], this.bricolageVal);
      this.PosteModel.categorie2=this.bricolageVal[0];
    }
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
        this.PosteModel.phone = this.DBUser.phone;
        this.PosteModel.adresse = this.DBUser.adresse;
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
