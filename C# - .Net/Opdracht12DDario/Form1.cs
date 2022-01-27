namespace Opdracht12DDario
{
    public partial class Opdracht12Dario : Form
    {
        public Opdracht12Dario()
        {
            InitializeComponent();
            TxtVerwachtLenJongen.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string geslacht = "jongen";
            double lengteVader = 0;
            double lengteMoeder = 0;
            double lengteKind = 0;

            try
            {
                if(RadJongen.Checked == true)
                {
                    geslacht = "jongen";
                }
                else if(RadMeisje.Checked == true)
                {
                    geslacht = "meisje";
                }
            }
            catch
            {
                MessageBox.Show("U dient een geslacht aan te duiden.");
            }

            try
            {
                lengteVader = Convert.ToDouble(TxtLengteVader.Text);
            }
            catch
            {
                MessageBox.Show("U dient een lengte in te geven voor de vader.");
            }

            try
            {
                lengteMoeder = Convert.ToDouble(TxtLengteMoeder.Text);
            }
            catch
            {
                MessageBox.Show("U dient een lengte in te geven voor de moeder.");
            }

            if(geslacht == "jongen")
            {
                double tussenResultaat = (lengteVader + lengteMoeder + 13) / 2;
                lengteKind = tussenResultaat + 4.5;

                TxtVerwachtLenJongen.Text = Convert.ToString(lengteKind);
            }
            else if(geslacht == "meisje")
            {
                double tussenresultaat = (lengteVader + lengteMoeder - 13) / 2;
                lengteKind = tussenresultaat + 4.5;
                TxtVerwachtLenMeisje.Text = Convert.ToString(lengteKind);
            }

        }

        private void RadJongen_CheckedChanged(object sender, EventArgs e)
        {
            TxtVerwachtLenMeisje.Clear();
            TxtVerwachtLenMeisje.Enabled = false;
            TxtVerwachtLenJongen.Enabled = true;
        }

        private void RadMeisje_CheckedChanged(object sender, EventArgs e)
        {
            TxtVerwachtLenJongen.Clear();
            TxtVerwachtLenJongen.Enabled = false;
            TxtVerwachtLenMeisje.Enabled = true;
        }
    }
}