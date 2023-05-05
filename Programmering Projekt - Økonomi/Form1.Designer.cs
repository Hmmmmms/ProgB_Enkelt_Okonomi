namespace Programmering_Projekt___Økonomi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.IndLønTextBox = new System.Windows.Forms.TextBox();
            this.UGHuslejeTextBox = new System.Windows.Forms.TextBox();
            this.opsparingTextBox = new System.Windows.Forms.TextBox();
            this.Beregn_btn = new System.Windows.Forms.Button();
            this.VisGraf_btn = new System.Windows.Forms.Button();
            this.overskudLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IndAndetTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Indkomstlbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UGMadTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UGTransportTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.UGØvrigeTextBox = new System.Windows.Forms.TextBox();
            this.UGUdgifterlbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // IndLønTextBox
            // 
            this.IndLønTextBox.AcceptsTab = true;
            this.IndLønTextBox.Location = new System.Drawing.Point(65, 60);
            this.IndLønTextBox.Name = "IndLønTextBox";
            this.IndLønTextBox.Size = new System.Drawing.Size(100, 22);
            this.IndLønTextBox.TabIndex = 0;
            this.IndLønTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IndLønTextBox_KeyPress);
            // 
            // UGHuslejeTextBox
            // 
            this.UGHuslejeTextBox.Location = new System.Drawing.Point(65, 224);
            this.UGHuslejeTextBox.Name = "UGHuslejeTextBox";
            this.UGHuslejeTextBox.Size = new System.Drawing.Size(100, 22);
            this.UGHuslejeTextBox.TabIndex = 2;
            this.UGHuslejeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UGHuslejeTextBox_KeyPress);
            // 
            // opsparingTextBox
            // 
            this.opsparingTextBox.Location = new System.Drawing.Point(235, 56);
            this.opsparingTextBox.Name = "opsparingTextBox";
            this.opsparingTextBox.Size = new System.Drawing.Size(100, 22);
            this.opsparingTextBox.TabIndex = 6;
            this.opsparingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opsparingTextBox_KeyPress);
            // 
            // Beregn_btn
            // 
            this.Beregn_btn.Location = new System.Drawing.Point(235, 202);
            this.Beregn_btn.Name = "Beregn_btn";
            this.Beregn_btn.Size = new System.Drawing.Size(100, 44);
            this.Beregn_btn.TabIndex = 7;
            this.Beregn_btn.Text = "Beregn balance";
            this.Beregn_btn.UseVisualStyleBackColor = true;
            this.Beregn_btn.Click += new System.EventHandler(this.Beregn_btn_Click);
            // 
            // VisGraf_btn
            // 
            this.VisGraf_btn.Location = new System.Drawing.Point(235, 253);
            this.VisGraf_btn.Name = "VisGraf_btn";
            this.VisGraf_btn.Size = new System.Drawing.Size(100, 39);
            this.VisGraf_btn.TabIndex = 8;
            this.VisGraf_btn.Text = "Visualiser";
            this.VisGraf_btn.UseVisualStyleBackColor = true;
            this.VisGraf_btn.Click += new System.EventHandler(this.VisGraf_btn_Click);
            // 
            // overskudLabel
            // 
            this.overskudLabel.AutoSize = true;
            this.overskudLabel.Location = new System.Drawing.Point(232, 114);
            this.overskudLabel.Name = "overskudLabel";
            this.overskudLabel.Size = new System.Drawing.Size(45, 16);
            this.overskudLabel.TabIndex = 10;
            this.overskudLabel.Text = "0.00 kr";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(499, 41);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(615, 332);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Indkomst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Husleje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opsparing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Løn (Netto)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Andet";
            // 
            // IndAndetTextbox
            // 
            this.IndAndetTextbox.Location = new System.Drawing.Point(65, 111);
            this.IndAndetTextbox.Name = "IndAndetTextbox";
            this.IndAndetTextbox.Size = new System.Drawing.Size(100, 22);
            this.IndAndetTextbox.TabIndex = 1;
            this.IndAndetTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IndAndetTextbox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Udgifter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Månedlige indkomst:";
            // 
            // Indkomstlbl
            // 
            this.Indkomstlbl.AutoSize = true;
            this.Indkomstlbl.Location = new System.Drawing.Point(62, 161);
            this.Indkomstlbl.Name = "Indkomstlbl";
            this.Indkomstlbl.Size = new System.Drawing.Size(45, 16);
            this.Indkomstlbl.TabIndex = 15;
            this.Indkomstlbl.Text = "0.00 kr";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mad";
            // 
            // UGMadTextBox
            // 
            this.UGMadTextBox.Location = new System.Drawing.Point(65, 273);
            this.UGMadTextBox.Name = "UGMadTextBox";
            this.UGMadTextBox.Size = new System.Drawing.Size(100, 22);
            this.UGMadTextBox.TabIndex = 3;
            this.UGMadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UGMadTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Transport";
            // 
            // UGTransportTextBox
            // 
            this.UGTransportTextBox.Location = new System.Drawing.Point(65, 321);
            this.UGTransportTextBox.Name = "UGTransportTextBox";
            this.UGTransportTextBox.Size = new System.Drawing.Size(100, 22);
            this.UGTransportTextBox.TabIndex = 4;
            this.UGTransportTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UGTransportTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(231, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "Opsparing";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Øvrige faste";
            // 
            // UGØvrigeTextBox
            // 
            this.UGØvrigeTextBox.Location = new System.Drawing.Point(65, 374);
            this.UGØvrigeTextBox.Name = "UGØvrigeTextBox";
            this.UGØvrigeTextBox.Size = new System.Drawing.Size(100, 22);
            this.UGØvrigeTextBox.TabIndex = 5;
            this.UGØvrigeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UGØvrigeTextBox_KeyPress);
            // 
            // UGUdgifterlbl
            // 
            this.UGUdgifterlbl.AutoSize = true;
            this.UGUdgifterlbl.Location = new System.Drawing.Point(62, 436);
            this.UGUdgifterlbl.Name = "UGUdgifterlbl";
            this.UGUdgifterlbl.Size = new System.Drawing.Size(45, 16);
            this.UGUdgifterlbl.TabIndex = 29;
            this.UGUdgifterlbl.Text = "0.00 kr";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 411);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Månedlige udgifter:";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(499, 380);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(615, 379);
            this.chart2.TabIndex = 30;
            this.chart2.Text = "chart2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Overskud:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 814);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.UGUdgifterlbl);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.UGØvrigeTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UGTransportTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UGMadTextBox);
            this.Controls.Add(this.Indkomstlbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IndAndetTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.overskudLabel);
            this.Controls.Add(this.VisGraf_btn);
            this.Controls.Add(this.Beregn_btn);
            this.Controls.Add(this.opsparingTextBox);
            this.Controls.Add(this.UGHuslejeTextBox);
            this.Controls.Add(this.IndLønTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IndLønTextBox;
        private System.Windows.Forms.TextBox UGHuslejeTextBox;
        private System.Windows.Forms.TextBox opsparingTextBox;
        private System.Windows.Forms.Button Beregn_btn;
        private System.Windows.Forms.Button VisGraf_btn;
        private System.Windows.Forms.Label overskudLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IndAndetTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Indkomstlbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UGMadTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UGTransportTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox UGØvrigeTextBox;
        private System.Windows.Forms.Label UGUdgifterlbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label8;
    }
}

