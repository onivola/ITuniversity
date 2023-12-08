import javax.swing.JButton;
import javax.swing.table.AbstractTableModel;

public class ZModel  extends AbstractTableModel{
	private Object[][] data;
	private String[] title;
	
	public ZModel(Object[][] data,String[] title) {
		this.data = data;
		this.title=title;
	}

	@Override
	public int getColumnCount() {
		// TODO Auto-generated method stub
		return this.title.length;
	}

	@Override
	public int getRowCount() {
		// TODO Auto-generated method stub
		return this.data.length;
	}

	@Override
	public Object getValueAt(int row, int col) {
		// TODO Auto-generated method stub
		return this.data[row][col];
	}
	public String getColumnName(int col) {//pour afficher le titre
		return this.title[col];
	}
	//Retourne la classe de la donnée de la colonne 
	public Class getColumnClass(int col) { //remplacer boolean en case cocher
		 //On retourne le type de la cellule à la colonne demandée  
		//On se moque de la ligne puisque les types de données sont les mêmes quelle que soit la ligne  
		//On choisit donc la première ligne
		return this.data[0][col].getClass();
	}
	public boolean isCellEditable(int row, int col ) {//Retourne vrai si la cellule est éditable : celle-ci sera donc éditable
		if(getValueAt(0,col) instanceof JButton)
			return false; //return false si le cellule n'est pas editable
		return true;
	}
	//Vous devez bien distinguer un TableModel d'un DefaultTableCellRenderer. Le premier fait le lien entre les données et le tableau tandis que le second s'occupe de gérer l'affichage dans les cellules !

	
	
	
}
