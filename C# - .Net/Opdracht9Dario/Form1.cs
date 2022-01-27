namespace Opdracht9Dario
{
    public partial class FrmCursusGeld : Form
    {
        private int lesuren = 0;

        public FrmCursusGeld()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TxtJaar_TextChanged(object sender, EventArgs e)
        {
            LblNumeriek.Hide();
        }

        private void BtnTestNumeriek_Click(object sender, EventArgs e)
        {
            int jaar;
            
            try
            {
                jaar = Convert.ToInt16(TxtJaar.Text);
                this.lesuren = Convert.ToInt16(TxtLesuren.Text);
                LblNumeriek.Show();

                if (jaar % 4 == 0 && jaar % 100 != 0 || jaar % 400 == 0)
                {
                    this.lesuren += 1;
                    Lblschrikkeljaar.Show();
                }
                else
                {
                    Lblschrikkeljaar.Hide();
                }
            }
            catch
            {
                TxtJaar.Clear();
                TxtJaar.Focus();
                LblNumeriek.Hide();

                TxtLesuren.Clear();
                LblNumeriek.Hide();
            }
        }
        private void BtnBerkenen_Click(object sender, EventArgs e)
        {
            if(this.lesuren == 0 || lesuren == 1)
            {
                try
                {
                    this.lesuren = Convert.ToInt16(TxtLesuren.Text);
                }
                catch
                {
                    MessageBox.Show("Geen geldige waarde!");
                }
            }

            decimal resultaat = this.lesuren * 1.5M;
            TxtCursusGeld.Text = Convert.ToString(resultaat);
        }
    }
}