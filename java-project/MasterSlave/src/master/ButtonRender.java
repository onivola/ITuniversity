package master;

import java.awt.Component;

import javax.swing.JButton;
import javax.swing.JTable;
import javax.swing.table.TableCellRenderer;

public class ButtonRender extends JButton implements TableCellRenderer {

	@Override
	public Component getTableCellRendererComponent(JTable arg0, Object obj, boolean arg2, boolean arg3, int arg4,
			int arg5) {
		// TODO Auto-generated method stub
		setText((obj==null) ? "":obj.toString());
		return this;
	}

}
