using santepredect.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace santepredect
{
    public partial class Form1 : Form
    {
        private Boolean booleanmousemove = false;
        //CENTRE DU CHART Cx Cy e.X = 464 e.Y = 464
        private int Cx = 464;
        private int Cy = 464;
        public Form1()
        {
            InitializeComponent();
        }

       


        private void Form1_Paint(object sender,PaintEventArgs e)
        {
            // Declares the Graphics object and sets it to the Graphics object  
            // supplied in the PaintEventArgs.  

            // Insert code to paint the form here.  
            Pen red = new Pen(Color.Red);
            Pen green = new Pen(Color.Green);

            // to fill shape
            System.Drawing.SolidBrush fillRed = new System.Drawing.SolidBrush(Color.Red);
            System.Drawing.SolidBrush fillYellow = new System.Drawing.SolidBrush(Color.Yellow);

            //to fill Shape
            Rectangle rect = new Rectangle(0, 0, 220, 90);
            Rectangle circle = new Rectangle(20, 20, 220, 9);
        }
        private void LabelNom_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LabelAge_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LabelMaladie1_Click(object sender, EventArgs e)
        {

        }

        private void LabelCentMaladie1_Click(object sender, EventArgs e)
        {

        }

        private void LabelMaladie2_Click(object sender, EventArgs e)
        {

        }

        private void Panelresultat_Paint(object sender, PaintEventArgs e)
        {
           
        }
        //850; 700
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs es)
        {
            chartgraph.Series["Maladie"].Points.AddXY("element1", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element2", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element3", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element4", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element5", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element6", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element7", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element8", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element9", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element10", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element11", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element12", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element13", 1000);
            chartgraph.Series["Maladie"].Points.AddXY("element14", 1000);

         /**   double CstX = (double)chartgraph.Width / 58; //constente % Width X pour trouver le centre de Chart
            double CstY = (double)chartgraph.Height / 12; //constente % Width X pour trouver le centre de Chart
            int Cx = (int)((chartgraph.Width / 2) - (chartgraph.Width / CstX));
            int Cy = (int)((chartgraph.Height / 2) + (chartgraph.Height / CstY));


            Console.WriteLine("Cx=" + Cx + "Cy=" + Cy + "CstX =" + CstX + "CstY=" + CstY);


            //CALCULE DE DISTANCE Dcs CS CENTRE CHART ET SOURI
            double Dcs = 0;
            int Sx = e.X;
            int Sy = e.Y;
            Dcs = Math.Sqrt((Sx - Cx) * (Sx - Cx) + (Cy - Sy) * (Cy - Sy)); //DISTANCE CENTRE SOURIS PIXEL
            Console.WriteLine("Sx=" + Sx + "Sy=" + Sy + "Dcs =" + Dcs);

            ///CHAQUE ELEMENT A SON ENSEMBLE DE POINT EN FORME DE TRIANGLE DU CENTRE AU SOMMET
            int[] E0Xpoints = new int[257];
            int[] E0Ypoints = new int[257];
            E0Xpoints[0] = Cx;
            E0Ypoints[0] = Cy;
            E0Xpoints[256] = Cx;
            E0Ypoints[256] = 105;**/
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //textBox1.Text =label5.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {

         
        }
      
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
             
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
         
        }
        private void chartgraph_MouseHover(object sender, EventArgs e)
        {

        }
       
     

        private void chartgraph_MouseClick(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("e.X = "+e.X+"e.Y ="+e.Y);
        }

        private void chartgraph_MouseDown(object sender, MouseEventArgs e)
        {
            booleanmousemove = true;
        }
      

        private void chartgraph_MouseUp(object sender, MouseEventArgs e)
        {
            booleanmousemove = false;
        }

        private void chartgraph_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void chartgraph_DragDrop(object sender, DragEventArgs e)
        {
          
        }

        private void chartgraph_MouseMove(object sender, MouseEventArgs e)
        {

            double CyMeY=0;
            double eXMCx=0;
            double AngleDegree = 0;
            if (e.X-Cx!=0)
            {
                //tan d'un point e.X et e.Y
                CyMeY = Cy - e.Y;//cote opposee
                eXMCx = e.X - Cx;//cote adjacent
                double AngleRad = Math.Atan((double)(CyMeY) / (eXMCx));

                AngleDegree = AngleRad * (180.0/Math.PI);

              
               // Console.WriteLine("e.X =" + e.X + " Cx = " + Cx + "e.Y = " + e.Y +"Cy = "+Cy);
                //Console.WriteLine("Cy - e.Y = " + (CyMeY) + "e.X - Cx =" + (eXMCx));
               // Console.WriteLine("CyMeY = " + (CyMeY) + " eXMCx =" + (eXMCx));
                //Console.WriteLine("AngleRad =" + AngleRad + "AngleDegree = "+ AngleDegree);

            }

            if (booleanmousemove)
            {

                //CALCULE DE DISTANCE Dcs CS CENTRE CHART ET SOURI
                double Dcs = 0;
                int Sx = e.X;
                int Sy = e.Y;
                Dcs = Math.Sqrt((Sx - Cx) * (Sx - Cx) + (Cy - Sy) * (Cy - Sy)); //DISTANCE CENTRE SOURIS PIXEL

                //LONGUEUR EN PIXEL DU CENTRE AU POINT
                int Ey = 117;
                int Ex = Cx;

                //DISTANCE CENTRE POINTS PIXEL
                double Dce = Math.Sqrt((Ex - Cx) * (Ex - Cx) + (Cy - Ey) * (Cy - Ey));

                //CONVERTIR Dcs EN VALEUR CHART
                double Value = Dcs * (1200 / Dce);//ECHELLE

                //CHANGER VALEUR ELEMENT 3
                double[] element = new double[1];
                element[0] = Value;

                // LabelCentMaladie1.Text = Value;
                //Repere pour chaque element
                if ((CyMeY > 0 && eXMCx > 0) || (CyMeY < 0 && eXMCx > 0))//element 2 - 7
                {

                    if (AngleDegree > 75.96)//element 1
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(0).YValues = element;
                    }
                    if (AngleDegree < 75.96 && AngleDegree > 52.69)//element 2
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(1).YValues = element;
                    }
                    if (AngleDegree < 52.69 && AngleDegree > 24.77)//element 3
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(2).YValues = element;
                    }
                    if (AngleDegree < 24.77 && AngleDegree > 0)//element 4
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(3).YValues = element;
                    }
                    if (AngleDegree < 0 && AngleDegree > -25.38)//element 5
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(4).YValues = element;
                    }
                    if (AngleDegree < -25.38 && AngleDegree > -51.64)//element 6
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(5).YValues = element;
                    }
                    if (AngleDegree < -51.64 && AngleDegree > -77.07)//element 7
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(6).YValues = element;
                    }
                    if (AngleDegree < -77.07)//element 8
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(7).YValues = element;
                    }

                }
                if ((CyMeY > 0 && eXMCx < 0) || (CyMeY < 0 && eXMCx < 0))//element 9 - 14
                {
                    if (AngleDegree > 76.20)//element 9
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(7).YValues = element;
                    }
                    if (AngleDegree < 76.20 && AngleDegree > 51.41)//element 9
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(8).YValues = element;
                    }
                    if (AngleDegree < 51.41 && AngleDegree > 25.75)//element 10
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(9).YValues = element;
                    }
                    if (AngleDegree < 25.75 && AngleDegree > 0.98)//element 11
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(10).YValues = element;
                    }
                    if (AngleDegree < 0.98 && AngleDegree > -25.38)//element 12
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(11).YValues = element;
                    }
                    if (AngleDegree < -28.38 && AngleDegree > -51.31)//element 13
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(12).YValues = element;
                    }
                    if (AngleDegree < -51.31 && AngleDegree > -76.84)//element 14
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(13).YValues = element;
                    }
                    if (AngleDegree < -76.84)//element 14
                    {
                        chartgraph.Series["Maladie"].Points.ElementAt(0).YValues = element;
                    }
                }
                
                ///calcul moyenne element
                double E1 = chartgraph.Series["Maladie"].Points.ElementAt(0).YValues[0];
                double E2 = chartgraph.Series["Maladie"].Points.ElementAt(1).YValues[0];
                double E3 = chartgraph.Series["Maladie"].Points.ElementAt(2).YValues[0];
                double E4 = chartgraph.Series["Maladie"].Points.ElementAt(3).YValues[0];
                double E5 = chartgraph.Series["Maladie"].Points.ElementAt(4).YValues[0];
                double E6 = chartgraph.Series["Maladie"].Points.ElementAt(5).YValues[0];
                double E7 = chartgraph.Series["Maladie"].Points.ElementAt(6).YValues[0];
                double E8 = chartgraph.Series["Maladie"].Points.ElementAt(7).YValues[0];
                double E9 = chartgraph.Series["Maladie"].Points.ElementAt(8).YValues[0];
                double E10 = chartgraph.Series["Maladie"].Points.ElementAt(9).YValues[0];
                double E11 = chartgraph.Series["Maladie"].Points.ElementAt(10).YValues[0];
                double E12 = chartgraph.Series["Maladie"].Points.ElementAt(11).YValues[0];
                double E13 = chartgraph.Series["Maladie"].Points.ElementAt(12).YValues[0];
                double E14 = chartgraph.Series["Maladie"].Points.ElementAt(13).YValues[0];
                double moyenne = (E1 + E2 + E3 + E4 + E5 + E6 + E7 + E8 + E9 + E10 + E11 + E12 + E13 + E14) / 14;
               // Console.WriteLine("MOYENNE = "+moyenne);


                SqlDataReader reader = MaladieDAO.FindAll();
                double m1, m2, m3, m4, m5;
                String[] tbm = new string[5];
                double[] tbprc = new double[5];
                reader.Read();
                m1 = (double)reader["moyenne"];
                //Console.WriteLine("moyenne maladie 1 = " + m1);
                double m1prc = (100 * moyenne)/m1;
                tbprc[0] = m1prc;
                tbm[0]= (String)reader["maladie"];
                reader.Read();
                m2 = (double)reader["moyenne"];
                
                double m2prc = (100 * moyenne) / m2;
                tbprc[1] = m2prc;
                tbm[1] = (String)reader["maladie"];
                reader.Read();
                m3 = (double)reader["moyenne"];
                double m3prc = (100 * moyenne) / m3;
                tbprc[2] = m3prc;
                tbm[2] = (String)reader["maladie"];
                reader.Read();
                m4 = (double)reader["moyenne"];
                double m4prc = (100 * moyenne) / m4;
                tbprc[3] = m4prc;
                tbm[3] = (String)reader["maladie"];
                reader.Read();
                m5 = (double)reader["moyenne"];
                double m5prc = (100 * moyenne) / m5;
                tbprc[4] = m5prc;
                tbm[4] = (String)reader["maladie"];

                /**  Console.WriteLine("m1 = " + m1prc);
                  Console.WriteLine("m2 = " + m2prc);
                  Console.WriteLine("m3 = " + m3prc);
                  Console.WriteLine("m4 = " + m4prc);
                  Console.WriteLine("m5 = " + m5prc);**/
                //POURCENTAGE DECROICENT//
                double[] tb = tbprc;
                double[] tbtest = tb;
                double[] tbdecr = new double[5];
                String[] tbmdecr = new String[5];
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
                            tbmdecr[indtbdecr] = tbm[i];
                           indtbdecr++;
                            // Console.WriteLine(test);
                        }
                    }
                }
                Console.WriteLine("pourcentage decroicent");
               
                    
                    LabelCentMaladie1.Text = ""+tbdecr[0];
                LabelMaladie1.Text = tbmdecr[0];
                    LabelCentMaladie2.Text = ""+tbdecr[1];
                LabelMaladie2.Text = tbmdecr[1];
                LabelCentMaladie3.Text = ""+tbdecr[2];
                LabelMaladie3.Text = tbmdecr[2];

                //POURCENTAGE DECROICENT//


            }
        }

        private string ToString(int v)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

