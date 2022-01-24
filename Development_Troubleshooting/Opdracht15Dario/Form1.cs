using System;
using System.Collections.Generic;

namespace Opdracht15Dario
{
    public partial class FrmOpdracht15Dario : Form
    {
        List<KeyValuePair<string, int>> data = new List<KeyValuePair<string, int>>();

        public FrmOpdracht15Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtNaam.Clear();
            TxtSeconden.Clear();
            LblOutput.Text = "";
            TxtNaam.Focus();
            data.Clear();
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            string atleet;
            int tijd;

            try
            {
                atleet = TxtNaam.Text;
                tijd = Convert.ToInt16(TxtSeconden.Text);

                data.Add(new KeyValuePair<string, int>(atleet, tijd));
            }
            catch
            {
                if (string.IsNullOrEmpty(TxtNaam.Text))
                {
                    MessageBox.Show("Geef een naam in.");
                    return;
                }
                if (string.IsNullOrEmpty(TxtSeconden.Text))
                {
                    MessageBox.Show("Geef nummer in.");
                    return;
                }
            }
            TxtNaam.Clear();
            TxtSeconden.Clear();    
        }

        private void BtnSnelste_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, int> snelste = new KeyValuePair<string, int>("" , 0);
            foreach(var element in data)
            {
                if(element.Value > snelste.Value)
                {
                    snelste = element;
                }
            }
            LblOutput.Text = "De snelste atleet is " + snelste.Key.ToString() +
                    "\n\r" +
                    "totaal aantal seconden " + snelste.Value.ToString();
            /*
                int tijdMinuten = snelste.Value / 60;
                int tijdUren = tijdMinuten / 60;

                LblOutput.Text =
                    "De snelste atleet is " + snelste.Key.ToString() + 
                    "\n\r" +
                    "totaal aantal seconden " + snelste.Value.ToString() +
                    "\n\r" + "\n\r" +
                    "Totaal aantal uren: " + tijdUren.ToString() + "\n\r" +
                    "Totaal aantal minuten: " + tijdMinuten.ToString() + "\n\r" +
                    "totaal aantal seconden: " + snelste.Value.ToString();
            */
        }
    }
}