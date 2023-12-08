/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author Clogène
 */
public class Basemodele {
    protected int id=0;
    protected String table;
        public Basemodele(){
            
        }
                
    public Basemodele(int id, String table) {
        this.id = id;
        this.table = table;
    }
   

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTable() {
        return table;
    }

    public void setTable(String table) {
        this.table = table;
    }
    
    
    
    
}
