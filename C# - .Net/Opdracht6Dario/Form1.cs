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
            decimal totaalLoonOnbelast = 0;
            decimal belasting = 0;
            decimal totaalLoonBelast = 0;

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
                TxtUren.Text.Replace(".", ",");
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
            }

            totaalLoonOnbelast = uren * loon;
            belasting = totaalLoonOnbelast / 100 * 30;
            totaalLoonBelast = totaalLoonOnbelast - belasting;

            TxtReultaat.Text = "LOONFICHE VAN " + personeel +
                "\n\r" +
                "\n\r" +
                "\n\rAantal gewerkte uren: " + uren.ToString("C") +
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