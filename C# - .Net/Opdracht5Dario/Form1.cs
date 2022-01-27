namespace Opdracht5Dario
{
    public partial class FrmOpdracht5 : Form
    {
        public FrmOpdracht5()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double normaal = 0;
            double korting = 0;
            double student = 0;
            double totaal;

            double normaalPrijs = 9.10;
            double kortingPrijs = 8.10;
            double studentPrijs = 6.90;

            try
            {
                normaal = Convert.ToDouble(TxtNormaal.Text);
                normaal = normaal * normaalPrijs;
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(TxtKorting.Text))
                {
                    korting = 0;
                }
                else
                {
                    korting = Convert.ToDouble(TxtKorting.Text);
                    korting = korting * kortingPrijs;
                }
            }
            catch 
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(TxtStudent.Text))
                {
                    student = 0;
                }
                else
                {
                    student = Convert.ToDouble(TxtStudent.Text);
                    student = student * studentPrijs;
                } 
            }
            catch 
            {
                MessageBox.Show("Geef een geldige numerieke waarde in!");
                return;
            }

            try
            {
                totaal = normaal + korting + student;
                TxtPrijs.Text = Convert.ToString(totaal);
            }
            catch
            {
                MessageBox.Show("Er is iets fout gegaan bij het berekenen!");
                return;
            }
            
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtNormaal.Clear();
            TxtKorting.Clear();
            TxtStudent.Clear();
            TxtPrijs.Clear();
            TxtNormaal.Focus();
        }

        private void BtnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}