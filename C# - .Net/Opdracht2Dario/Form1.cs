namespace Opdracht2Dario
{
    public partial class Opdracht2 : Form
    {
        public Opdracht2()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double straal;
            double pi = 3.1415;
            try 
            {
                straal = double.Parse(TxtStraal.Text);
            }
            catch
            {
                MessageBox.Show("Voor een geldige numerieke waarde in!");
                return;
            }
            TxtOppervlakte.Text = Convert.ToString(straal * straal * pi);
            TxtOmtrek.Text = Convert.ToString(straal * 2 * pi);
        }

        private void BtnLegen_Click(object sender, EventArgs e)
        {
            TxtStraal.Clear();
            TxtOppervlakte.Clear();
            TxtOmtrek.Clear();
            TxtStraal.Focus();
        }
    }
}