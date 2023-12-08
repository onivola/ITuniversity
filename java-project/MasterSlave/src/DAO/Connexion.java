/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAO;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import static sun.security.jgss.GSSUtil.login;

/**
 *
 * @author Clogène
 */
public class Connexion {
    private static String url =  "jdbc:mysql://localhost/";
    private static String login = "root";
    private static String passwd = "root";
    private static Connection cn =null;
    
    public static Connection Connection(String bdd) throws SQLException, ClassNotFoundException {
        Class.forName("com.mysql.jdbc.Driver");
        cn = DriverManager.getConnection(url+bdd,login,passwd);
        return cn;
    }
  

            
}
