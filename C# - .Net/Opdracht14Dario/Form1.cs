namespace Opdracht14Dario
{
    public partial class FrmOpdracht14Dario : Form
    {
        public FrmOpdracht14Dario()
        {
            InitializeComponent();
            TimerDatum.Start();
        }
        private void TimerDatum_Tick(object sender, EventArgs e)
        {
            string huidigeTijd = DateTime.Now.ToString("HH:mm:ss");
            this.LblHuidigeDatum.Text = huidigeTijd;
        }

        private void BtnBerkenen_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime gebDatum = Convert.ToDateTime(TxtGebDatum.Text);

            TimeSpan timeSpan = DateTime.Now - gebDatum;

            int aantalDagen = timeSpan.Days;
            int aantalJaren = today.Year - gebDatum.Year;
            int aantalMaanden = (aantalJaren * 12) + DateTime.Now.Month - gebDatum.Month;

            TxtJaren.Text = Convert.ToString(aantalJaren);
            TxtMaanden.Text = Convert.ToString(aantalMaanden);
            TxtDagen.Text = Convert.ToString(aantalDagen);
        }
    }
}