using System;
using System.Collections.Generic;

namespace Opdracht15Dario
{
    public partial class FrmOpdracht15Dario : Form
    {
        List<KeyValuePair<string, int>> data = new List<KeyValuePair<string, int>>();
        private string str;

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
                tijd = Convert.ToInt32(TxtSeconden.Text);

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
            KeyValuePair<string, int> snelste = data[0];
            foreach(var element in data)
            {
                if(element.Value < snelste.Value)
                {
                    snelste = element;
                }
            }
            TimeSpan time = TimeSpan.FromSeconds(snelste.Value);
            string str = time.ToString(@"hh\:mm\:ss");
            LblOutput.Text =
                    "De snelste atleet is " + snelste.Key.ToString() + 
                    "\n\r" +
                    "totaal aantal seconden: " + snelste.Value.ToString() +
                    "\n\r" + "\n\r" +
                    "Totaal aantal uren: " + time.ToString(@"hh") + "\n\r" +
                    "Totaal aantal minuten: " + time.ToString(@"mm") + "\n\r" +
                    "totaal aantal seconden: " + time.ToString(@"ss");
            
        }
    }
}