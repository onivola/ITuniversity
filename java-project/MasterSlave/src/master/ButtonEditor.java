package master;

import java.awt.Component;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.SQLException;
import java.util.Vector;

import javax.swing.DefaultCellEditor;
import javax.swing.JButton;
import javax.swing.JOptionPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;

import DAO.EmployerDAO;
import model.Employer;

public class ButtonEditor extends DefaultCellEditor {
	protected JButton btn;
	private String lbl;
	private Boolean clicked;
	private Employer emp;
	private JTable tab;
	
	public ButtonEditor(JTextField txt,JTable table) {
		super(txt);
		tab = table;
		//System.out.println(table.getValueAt(2,3));
		btn=new JButton();
		btn.setOpaque(true);
		btn.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				fireEditingStopped();
				
			}
		});
	}
	@Override
	public Component getTableCellEditorComponent(JTable table, Object obj, boolean isSelected, int row, int column) {
		// TODO Auto-generated method stub
		lbl=(obj==null) ? "":obj.toString(); //Condition ternaire si obj==null donc lbl = "" si non lbl = obj.toString()
		btn.setText(lbl);
		clicked=true;
		if(lbl=="MODIFIER") { //si on clique sur modifier
			emp = new Employer(); //Prendre les valeur et ajouter a emp
			emp.setId(Integer.parseInt((String)table.getValueAt(row, column-6)));
			emp.setNom((String) table.getValueAt(row, column-5));
			emp.setPrenom((String) table.getValueAt(row, column-4));
			emp.setDatenaissance((String) table.getValueAt(row, column-3));
			emp.setAdresse((String) table.getValueAt(row, column-2));
			System.out.println(emp.getId()+emp.getNom()+emp.getPrenom()+emp.getDatenaissance()+emp.getAdresse());
		} else if(lbl!="MODIFIER") { //si on clique sur suprimer
			emp = new Employer(); //Prendre les valeur et ajouter a emp
			emp.setId(Integer.parseInt((String)table.getValueAt(row, column-7)));
			emp.setNom((String) table.getValueAt(row, column-6));
			emp.setPrenom((String) table.getValueAt(row, column-5));
			emp.setDatenaissance((String) table.getValueAt(row, column-4));
			emp.setAdresse((String) table.getValueAt(row, column-3));
			System.out.println(emp.getId()+emp.getNom()+emp.getPrenom()+emp.getDatenaissance()+emp.getAdresse());
			
		}
		
		return btn;
	}
	public Object getCellEditorValue() {
		if(clicked)
		{
			//JOptionPane.showMessageDialog(btn, lbl+" Clicked");
		
			//effectuer l'update
			if(lbl=="MODIFIER") { //si on clique sur modifier
				try {
					EmployerDAO.update("slave1",emp);
					
					
				} catch (ClassNotFoundException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				Master.Fen.setModelTable();
			} else if(lbl!="MODIFIER") { //si on clique sur suprimer
				try {
					EmployerDAO.dellet("slave1",emp);
					
					// table.setModel((TableModel) EmployerDAO.GetRows("slave1"));
					//table.setModel(arg0);
				} catch (ClassNotFoundException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				Master.Fen.setModelTable();
			}
			
		}
		clicked=false;
		return new String(lbl);		
	}
	@Override
	public boolean stopCellEditing() {
		// TODO Auto-generated method stub
		clicked=false;
		return super.stopCellEditing();
	}
	@Override
	protected void fireEditingStopped() {
		// TODO Auto-generated method stub
		super.fireEditingStopped();
	}
	
}
