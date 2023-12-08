/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;
import java.util.Date;

/**
 *
 * @author Clogène
 */
public class Employer extends Basemodele {

   
	
	private int id=0;
    private String nom="";
    private String prenom="";
    private String adresse="";
    private String datenaissance="";
    private String dateajout="";
    
    public Employer() {

    }
    public Employer(String nom, String prenom,String datenaissance, String adresse) {
        this.nom = nom;
        this.prenom = prenom;
        this.adresse = adresse;
        this.datenaissance = datenaissance;
        this.setTable("employer");
        
    }
    public int getId() {
    	return id;
    }
    public void setId(int id) {
    	this.id=id;
    }
    public String getNom() {
        return nom;
    }
    
    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getPrenom() {
        return prenom;
    }

    public void setPrenom(String prenom) {
        this.prenom = prenom;
    }


    public String getAdresse() {
        return adresse;
    }

    public void setAdresse(String adresse) {
        this.adresse = adresse;
    }
    public String getDatenaissance() {
    	return this.datenaissance;
    }
    public void setDatenaissance(String date) {
    	this.datenaissance=date;
    }
    public String getDateajout() {
        return dateajout;
    }

    public void setDateajout(String date_ajout) {
        this.dateajout = date_ajout;
    }
   public String Getcurrentdatetime() {
         Date curent = new Date();
            int year = curent.getYear()+1900;
            int momth =curent.getMonth()+1;
         String datetime = "'"+year+"-"+momth+"-"+curent.getDate()+" "+ curent.getHours()+":"+curent.getMinutes()+":"+curent.getSeconds()+"'";
       return datetime;
   }
    
    
}
