namespace Opdracht20Dario
{
    public partial class FrmOpdracht20Dario : Form
    {
        public FrmOpdracht20Dario()
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
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int x = 1;
            string strResultaat = "";
            do
            {
                for (int i = 1; i <= 12; i++)
                {
                    int resultaat = i * x;
                    strResultaat += string.Format("{0,2} * {1,2} = {2,3}", x, i, resultaat) + Environment.NewLine;
                }
                x += 1;
            }
            while (x <= 12);

            TxtResultaat.Text = Convert.ToString(strResultaat);
        }
    }
}