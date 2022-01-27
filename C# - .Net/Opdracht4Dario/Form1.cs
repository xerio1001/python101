namespace Opdracht4Dario
{
    public partial class Opdracht4 : Form
    {
        public Opdracht4()
        {
            InitializeComponent();
        }

        private void BtnControle_Click(object sender, EventArgs e)
        {
            //0707.128.119
            string strNummer = TxtNummer.Text;

            if (strNummer.Length != 12)
            {
                // print length niet goed
                MessageBox.Show("Geef een geldige waarde in van 12 karakters");
            }
            else
            {
                strNummer = strNummer.Replace(".", "").Replace(" ", "");

                int tempFirstNum = Convert.ToInt32(strNummer.Substring(0, 8));
                int tempLastNum = Convert.ToInt32(strNummer.Substring(8, 2));

                int CalculatedNum = tempFirstNum % 97;

                if (97 - CalculatedNum == tempLastNum)
                {
                    TxtGeldig.Text = Convert.ToString("Ja");
                }
                else
                {
                    TxtGeldig.Text = Convert.ToString("Nee");
                }
            }
        }

        private void BtnLegen_Click(object sender, EventArgs e)
        {
            TxtNummer.Clear();
            TxtGeldig.Clear();
            TxtNummer.Focus();
        }
    }
}