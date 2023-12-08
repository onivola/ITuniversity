
public abstract class Animal { //ne peut pas etre instancier
	protected String couleur; //protected pour etre utiliser dans uneclasse heritie
	protected int poids;
	
	protected void manger() {
		
	}
	protected void boire() {
		
	}
	public abstract void deplacement(); //method abstrait ne posede pas de corps
	public abstract void crier();
	 
	 public String toString() {
		 String str = "Je suis un objet de la " +this.getClass() + ", je suis" +this.couleur + ",je pese " +this.poids;
		 return str;
	 }
	

}
