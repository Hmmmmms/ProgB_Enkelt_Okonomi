using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Programmering_Projekt___Økonomi
{
    public partial class Form1 : Form
    {
        //Her oprettes de variabler der bliver brugt i programmet
        double indkomst;
        double udgifter;
        double husleje;
        double mad;
        double transport;
        double ovrigeUdgifter;

        double opsparing;
        double aktuelOpsparing;

        double overskud;

        double[] balanceArray = new double[12];

        //Her oprettes en metode, der beregner opsparingens værdi for hver måned i de næste 12 måneder.
        //Vi kan beregne opsparingen ved at tage den aktuelle opsparingsværdi og tilføje den månedlige opsparingsmængde, multiplikeret med antallet af måneder.
        private double[] BeregnOpsparing(double opsparing, double aktuelOpsparing)
        {
            double[] opsparingFor12Mdr = new double[12];

            for (int i = 0; i < opsparingFor12Mdr.Length; i++)
            {
                opsparingFor12Mdr[i] = aktuelOpsparing + (opsparing * (i + 1));
            }

            return opsparingFor12Mdr;
        }

        //Her oprettes metoden til at beregne procentfordelingen, som skal benyttes i pie-charten
        private Dictionary<string, double> BeregnProcentfordeling(double husleje, double mad, double transport, double ovrigeUdgifter, double opsparing)
        {
            //Her oprettes en dictionary-variable, som skal indeholde de forskellige udgifter og procentsatsene for udgifterne
            Dictionary<string, double> procentfordeling = new Dictionary<string, double>();

            //Her gives værdierne fra tekstboksene, til variablerne
            husleje = double.Parse(UGHuslejeTextBox.Text);
            mad = double.Parse(UGMadTextBox.Text);
            transport = double.Parse(UGTransportTextBox.Text);
            ovrigeUdgifter = double.Parse(UGØvrigeTextBox.Text);

            //Her beregnes procentfordelingen for husleje, mad, transport, øvrige udgifter og opsparing, baseret på det samlede beløb som bliver "brugt"
            double samletBelob = husleje + mad + transport + ovrigeUdgifter + opsparing;
            double huslejeProcent = (husleje / samletBelob) * 100;
            double madProcent = (mad / samletBelob) * 100;
            double transportProcent = (transport / samletBelob) * 100;
            double ovrigeUdgifterProcent = (ovrigeUdgifter / samletBelob) * 100;
            double opsparingProcent = (opsparing / samletBelob) * 100;

            //Her tildeles dictionary-variablen, udgift navnene og procentsatserne for udgifterne
            procentfordeling.Add("Husleje", huslejeProcent);
            procentfordeling.Add("Mad", madProcent);
            procentfordeling.Add("Transport", transportProcent);
            procentfordeling.Add("Øvrige Udgifter", ovrigeUdgifterProcent);
            procentfordeling.Add("Opsparing", opsparingProcent);

            return procentfordeling;
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Beregn_btn_Click(object sender, EventArgs e)
        {
            //Her sikres det at der står et tal i tekstboksene
            if (IndLønTextBox.Text == "") { IndLønTextBox.Text = "0"; }
            if (IndAndetTextbox.Text == "") { IndAndetTextbox.Text = "0"; }
            if (UGHuslejeTextBox.Text == "") { UGHuslejeTextBox.Text = "0"; }
            if (UGMadTextBox.Text == "") { UGMadTextBox.Text = "0"; }
            if (UGTransportTextBox.Text == "") { UGTransportTextBox.Text = "0"; }
            if (UGØvrigeTextBox.Text == "") { UGØvrigeTextBox.Text = "0"; }
            if (opsparingTextBox.Text == "") { opsparingTextBox.Text = "0"; }

            

            //Udregn de forskellige ud fra de indskrevne oplysninger:
            indkomst = double.Parse(IndLønTextBox.Text) + double.Parse(IndAndetTextbox.Text);
            udgifter = double.Parse(UGHuslejeTextBox.Text) + double.Parse(UGMadTextBox.Text) + double.Parse(UGTransportTextBox.Text) + double.Parse(UGØvrigeTextBox.Text);
            opsparing = double.Parse(opsparingTextBox.Text);


            //Her er en sikring for at man ikke forsøger at spare mere op end man har råd til
            if (indkomst - udgifter < opsparing)
            {
                //Her popper en messagebox op for at advare brugeren om at de ikke har råd til at spare op
                MessageBox.Show("Du har ikke nok penge til at spare " + opsparing.ToString("C") + " op på din opsparing");

                //Her resetter man opsparingen til 0 kr
                opsparingTextBox.Text = "0";
                opsparing = 0;
            }

            //Udregning af balance efter udgifter og penge til opsparing er trækket fra
            overskud = indkomst - udgifter - opsparing;


            //Sæt de forskellige total labels til det totale i den kategori
            Indkomstlbl.Text = indkomst.ToString("C");
            UGUdgifterlbl.Text = udgifter.ToString("C");
            overskudLabel.Text = overskud.ToString("C");
        }

        private void VisGraf_btn_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            
            //Her laves Søjlediagrammet for ens akkumilerende opsparing
                //Her gemmes resultaterne i en dataliste
                double[] opsparingData = BeregnOpsparing(opsparing, aktuelOpsparing);

                //Her oprettes serien af dataene
                Series opsparingSeries = new Series("Opsparing");

                //Her tilføjes dataene til serien ved hjælp af en for løkke
                for (int i = 0; i < opsparingData.Length; i++)
                {
                    opsparingSeries.Points.AddXY(i + 1, opsparingData[i]);
                }
                //Her tilføjes serien til chart1
                chart1.Series.Add(opsparingSeries);
            
            
                chart1.ChartAreas[0].AxisX.Title = "Måned";
                chart1.ChartAreas[0].AxisY.Title = "Opsparing";

            //Her laves pi-charten for ens procentvise fordeling af indkomst, udgifter og opsparing
                //Her gemmes resultaterne i en dictionary variable
                Dictionary<string, double> procentfordeling = BeregnProcentfordeling(husleje, mad, transport, ovrigeUdgifter, opsparing);

                //Her oprettes en serie af dataene
                Series pieSeries = new Series("Procentfordeling");
                
                //Her laves charten til et pie-chart
                pieSeries.ChartType = SeriesChartType.Pie;

                //Her tilføjes dataene til serien ved hjælp af en for-løkke
                foreach (KeyValuePair<string, double> kvp in procentfordeling)
                {
                    pieSeries.Points.AddXY(kvp.Key + " " + kvp.Value.ToString("F1") + "%", kvp.Value);
                }

                //Her tlføjes serien til chart2
                chart2.Series.Add(pieSeries);



        }

        //Her sikres at der kun kan skrives tal ind i tekstboksene
        private void IndLønTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IndAndetTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UGHuslejeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UGMadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UGTransportTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UGØvrigeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void opsparingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
