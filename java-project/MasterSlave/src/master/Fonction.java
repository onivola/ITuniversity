package master;

import java.util.Vector;

import model.Employer;

public class Fonction {
	public static Vector GetDay() {
		Vector vday = new Vector();
		for(int i=1;i<=31;i++) {
			vday.add(i);
		}
		return vday;
	}
	public static Vector GetDayByMonth(String month) {
		
		if(month=="Janvier" || month=="Mars" || month=="Mai" || month=="Juillet" || month=="Août" || month=="Octobre" || month=="Décembre") {
			Vector vday = new Vector();
			for(int i=1;i<=31;i++) {
				vday.add(i);
			}
			return vday;
		} else if(month=="Avril" || month=="Juin" || month=="Septembre" || month=="Novembre") {
			Vector vday = new Vector();
			for(int i=1;i<=30;i++) {
				vday.add(i);
			}
			return vday;
		} else if(month=="Février") {
			Vector vday = new Vector();
			for(int i=1;i<=29;i++) {
				vday.add(i);
			}
			return vday;
		}
		return null;
	}
	public static Vector GetMonth() {
		Vector vmonthdate = new Vector();
		Vector vmonth = new Vector();
		vmonth.add("Janvier");//31
		vmonth.add("Février"); //28 mais si ans divisible par 4 29
		vmonth.add("Mars");//31
		vmonth.add("Avril");//30
		vmonth.add("Mai");//31
		vmonth.add("Juin");//30
		vmonth.add("Juillet");//31
		vmonth.add("Août");//31
		vmonth.add("Septembre");//30
		vmonth.add("Octobre");//31
		vmonth.add("Novembre");//30
		vmonth.add("Décembre");//31
		
		vmonthdate.add(vmonth);
		//vmonthdate.add(arg0)
		return vmonth;
	}
	public static int getMonthNumber(String month) {
		
		if(month=="Janvier") {
			return 1;
		} else if(month=="Février") {
			return 2;
		} else if(month=="Mars") {
			return 3;
		} else if(month=="Avril") {
			return 4;
		} else if(month=="Mai") {
			return 5;
		} else if(month=="Juin") {
			return 6;
		} else if(month=="Juillet") {
			return 7;
		} else if(month=="Août") {
			return 8;
		} else if(month=="Septembre") {
			return 9;
		} else if(month=="Octobre") {
		 	return 10;
		} else  if(month=="Novembre") {
			return 11;
		} else  if(month=="Décembre") {
			return 12;
		}  else {
			return 0;
		}
		
	}
	public static String YearsValid(int years) {
		String erreur="";
		if(years<=0) {
			return "NON";
		}
		return "OK";
	}
	public static String FormInsert(Employer emp,int month, int day,String years) {
		String erreur="";
		
		if(!emp.getNom().equals("") && !emp.getPrenom().equals("")  && !emp.getAdresse().equals("") && !years.equals("")) { //si les champ ne sont pas vide
			//return "OK";
			 try {    
				 Integer.parseInt(years);
			 } catch (NumberFormatException e) {    
				System.out.println("Division par zéro !"); 
				return "Date de naissance invalide";
			}
			 String testyesrs = YearsValid(Integer.parseInt(years));
			if(testyesrs=="OK") {
				return "OK";
			} else {
				return "Date de naissance invalide";
			}
          } else {
        	 return erreur = "Tout les chanps sont obligatoire";
        	  
          }
	}
}
