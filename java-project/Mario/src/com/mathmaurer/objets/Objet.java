package com.mathmaurer.objets;

import com.mathmaurer.jeu.Main;

public class Objet {
	private int largeur, hauteur; //dimension de l'objet
	private int x,y; //position de l'objet
	
	
	
	//****CONSTRUCTEUR***/
	public Objet(int x, int y, int largeur, int hauteur) {
		this.x = x;
		this.y = y;
		this.largeur = largeur;
		this.hauteur = hauteur;
		
	}



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
	
	//***METHODE****//
	public void deplacement() { //gerer le depplacement
		if(Main.scene.getxPos() >=0) {
			this.x = this.x - Main.scene.getDx();
		}
		
	}
}
