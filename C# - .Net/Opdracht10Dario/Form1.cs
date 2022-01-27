namespace Opdracht7Dario
{
    public partial class FrmOpdracht7 : Form
    {
        public FrmOpdracht7()
        {
            InitializeComponent();
        }

        private void TxtKlasse_Click(object sender, EventArgs e)
        {
            ToolTip txtBallon = new ToolTip();
            txtBallon.IsBalloon = true;
            txtBallon.InitialDelay = 0;
            txtBallon.ShowAlways = true;
            txtBallon.SetToolTip(TxtKlasse, "1 = Buisnessklas \n\r 2 = Standard lijnvlucht \n\r 3 = Charter");
        }

        private void BtnBerkenen_Click(object sender, EventArgs e)
        {
            string bestemming;
            double prijsVlucht;
            int klasse;
            double prijsPerDag;
            int aantalDagen;
            int aantalPersonen;
            int kortingPercentage;

            double totaalVerblijfPrijs = 0;

            try 
            { 
                bestemming = TxtBestemming.Text;
            }
            catch
            {
                MessageBox.Show("Geef een geldige naam in!");
                TxtBestemming.Clear();
                TxtBestemming.Focus();
                return;
            }

            try
            {
                prijsVlucht = Convert.ToDouble(TxtBasisVlucht.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                TxtBasisVlucht.Clear();
                TxtBasisVlucht.Focus();
                return;
            }
            
            try
            {
                klasse = Convert.ToInt16(TxtKlasse.Text);

                if(klasse == 1)
                {
                    double resultaat = prijsVlucht * 0.3;
                    prijsVlucht = prijsVlucht + resultaat;
                }
                else if(klasse == 3)
                {
                    double resultaat = prijsVlucht * 0.2;
                    prijsVlucht = prijsVlucht - resultaat;
                }
                else if(klasse > 3)
                {
                    MessageBox.Show("Er zijn maar 3 klasses.");
                    TxtKlasse.Clear();
                    TxtKlasse.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                TxtKlasse.Clear();
                TxtKlasse.Focus();
                return;
            }

            try
            {
                prijsPerDag = Convert.ToDouble(TxtBasisPrijs.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                TxtBasisPrijs.Clear();
                TxtBasisPrijs.Focus();
                return;
            }

            try
            {
                aantalDagen = Convert.ToInt16(TxtAantalDagen.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                TxtAantalDagen.Clear();
                TxtAantalDagen.Focus();
                return;
            }

            try
            {
                aantalPersonen = Convert.ToInt16(TxtAantalPersonen.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                TxtAantalPersonen.Clear();
                TxtAantalPersonen.Focus();
                return;
            }

            try
            {
                kortingPercentage = Convert.ToInt16(TxtKortingsPercentage.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                TxtKortingsPercentage.Clear();
                TxtKortingsPercentage.Focus();
                return;
            }

            if(aantalPersonen == 3)
            {
                totaalVerblijfPrijs = ((prijsPerDag * 2) + (prijsPerDag * 0.5)) * aantalDagen;
            }
            else if(aantalPersonen >= 4)
            {
                totaalVerblijfPrijs = ((prijsPerDag * 2) + (prijsPerDag * 0.5) + (prijsPerDag * (aantalPersonen - 3) * 0.3)) * aantalDagen;
            }

            double totaalVluchtPrijs =  prijsVlucht * aantalPersonen;
            double totaalReisPrijs = totaalVluchtPrijs + totaalVerblijfPrijs;
            double totaalKorting = totaalReisPrijs / 100 * kortingPercentage;
            double totaalPrijs = totaalReisPrijs - totaalKorting;

            TxtResultaat.Text = 
                "REISKOSTEN VOLGENS BESTELLING NAAR " + bestemming + "\n\r" +
                "\n\r" + "\n\r" +
                "Totale vluchtprijs: " + totaalVluchtPrijs.ToString("C") + "\n\r" +
                "\n\r" +
                "totale verblijfprijs: " + totaalVerblijfPrijs.ToString("C") + "\n\r" +
                "\n\r" +
                "Totale reisprijs: " + totaalReisPrijs.ToString("C") + "\n\r" +
                "\n\r" +
                "Korting: " + totaalKorting.ToString("C") + "\n\r" +
                "\n\r" + "\n\r" +
                "Totaal te betalen: " + totaalPrijs.ToString("C");

        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtBestemming.Clear();
            TxtKlasse.Clear();
            TxtKortingsPercentage.Clear();
            TxtAantalDagen.Clear();
            TxtAantalPersonen.Clear();
            TxtBasisPrijs.Clear();
            TxtBasisVlucht.Clear();
            TxtResultaat.Clear();
            TxtBestemming.Focus();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}