using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santepredect.DAO
{
    class MaladieDAO
    {
        public static SqlDataReader FindAll()
        {
            try
            {
                SqlConnection conn = Connexion.Connex();
                conn.Open();
                String sql = "SELECT * FROM maladie";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("erreur: " + ex.StackTrace);
                return null;
                //Log exception
                //Display Error message
            }
        }
        public static SqlDataReader FindWhereMoyenne(double valeur)
        {
            try
            {
                SqlConnection conn = Connexion.Connex();
                conn.Open();
                String svaleur = ""+valeur;
                svaleur = svaleur.Replace(",", ".");
                String sql = "SELECT * FROM maladie where moyenne!="+svaleur;
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("erreur: " + ex.StackTrace);
                return null;
                //Log exception
                //Display Error message
            }
        }
        public static SqlDataReader FindMaxid()
        {
            try
            {
                SqlConnection conn = Connexion.Connex();

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(Id_maladie) as max FROM maladie", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("erreur: " + ex.StackTrace);
                return null;
                //Log exception
                //Display Error message
            }
        }
        public static int Insert()
        {
            try
            {
                SqlConnection conn = Connexion.Connex();
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO maladie VALUES(" + "@Id_maladie, @maladie)", conn);
                SqlDataReader readermax = MaladieDAO.FindMaxid();
                int id = 0;
                if (readermax.HasRows)
                {
                    readermax.Read();

                    id = (int)readermax["max"];

                }
                id++;
                cmd.Parameters.AddWithValue("@Id_maladie", id);
                cmd.Parameters.AddWithValue("@maladie", "Maladie10");

                int rows = cmd.ExecuteNonQuery();

                //rows number of record got inserted
                conn.Close();
                return 1;

            }
            catch (SqlException ex)
            {
                Console.WriteLine("erreur: " + ex.StackTrace);
                return 0;
                //Log exception
                //Display Error message
            }
        }
        public static int Update()
        {
            try
            {
                SqlConnection conn = Connexion.Connex();
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE maladie SET maladie=@maladie" + " WHERE Id_maladie=@Id_maladie", conn);

                cmd.Parameters.AddWithValue("@Id_maladie", 10);
                cmd.Parameters.AddWithValue("@maladie", "Munna Hussain");

                int rows = cmd.ExecuteNonQuery();

                //rows number of record got updated

                conn.Close();
                return 1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("erreur: " + ex.StackTrace);
                return 0;
                //Log exception
                //Display Error message
            }
        }
        public static int Delete(int Id_maladie)
        {
            try
            {
                SqlConnection conn = Connexion.Connex();
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM maladie " + "WHERE Id_maladie=@Id_maladie", conn);

                cmd.Parameters.AddWithValue("@Id_maladie", Id_maladie);

                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                //rows number of record got deleted
                return 1;

            }
            catch (SqlException ex)
            {
                Console.WriteLine("erreur: " + ex.StackTrace);
                return 0;
                //Log exception
                //Display Error message
            }
        }
    }
}

