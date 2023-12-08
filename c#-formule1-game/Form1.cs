using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formule1
{
    public partial class Form1 : Form
    {
        double t;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

            Thread threadtemps = new Thread(new ThreadStart(temps));
         //   Thread threadtour = new Thread(new ThreadStart(tour));
           // Thread threadposition = new Thread(new ThreadStart(position));

           // Thread threadpicture2 = new Thread(new ParameterizedThreadStart(demmarer));
           // Thread threadpicture3 = new Thread(new ParameterizedThreadStart(demmarer));
           // Thread threadpicture4 = new Thread(new ParameterizedThreadStart(demmarer));
           // Thread threadpicture5 = new Thread(new ParameterizedThreadStart(demmarer));
           // Thread threadpicture6 = new Thread(new ParameterizedThreadStart(demmarer));
            //EQUIPE

          //  threadpicture2.Start(equipe1);
          //  threadpicture3.Start(equipe2);
          //  threadpicture4.Start(equipe3);
          //  threadpicture5.Start(equipe4);
          //  threadpicture6.Start(equipe5);

           // threadtour.Start();
           // threadposition.Start();
            threadtemps.Start();


        }
        private void temps()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            double Minute = 0;
            double Chrono = 0;
            String concat = ".";
            while (true)
            {

                Thread.Sleep(1);
                // stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                string elapsedTimetwo = String.Format("{0:00}", ts.Milliseconds / 10);
                // Console.WriteLine("Runtime " + elapsedTime);
                /// Console.WriteLine("elapsedTimetwo " + elapsedTimetwo);

                Minute = ts.Minutes * 60 + ts.Seconds;

                //if (ts.Milliseconds < 100) { concat = ".0"; }
                Chrono = double.Parse(Minute + concat + elapsedTimetwo, System.Globalization.CultureInfo.InvariantCulture);
                //Console.WriteLine("ts.Milliseconds " + ts.Milliseconds);
                // Console.WriteLine("Chrono " + Chrono);
                this.t = Chrono;
                Console.WriteLine(this.t);
                //  if (this.t == 0) { this.t = 0.5; }
            }


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Create four Pen objects with red,
           
            Pen Pendepar = new Pen(Color.Black, 1);
            Pen Pen1 = new Pen(Color.Black, 1);
            Pen Pen2 = new Pen(Color.Black, 1);
            Pen Pen3 = new Pen(Color.Black, 1);
            Pen Pen4 = new Pen(Color.Black, 1);

            e.Graphics.DrawLine(Pendepar, 400, 500, 400, 550);

            e.Graphics.DrawLine(Pen1, 200, 500, 600, 500);


            e.Graphics.DrawLine(Pen2, 600, 500, 600, 100);

            e.Graphics.DrawLine(Pen3, 200, 100, 600, 100);

            e.Graphics.DrawLine(Pen4, 200, 100, 200, 500);
            
            Pen1.Dispose();
            Pen2.Dispose();
            Pen3.Dispose();
            Pen4.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
