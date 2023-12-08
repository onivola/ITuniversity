
public class Chien extends Canin{
	public Chien() {
		
	}
	public Chien(String couleur,int poids) {
		this.couleur = couleur;
		this.poids = poids;
	}
	@Override
	public void crier() {
		// TODO Auto-generated method stub
		System.out.println("J'aboie sans raison !");
	}
	
}
