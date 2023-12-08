/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Vector;

import com.mysql.jdbc.ResultSetMetaData;

import model.Employer;

/**
 *
 * @author Clogène
 */
public class EmployerDAO {
    public static ResultSet findAll(String bdd) throws SQLException, ClassNotFoundException { //Find recherche
        Connection cn = Connexion.Connection(bdd);
        Statement st = cn.createStatement();
        ResultSet rs = st.executeQuery("SELECT * FROM employer");
        return rs;
    }
    public static int insert(String bdd,Employer emp) throws SQLException, ClassNotFoundException {
         Connection cn = Connexion.Connection(bdd);
            ResultSet rs = null;
            Statement st = null;
            st = (Statement)cn.createStatement();
          if(!emp.getNom().equals("") && !emp.getPrenom().equals("")  && !emp.getAdresse().equals("") && !emp.getDatenaissance().equals("")) { //si les champ ne sont pas vide
            st.executeUpdate("INSERT INTO employer VALUES ('0','"+emp.getNom()+"','"+emp.getPrenom()+"','"+emp.getDatenaissance()+"','"+emp.getAdresse()+"',"+emp.Getcurrentdatetime()+")");
            cn.close();
             
            return 1;
          }
          return 0;
    }
   
    public static void dellet(String bdd,Employer emp) throws SQLException, ClassNotFoundException {
        Connection cn = Connexion.Connection(bdd);
           ResultSet rs = null;
           Statement st = null;
           st = (Statement)cn.createStatement();
         if(!emp.getNom().equals("") && !emp.getPrenom().equals("")  && !emp.getDatenaissance().equals("")  && !emp.getAdresse().equals("")) {
           PreparedStatement preparedStmt = cn.prepareStatement("delete from employer where NOM = ? AND PRENOM = ?");
           preparedStmt.setString(1,emp.getNom());
           preparedStmt.setString(2,emp.getPrenom());
           preparedStmt.execute();
           cn.close();
         }     
   }
    public static int update(String bdd,Employer emp) throws SQLException, ClassNotFoundException {
        String update = ""; /// "NOM = ?, PREMON = ? , DATE_NAISSANCE = ? ..."
        Connection cn = Connexion.Connection(bdd);
        
        if(!emp.getNom().equals("")) {
            update="NOM = ?";
        }
        if(!emp.getPrenom().equals("")) {
             if(!update.equals("")) {// update != empty
                update = update+" , PRENOM = ?";
            }
            if(update.equals("")) {// update = empty
                update ="PRENOM=?";
            }
        }
          if(!emp.getDatenaissance().equals("")) {
             if(!update.equals("")) {// update != empty
                update = update+" , DATE_NAISSANCE = ?";
            }
            if(update.equals("")) {// update = empty
                update ="DATE_NAISSANCE=?";
            }
        }
            if(!emp.getAdresse().equals("")) {
             if(!update.equals("")) {// update != empty
                update = update+" , ADRESSE = ?";
            }
            if(update.equals("")) {// update = empty
                update ="ADRESSE=?";
            }
        }
           
        if(!update.equals("")  && (emp.getId()!=0)) { //si update n'est pas vide
            try
            {
              // create our java preparedstatement using a sql update query
              PreparedStatement ps = cn.prepareStatement("UPDATE EMPLOYER SET "+update+" Where ID_EMPLOYER = ?");

              // set the preparedstatement parameters
                int i = 0;
             
              if(!emp.getNom().equals("")) {
                  i++;
                   ps.setString(i,emp.getNom());  
                   
                }
                if(!emp.getPrenom().equals("")) {
                    i++;
                    ps.setString(i,emp.getPrenom()); 
               }
               if(!emp.getDatenaissance().equals("")) {
                    i++;
                    ps.setString(i,emp.getDatenaissance()); 
               }
                 if(!emp.getAdresse().equals("")) {
                    i++;
                    ps.setString(i,emp.getAdresse()); 
               }
                i++;
                   ps.setInt(i,emp.getId());
              // call executeUpdate to execute our sql update statement
              ps.executeUpdate();
              ps.close();
            }
            catch (SQLException se)
            {
            // log the exception
            throw se;
            }
          return 1;
        } else {
        return  0;
        }
    }
    
    
    public static Vector GetColumn(String bdd) throws SQLException, ClassNotFoundException {
    	 ResultSet rs = EmployerDAO.findAll(bdd);
    	ResultSetMetaData rsmt = (ResultSetMetaData) rs.getMetaData();
    	int c = rsmt.getColumnCount();
		Vector column = new Vector(c);
		for(int i=1;i<=c;i++) {
			column.add(rsmt.getColumnName(i));
			
		}
		column.add("MODIFIER");
		column.add("SUPRIMER");
    	return column;
    }
    public static Vector GetRows(String bdd) throws SQLException, ClassNotFoundException {
   	 ResultSet rs = EmployerDAO.findAll(bdd);
   	ResultSetMetaData rsmt = (ResultSetMetaData) rs.getMetaData();
	int c = rsmt.getColumnCount();
   	Vector data = new Vector();
   	Vector row = new Vector();
   	while(rs.next()) {
   		row = new Vector(c);
   		for(int i=1;i<=c;i++) {
			row.add(rs.getString(i));
			
		}
   		row.add("MODIFIER");
   		row.add("SUPRIMER");
   		data.add(row);
   	}
   	return data;
   }
}
