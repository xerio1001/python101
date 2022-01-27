namespace Opdracht1Dario
{
    public partial class FrmOmzetten : Form
    {
        public FrmOmzetten()
        {
            InitializeComponent();
        }
        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double euro;
            double frank = 40.3399;
            try
            {
                euro =  Convert.ToDouble(TxtEuro.Text);
            }
            catch 
            {
                MessageBox.Show("Voer een geldige numerieke waarde in!");
                TxtEuro.Clear();
                TxtEuro.Focus();
                return;
            }
            TxtBEF.Text = Convert.ToString(euro * frank);
        }

        private void BtnLegen_Click(object sender, EventArgs e)
        {
            TxtEuro.Clear();
            TxtBEF.Clear();
            TxtEuro.Focus();
        }
    }
}