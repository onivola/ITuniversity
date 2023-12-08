using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using santepredect.DAO;
namespace santepredect
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application9.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //Console.WriteLine("Connexion");
            //int insert =  MaladieDAO.Insert();
            // int update = MaladieDAO.Update();
            // int dellet = MaladieDAO.Delete(10);


            //Console.WriteLine(insert);
            SqlDataReader reader = MaladieDAO.FindAll();
           // Console.WriteLine("reader = " +reader);
             if (reader.HasRows)
             {
                 while (reader.Read())
                 {
                     Console.WriteLine("Id_maladie = "+ reader["Id_maladie"]);
                     Console.WriteLine("maladie = "+ reader["maladie"]);
                 }
             }
     
            /** double moyenne = 0;
             try
             {
                 SqlConnection conn = Connexion.Connex();
                 conn.Open();
                 SqlCommand cmd = new SqlCommand("SELECT * FROM valeur order by id_valeur, group by id_valeur", conn);
                 SqlDataReader reader = cmd.ExecuteReader();

                 if (reader.HasRows)
                 {
                     while (reader.Read())
                     {
                         Console.WriteLine("id_valeur = " + reader["id_maladie"]);
                         Console.WriteLine("id_valeur = " + reader["id_valeur"]);
                     }
                 }

             }**/


            /**catch (SqlException ex)
            {
                Console.WriteLine("erreur: " + ex.StackTrace);
               
                //Log exception
                //Display Error message
            }**/
            double[] tb = new double[5];
            tb[0] = 2;
            tb[1] = 3;
            tb[2] = 1;
            tb[3] = 5;
            tb[4] = 4;
            double[] tbtest = tb;
            double[] tbdecr = new double[5];
            int indtbdecr = 0;
            int tblength = tbtest.Length;
            for (int k = 0; k < tbtest.Length; k++)
            {
                for (int i = 0; i < tbtest.Length; i++)
                {

                    double test = tbtest[i];
                    int nbsup = 0;
                    for (int j = 0; j < tbtest.Length; j++)
                    {
                        if (tbtest[j] < test)
                        {
                            nbsup++;
                        }
                    }
                    if (nbsup == 4)
                    {
                        tbtest[i] = 0;
                        tbdecr[indtbdecr] = test;
                        indtbdecr++;
                        // Console.WriteLine(test);
                    }
                }
            }
            for (int j = 0; j < tbtest.Length; j++)
            {
                //Console.WriteLine(tbdecr[j]);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //1293; 862


        }
    }
}
