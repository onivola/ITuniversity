import java.awt.Component;

import javax.swing.JButton;
import javax.swing.JTable;
import javax.swing.table.TableCellRenderer;

public class ButtonRenderer extends JButton implements TableCellRenderer{

	@Override
	public Component getTableCellRendererComponent(JTable arg0, Object value, boolean arg2, boolean arg3, int arg4,int arg5) {
		// TODO Auto-generated method stub
		//on ecrit dans le bouton ce que contient la cellule
		setText((value!=null) ? value.toString() : "");
		return this;
	}

}
