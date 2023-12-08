namespace santepredect
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LabelMaladie1 = new System.Windows.Forms.Label();
            this.LabelMaladie2 = new System.Windows.Forms.Label();
            this.LabelMaladie3 = new System.Windows.Forms.Label();
            this.LabelCentMaladie1 = new System.Windows.Forms.Label();
            this.LabelCentMaladie2 = new System.Windows.Forms.Label();
            this.LabelCentMaladie3 = new System.Windows.Forms.Label();
            this.LabelNom = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panelresultat = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartgraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Panelresultat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartgraph)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMaladie1
            // 
            this.LabelMaladie1.AutoSize = true;
            this.LabelMaladie1.Location = new System.Drawing.Point(88, 115);
            this.LabelMaladie1.Name = "LabelMaladie1";
            this.LabelMaladie1.Size = new System.Drawing.Size(50, 13);
            this.LabelMaladie1.TabIndex = 0;
            this.LabelMaladie1.Text = "Maladie1";
            this.LabelMaladie1.Click += new System.EventHandler(this.LabelMaladie1_Click);
            // 
            // LabelMaladie2
            // 
            this.LabelMaladie2.AutoSize = true;
            this.LabelMaladie2.Location = new System.Drawing.Point(91, 169);
            this.LabelMaladie2.Name = "LabelMaladie2";
            this.LabelMaladie2.Size = new System.Drawing.Size(50, 13);
            this.LabelMaladie2.TabIndex = 1;
            this.LabelMaladie2.Text = "Maladie2";
            this.LabelMaladie2.Click += new System.EventHandler(this.LabelMaladie2_Click);
            // 
            // LabelMaladie3
            // 
            this.LabelMaladie3.AutoSize = true;
            this.LabelMaladie3.Location = new System.Drawing.Point(91, 220);
            this.LabelMaladie3.Name = "LabelMaladie3";
            this.LabelMaladie3.Size = new System.Drawing.Size(50, 13);
            this.LabelMaladie3.TabIndex = 2;
            this.LabelMaladie3.Text = "Maladie3";
            // 
            // LabelCentMaladie1
            // 
            this.LabelCentMaladie1.AutoSize = true;
            this.LabelCentMaladie1.Location = new System.Drawing.Point(181, 115);
            this.LabelCentMaladie1.Name = "LabelCentMaladie1";
            this.LabelCentMaladie1.Size = new System.Drawing.Size(27, 13);
            this.LabelCentMaladie1.TabIndex = 3;
            this.LabelCentMaladie1.Text = "15%";
            this.LabelCentMaladie1.Click += new System.EventHandler(this.LabelCentMaladie1_Click);
            // 
            // LabelCentMaladie2
            // 
            this.LabelCentMaladie2.AutoSize = true;
            this.LabelCentMaladie2.Location = new System.Drawing.Point(181, 169);
            this.LabelCentMaladie2.Name = "LabelCentMaladie2";
            this.LabelCentMaladie2.Size = new System.Drawing.Size(27, 13);
            this.LabelCentMaladie2.TabIndex = 4;
            this.LabelCentMaladie2.Text = "15%";
            // 
            // LabelCentMaladie3
            // 
            this.LabelCentMaladie3.AutoSize = true;
            this.LabelCentMaladie3.Location = new System.Drawing.Point(181, 220);
            this.LabelCentMaladie3.Name = "LabelCentMaladie3";
            this.LabelCentMaladie3.Size = new System.Drawing.Size(27, 13);
            this.LabelCentMaladie3.TabIndex = 5;
            this.LabelCentMaladie3.Text = "15%";
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(85, 86);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(29, 13);
            this.LabelNom.TabIndex = 6;
            this.LabelNom.Text = "Nom";
            this.LabelNom.Click += new System.EventHandler(this.LabelNom_Click);
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(88, 140);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(26, 13);
            this.LabelAge.TabIndex = 7;
            this.LabelAge.Text = "Age";
            this.LabelAge.Click += new System.EventHandler(this.LabelAge_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maladie3";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "15%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "15%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "15%";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Panelresultat
            // 
            this.Panelresultat.BackColor = System.Drawing.Color.White;
            this.Panelresultat.Controls.Add(this.button2);
            this.Panelresultat.Controls.Add(this.label5);
            this.Panelresultat.Controls.Add(this.button1);
            this.Panelresultat.Controls.Add(this.label1);
            this.Panelresultat.Controls.Add(this.label4);
            this.Panelresultat.Controls.Add(this.LabelAge);
            this.Panelresultat.Controls.Add(this.LabelNom);
            this.Panelresultat.Controls.Add(this.label2);
            this.Panelresultat.Controls.Add(this.label3);
            this.Panelresultat.Location = new System.Drawing.Point(1080, 12);
            this.Panelresultat.Name = "Panelresultat";
            this.Panelresultat.Size = new System.Drawing.Size(383, 404);
            this.Panelresultat.TabIndex = 1;
            this.Panelresultat.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelresultat_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "ENREGISTRER";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "drag";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LabelMaladie2);
            this.panel2.Controls.Add(this.LabelCentMaladie3);
            this.panel2.Controls.Add(this.LabelCentMaladie2);
            this.panel2.Controls.Add(this.LabelMaladie1);
            this.panel2.Controls.Add(this.LabelCentMaladie1);
            this.panel2.Controls.Add(this.LabelMaladie3);
            this.panel2.Location = new System.Drawing.Point(1080, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 378);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chartgraph);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 900);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chartgraph
            // 
            chartArea1.Name = "ChartArea1";
            this.chartgraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartgraph.Legends.Add(legend1);
            this.chartgraph.Location = new System.Drawing.Point(0, 0);
            this.chartgraph.Name = "chartgraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Legend = "Legend1";
            series1.Name = "Maladie";
            series1.XValueMember = "12";
            series1.YValueMembers = "12";
            this.chartgraph.Series.Add(series1);
            this.chartgraph.Size = new System.Drawing.Size(1050, 900);
            this.chartgraph.TabIndex = 0;
            this.chartgraph.Text = "chart1";
            title1.Name = "Maladie";
            title1.Text = "Maladie chart";
            this.chartgraph.Titles.Add(title1);
            this.chartgraph.Click += new System.EventHandler(this.chart1_Click_1);
            this.chartgraph.DragDrop += new System.Windows.Forms.DragEventHandler(this.chartgraph_DragDrop);
            this.chartgraph.DragEnter += new System.Windows.Forms.DragEventHandler(this.chartgraph_DragEnter);
            this.chartgraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartgraph_MouseClick);
            this.chartgraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartgraph_MouseDown);
            this.chartgraph.MouseHover += new System.EventHandler(this.chartgraph_MouseHover);
            this.chartgraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartgraph_MouseMove);
            this.chartgraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chartgraph_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panelresultat);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panelresultat.ResumeLayout(false);
            this.Panelresultat.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartgraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelMaladie1;
        private System.Windows.Forms.Label LabelMaladie2;
        private System.Windows.Forms.Label LabelMaladie3;
        private System.Windows.Forms.Label LabelCentMaladie1;
        private System.Windows.Forms.Label LabelCentMaladie2;
        private System.Windows.Forms.Label LabelCentMaladie3;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panelresultat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartgraph;
        private System.Windows.Forms.Button button2;
    }
}

