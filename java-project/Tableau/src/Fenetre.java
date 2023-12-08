import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JComponent;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;

public class Fenetre extends JFrame {
	private JTable tableau;
	public Fenetre() {
		this.setLocationRelativeTo(null);    
		 this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);   
		 this.setTitle("JTable");    
		 this.setSize(300, 120); 
		 Object[][] data= {
				 {"Cysboy","6boy", "Combo",new Boolean(false)},
				 {"BZHHydde","6boy", "Combo",new Boolean(false)},
				 {"IamBow","6boy", "Combo",new Boolean(true)},
				 {"Cysboy","6boy", "Combo",new Boolean(false)},
				 {"FunMan","6boy", "Combo",new Boolean(true)}
		 };
		 String title[] = { "pseudo","age","Taille","OK" };
		 ZModel model = new ZModel(data,title);
		 this.tableau = new JTable(model);
		 this.tableau.setDefaultRenderer(JComponent.class,new TableComponent());
		 this.tableau.getColumn("age").setCellRenderer(new ButtonRenderer()); //onrecupere la colonne grace a son titre puis on applique le rendu!
		 this.tableau.getColumn("Taille").setCellRenderer(new ComboRenderer());
		 this.getContentPane().add(new JScrollPane(tableau));
		 
		 
		
		 
		 
	}
	
}
