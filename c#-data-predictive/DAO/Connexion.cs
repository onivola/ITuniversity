using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santepredect.DAO
{
    class Connexion
    {
        public static SqlConnection Connex() //constructeur
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = sentepredect; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("erreur de connexion :" + ex.StackTrace);
                //Log exception
                //Display Error message
                return null;
            }
          
        }
    }
}
