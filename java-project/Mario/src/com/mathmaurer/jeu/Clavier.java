package com.mathmaurer.jeu;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class Clavier implements KeyListener{

	@Override
	public void keyPressed(KeyEvent arg0) {// quand on presse
		if(arg0.getKeyCode()==KeyEvent.VK_RIGHT) {
			Main.scene.setDx(1);
			if(Main.scene.getxPos()==-1) {
				Main.scene.setxPos(0);
				Main.scene.setxFond1(-50);
				Main.scene.setxFond2(750);
				
			}
			Main.scene.mario.setMarche(true);
			Main.scene.mario.setVersDroite(true);
		} else if(arg0.getKeyCode()==KeyEvent.VK_LEFT) {
			Main.scene.mario.setMarche(true);
			Main.scene.mario.setVersDroite(false);
			Main.scene.setDx(-1);
			
		}
		if(arg0.getKeyCode() == KeyEvent.VK_SPACE) {
			Main.scene.mario.setSaut(true);
		}
		
	}

	@Override
	public void keyReleased(KeyEvent arg0) {//quand on relache
		Main.scene.mario.setMarche(false);
		Main.scene.setDx(0);
	}

	@Override
	public void keyTyped(KeyEvent arg0) {
		// TODO Auto-generated method stub
		
	}
	
}
