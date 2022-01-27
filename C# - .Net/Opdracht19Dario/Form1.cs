using System.Diagnostics;

namespace Opdracht19Dario
{
    public partial class FrmOpdracht19Dario : Form
    {
        public FrmOpdracht19Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtAantalPersonen.Clear();
            TxtResultaat.Clear();
            TxtAantalPersonen.Focus();
        }

        private void BtnBerekenen_Click(object sender, EventArgs e)
        {
            int aantalPersonen = 0;
            double kans = 1;
            double calcDagen = 365;

            try
            {
                aantalPersonen = Convert.ToInt16(TxtAantalPersonen.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
            }

            for (int i = 1; i < aantalPersonen; i++)
            {
                kans *= (calcDagen - i) / 365.0;
            }
            kans = 1 - kans;

            TxtResultaat.Text = "De kans op een gelijke verjaardag is " + kans.ToString("P");
        }
    }
}