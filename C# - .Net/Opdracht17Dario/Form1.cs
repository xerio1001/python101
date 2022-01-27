namespace Opdracht17Dario
{
    public partial class FrmOpdracht17Dario : Form
    {
        public FrmOpdracht17Dario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtGetal.Text = "1";
            TxtResultaat.Clear();
            TxtGetal.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int getal = 1;
            int resultaat = 1;

            try
            {
                getal = Convert.ToInt16(TxtGetal.Text);
            }
            catch
            {
                MessageBox.Show("Geef een gelidge numerieke waarde!");
                return;
            }

            for(int i = 1; i <= getal; i++)
            {
                resultaat *= i;
            }

            TxtResultaat.Text = resultaat.ToString();
        }
    }
}