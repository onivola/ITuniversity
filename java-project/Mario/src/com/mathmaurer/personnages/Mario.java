package com.mathmaurer.personnages;

import java.awt.Image;

import javax.swing.ImageIcon;

import com.mathmaurer.jeu.Main;

public class Mario extends Personnage {
	//****VARIABLES****//

	private ImageIcon icoMario;
	private Image imgMario;
	private boolean saut; //vrai si mario saute
	private int compteurSaut; // duree du saut et hauteur du saut
	//****CONSTRUCTEUR****//
	public Mario(int x,int y) {
		super(x,y,28,50); //position et taille image
		this.icoMario = new ImageIcon(getClass().getResource("/images/marioMarcheDroite.png"));
		this.imgMario = this.icoMario.getImage();
		this.saut = false;
		this.compteurSaut = 0;
		
	}

	public Image getImgMario() { return imgMario; }

	public boolean isSaut() { return saut; }

	public void setSaut(boolean saut) { this.saut = saut; }
	
	public Image saute() {
		ImageIcon ico;
		Image img;
		String str;
		
		this.compteurSaut++;
		//montee du saut
		if(this.compteurSaut<=35) {
			if(this.getY()>Main.scene.getHauteurPlafond()) { this.setY(this.getY() - 4); }
			else { this.compteurSaut = 36; }
			if(this.isVersDroite()==true) { str = "/images/marioSautDroite.png"; }
			else { str = "/images/marioSautGauche.png"; }
		//retombe du saut
		} else if(this.getY()+this.getHauteur() < Main.scene.getySol()) { this.setY(this.getY() + 1);
			if(this.isVersDroite() == true) {str = "/images/marioSautDroite.png"; }
			else { str = "/images/marioSautGauche.png"; }
		//Saut termine
		} else {
			if(this.isVersDroite() == true) { str = "/images/marioSautDroite.png"; }
			else { str = "/images/marioSautGauche.png"; }
			this.saut = false;
			this.compteurSaut = 0;
		}
		//Affichage de l'image de mario
		ico = new ImageIcon(getClass().getResource(str));
		img = ico.getImage();
		return img;
		
	}
	
	
}
