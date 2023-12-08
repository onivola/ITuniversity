package com.mathmaurer.personnages;

import java.awt.Image;

import javax.swing.ImageIcon;

import com.mathmaurer.jeu.Main;
import com.mathmaurer.objets.Objet;

public class Personnage {
	private int largeur,hauteur;//dimensions du personnage
	private int x,y; //position du personnage
	private boolean marche; //vrai quand le personnage marche
	private boolean versDroite; //vrai quand le personnage est tourne vers la droite
	private int compteur;//compteur des pas du personnage
	
	//****CONSTRUCTEUR***/
	public Personnage(int x, int y,int largeur, int hauteur) { //initialisation
		this.largeur = largeur;
		this.hauteur = hauteur;
		this.x = x;
		this.y = y;
		this.compteur = 0;
		this.marche = false;
		this.versDroite = true;
	}

	//**** GETTERS ****//
	public int getLargeur() {
		return largeur;
	}

	public int getHauteur() {
		return hauteur;
	}

	public int getX() {
		return x;
	}

	public int getY() {
		return y;
	}

	public boolean isMarche() {
		return marche;
	}

	public boolean isVersDroite() {
		return versDroite;
	}

	public int getCompteur() {
		return compteur;
	}
	
	//**** SETTERS ***/
	public void setLargeur(int largeur) {
		this.largeur = largeur;
	}

	public void setHauteur(int hauteur) {
		this.hauteur = hauteur;
	}

	public void setX(int x) {
		this.x = x;
	}

	public void setY(int y) {
		this.y = y;
	}

	public void setMarche(boolean marche) {
		this.marche = marche;
	}

	public void setVersDroite(boolean versDroite) {
		this.versDroite = versDroite;
	}

	public void setCompteur(int compteur) {
		this.compteur = compteur;
	}
	
	//****METHODES****//
	
	public Image marche(String nom,int frequence) {//return l'image du personnage qui marche
		String str;
		ImageIcon ico;
		Image img;
		
		if(this.marche==false || Main.scene.getxPos() <=0) { //si le personnage est a l'arret ou completement a gauche de l'ecran
			if(this.versDroite==true) { str="/images/"+nom+"ArretDroite.png"; } 
			else { str="/images/"+nom+"ArretGauche.png"; }
		} else {
			this.compteur++;
			if(this.compteur/frequence==0) {
				if(this.versDroite==true) { str="/images/"+nom+"ArretDroite.png"; } 
				else { str="/images/"+nom+"ArretGauche.png"; }
			} else {
				if(this.versDroite==true) { str="/images/"+nom+"MarcheDroite.png"; } 
				else { str="/images/"+nom+"MarcheGauche.png"; }
				
			}
			if(this.compteur == 2*frequence) { this.compteur = 0; }
		}
		//affichage de l'image de personnage
		ico = new ImageIcon(getClass().getResource(str));
		img = ico.getImage();
		return img;
	}
	//le contacte de l'objet sont tous les meme pour tout les personnage
	public boolean contactAvant(Objet objet) { //
		if(this.isVersDroite()==true) {
			//4 vas ou il ya pas contact
			if(this.x+this.largeur<objet.getX() || this.x+this.largeur > objet.getX() +5 || this.y+this.hauteur<=objet.getY() || this.y >= objet.getY() + objet.getHauteur()) { //mario est troup a gauche
				//mario trop a gauche
				//mario trop a droite
				//mario trop haut
				//mario trop bas
				return false;
			} else {
				return true;
			}
		} else { return false; }
	}
	
}
