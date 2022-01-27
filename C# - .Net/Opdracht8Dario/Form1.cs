namespace Opdracht6Dario
{
    public partial class FrmOpdracht6 : Form
    {
        public FrmOpdracht6()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            string personeel = "";
            int uren = 0;
            decimal loon = 0;
            decimal totaalLoonOnbelast;
            decimal totaalLoonBelast;

            try
            {
                personeel = TxtPersoneel.Text;
            }
            catch
            {
                MessageBox.Show("Geef een geldige naam in!");
            }

            try
            {
                uren = Convert.ToInt32(TxtUren.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
            }

            try
            {
                loon = Convert.ToDecimal(TxtUurloon.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
            }

            totaalLoonOnbelast = uren * loon;

            // Bruto Belastingen berekenen
            decimal belasting = 0;

            if (totaalLoonOnbelast > 50000)
            {
                belasting = ((totaalLoonOnbelast - 50000) * 0.5M) + (25000 * 0.4M) + (10000 * 0.3M) + (5000 * 0.2M);
            }
            else if(totaalLoonOnbelast > 25000)
            {
                belasting = ((totaalLoonOnbelast - 25000) * 0.4M) + (10000 * 0.3M) + (5000 * 0.2M);
            }
            else if(totaalLoonOnbelast > 15000)
            {
                belasting = ((totaalLoonOnbelast - 10000) * 0.3M) + (5000 * 0.2M);
            }
            else if(totaalLoonOnbelast > 10000)
            {
                belasting = ((totaalLoonOnbelast - 5000) * 0.2M);
            }
            else
            {
                belasting = 0;
            }

            totaalLoonBelast = totaalLoonOnbelast - belasting;

            TxtReultaat.Text = "LOONFICHE VAN " + personeel +
                "\n\r" +
                "\n\r" +
                "\n\rAantal gewerkte uren: " + uren +
                "\n\r" +
                "\n\rUurloon: " + loon.ToString("C") +
                "\n\r" +
                "\n\rBrutojaarwedde: " + totaalLoonOnbelast.ToString("C") +
                "\n\r" +
                "\n\rBelastingen: " + belasting.ToString("C") +
                "\n\r" +
                "\n\rNettojaarwedde: " + totaalLoonBelast.ToString("C");

        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtPersoneel.Clear();
            TxtUurloon.Clear();
            TxtUren.Clear();
            TxtReultaat.Clear();
            TxtPersoneel.Focus();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}