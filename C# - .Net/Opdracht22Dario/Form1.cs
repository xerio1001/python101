namespace Opdracht22Dario
{
    public partial class FrmOpdracht22Dario : Form
    {
        public FrmOpdracht22Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();
            TxtGrootteFiguur.Clear();
            TxtGrootteFiguur.Focus();
        }

        private void BtnRuit_Click(object sender, EventArgs e)
        {

        }

        private void BtnDriehoek_Click(object sender, EventArgs e)
        {

        }

        private void BtnRandVierkant_Click(object sender, EventArgs e)
        {

        }

        private void BtnVolVierkant_Click(object sender, EventArgs e)
        {
            int waarde = 0;

            try
            {
                waarde = Convert.ToInt16(TxtGrootteFiguur.Text);
                if(waarde <= 0)
                {
                    MessageBox.Show("Geef een waarde hoger dan 0 in.");
                    TxtGrootteFiguur.Clear();
                    TxtGrootteFiguur.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in.");
            }

            for(int i = 0; i < waarde; i++)
            {
                TxtResultaat.AppendText(String.Format("{0,-2}","*"));
            }

            TxtResultaat.AppendText(Environment.NewLine);

            for (int x = 1; x < waarde; x++)
            {
                TxtResultaat.AppendText("*");
                TxtResultaat.AppendText(Environment.NewLine);
            }
            

        }
    }
}