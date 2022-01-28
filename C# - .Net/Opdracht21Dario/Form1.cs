namespace Opdracht21Dario
{
    public partial class FrmOpdracht21Dario : Form
    {
        public FrmOpdracht21Dario()
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
            TxtMaxWaarde.Text = "10";
            TxtMaxWaarde.Focus();
        }

        private void BtnVermenigvuldigen_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();
            int waarde = 10;

            try
            {
                waarde = Convert.ToInt16(TxtMaxWaarde.Text);
                if (waarde > 20)
                {
                    MessageBox.Show("Geef een waarde kleiner of gelijk aan 20 in.");
                    TxtMaxWaarde.Text = "10";
                    return;
                }
                else if(waarde < 0)
                {
                    MessageBox.Show("Geef een waarde groter dan 0 in.");
                }
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in");
            }

            TxtResultaat.AppendText("    ");

            for (int i = 0; i <= waarde; i++)
            {
                TxtResultaat.AppendText(string.Format("{0,4}", i));
            }
            TxtResultaat.AppendText(Environment.NewLine);
            TxtResultaat.AppendText(Environment.NewLine);

            for (int i = 0; i <= waarde; i++)
            {
                TxtResultaat.AppendText(string.Format("{0,4}", i));

                for (int x = 0; x <= waarde; x++)
                {
                    int resultaat;
                    resultaat = i * x;
                    TxtResultaat.AppendText(string.Format("{0,4}", resultaat.ToString()));
                }
                TxtResultaat.AppendText(Environment.NewLine);
            }
        }

        private void BtnOptellen_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();
            int waarde = 10;

            try
            {
                waarde = Convert.ToInt16(TxtMaxWaarde.Text);
                if(waarde > 20)
                {
                    MessageBox.Show("Geef een waarde kleiner of gelijk aan 20 in.");
                    TxtMaxWaarde.Text = "10";
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geldige numerieke waarde in");
            }

            TxtResultaat.AppendText("    ");

            for (int i = 0; i <= waarde; i++)
            {
                TxtResultaat.AppendText(string.Format("{0,4}", i));
            }
            TxtResultaat.AppendText(Environment.NewLine);
            TxtResultaat.AppendText(Environment.NewLine);

            for (int i = 0; i <= waarde; i++)
            {
                TxtResultaat.AppendText(string.Format("{0,4}", i));

                for (int x = 0; x <= waarde; x++)
                {
                    int resultaat;
                    resultaat = i + x;
                    TxtResultaat.AppendText(string.Format("{0,4}", resultaat.ToString()));
                }
                TxtResultaat.AppendText(Environment.NewLine);
            }
        }
    }
}