namespace Opdracht13Dario
{
    public partial class Opdracht13Dario : Form
    {
        public Opdracht13Dario()
        {
            InitializeComponent();
        }

        private void TrackbarInkomen_Scroll(object sender, EventArgs e)
        {
            salarisToolTip.SetToolTip(TrackbarInkomen, TrackbarInkomen.Value.ToString());

            decimal inkomenOnBelast = TrackbarInkomen.Value;
            decimal belastingen;
            decimal inkomenBelast;

            if (inkomenOnBelast >= 50000){
                belastingen = inkomenOnBelast * 0.1M;
            }
            else if(inkomenOnBelast < 50000 && inkomenOnBelast >= 10000)
            {
                belastingen = inkomenOnBelast * 0.8M;
            }
            else
            {
                belastingen = 0;
            }

            inkomenBelast = TrackbarInkomen.Value - belastingen;
            LblUitkomstBelastingen.Text = Convert.ToString(inkomenBelast);
        }
    }
}