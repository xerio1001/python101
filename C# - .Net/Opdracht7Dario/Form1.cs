namespace Opdracht7Dario
{
    public partial class FrmOpdracht7 : Form
    {
        public FrmOpdracht7()
        {
            InitializeComponent();
        }
        // Toon textvak van klassenwaardes als men op TxtKlasse focused. 
        private void TxtKlasse_Enter(object sender, System.EventArgs e)
        {
            TxtKlasseWaardes.Show();
        }
        // Verberg textvak van klassenwaardes als men niet meer op TxtKlasse focused.
        private void TxtKlasse_Leave(object sender, System.EventArgs e)
        {
            TxtKlasseWaardes.Hide();
        }

        private void BtnBerkenen_Click(object sender, EventArgs e)
        {
            string bestemming;
            double prijsVlucht;
            int klasse;
            double prijsPerDag;
            int aantalDagen;
            int AantalPersonen;
            int kortingPercentage;

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

                if(klasse == 3)
                {
                    klasse = 1;
                }
                else if(klasse == 2)
                {
                    klasse = 2;
                }
                else if(klasse == 1)
                {
                    klasse = 3;
                }
                else
                {
                    MessageBox.Show("Er zijn maar 3 klasses!");
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
                AantalPersonen = Convert.ToInt16(TxtAantalPersonen.Text);
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

            double totaalVluchtPrijs = (prijsVlucht * klasse) * AantalPersonen;
            double totaalVerblijfPrijs = (prijsPerDag * aantalDagen) * AantalPersonen;
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