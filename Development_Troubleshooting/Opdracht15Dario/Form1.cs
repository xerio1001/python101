namespace Opdracht15Dario
{
    public partial class FrmOpdracht15Dario : Form
    {
        public FrmOpdracht15Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtNaam.Clear();
            TxtSeconden.Clear();
            LblOutput.Text = "";
            TxtNaam.Focus();
        }

        private void BtnNieuw_Click(object sender, EventArgs e)
        {
            string atleet;
            string tijd;
            List<string> tussenlijst = new List<string>();
            List<string> data = new List<string>();

            try
            {
                atleet = TxtNaam.Text;
                tijd = TxtSeconden.Text;

                tussenlijst.Add(atleet);
                tussenlijst.Add(tijd);
                data.AddRange(tussenlijst);
            }
            catch
            {
                if (string.IsNullOrEmpty(TxtNaam.Text))
                {
                    MessageBox.Show("Geef een naam in.");
                    return;
                }
                if (string.IsNullOrEmpty(TxtSeconden.Text))
                {
                    MessageBox.Show("Geef nummer in.");
                    return;
                }
            }

            TxtNaam.Clear();
            TxtSeconden.Clear();
        }

        private void BtnSnelste_Click(object sender, EventArgs e)
        {

        }
    }
}