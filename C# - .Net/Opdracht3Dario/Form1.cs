namespace Opdracht3Dario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtGetal1.Clear();
            TxtGetal2.Clear();
            TxtResultaat.Clear();
            TxtGetal1.Focus();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            double getal1;
            double getal2;
            try
            {
                getal1 = Convert.ToDouble(TxtGetal1.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }
            try 
            {
                getal2 = Convert.ToDouble(TxtGetal2.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }
            TxtResultaat.Text = Convert.ToString(getal1 + getal2);
        }

        private void BtnMaal_Click(object sender, EventArgs e)
        {
            double getal1;
            double getal2;
            try
            {
                getal1 = Convert.ToDouble(TxtGetal1.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }
            try
            {
                getal2 = Convert.ToDouble(TxtGetal2.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }
            TxtResultaat.Text = Convert.ToString(getal1 * getal2);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            double getal1;
            double getal2;
            try
            {
                getal1 = Convert.ToDouble(TxtGetal1.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }
            try
            {
                getal2 = Convert.ToDouble(TxtGetal2.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }
            TxtResultaat.Text = Convert.ToString(getal1 - getal2);
        }

        private void BtnDelen_Click(object sender, EventArgs e)
        {
            double getal1;
            double getal2;
            try
            {
                getal1 = Convert.ToDouble(TxtGetal1.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }
            try
            {
                getal2 = Convert.ToDouble(TxtGetal2.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }
            TxtResultaat.Text = Convert.ToString(getal1 / getal2);
        }
    }
}