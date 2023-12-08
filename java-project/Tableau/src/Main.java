
public class Main {
	double addition(int a,int b)
	{
		double ab=a+b;
		return ab;
	}
	int delta(int a,int b,int c)//type de retour, //argument
	{
		return ((b*b)-(4*a*c));
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Fenetre fen = new Fenetre();
		fen.setVisible(true);
		
		int a=2;
		int b=3;
		
		
		///DEBUT NOMBRE PREMIER
		boolean premier=true;
		for(int i=0;i<=100;i++) 
		{
			if(i==1 || i==2 || i== 3) 
			{
				premier=true;
			}
			else {
				for(int j=2;j<i;j++)
				{
					
					if(i%j==0) 
					{
						premier=false;
					}
					
				}
			}  
			if(premier==true) 
			{
				System.out.println(i);
				
			}
				premier=true;
			
		}
		String nom = new String("nom");
		///FIN NOMBRE PREMIER
		int[] nombre1d  = {5,9,6,6,8,9,3,4};
		for(int i=0;i<nombre1d.length;i++)
		{
			//System.out.println(nombre1d[i]);
		}
		
		int[][] nombre2d  = {{5,6,8},{4,6,8,9},{6,3,1}};
		
		//System.out.println(nombre2d[0][0]);
		//System.out.println(nombre2d[1][3]);

	}
}
