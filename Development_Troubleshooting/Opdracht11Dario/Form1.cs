namespace Opdracht11Dario
{
    public partial class Opdracht11Dario : Form
    { 
        public Opdracht11Dario()
        {
            InitializeComponent();
        }
        
        private int randomGetal = new Random().Next(1, 101);

        private int i = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEvalueer_Click(object sender, EventArgs e)
        {
            int getal = 0;
            
            try
            {
                getal = Convert.ToInt16(TxtInputGetal.Text);

                if (getal > 100)
                {
                    MessageBox.Show("De ingevoerde waarde is te hoog! Blijf tussen de 0 en 100.");
                }
            }
            catch
            {
                MessageBox.Show("Geef een juist getal in!");
            }
            
            if (getal > this.randomGetal)
            {
                TxtGewonnen.Text = "Uw getal dat u heeft geraden is te hoog. Probeer nog eens.";
                this.i += 1;
            }
            else if (getal < this.randomGetal)
            {
                TxtGewonnen.Text = "Uw getal dat u heeft geraden is te laag. Probeer nog eens.";
                this.i += 1;
            }
            else
            {
                TxtGewonnen.Text = "Proficiat! U heeft het getal geraden";
                TxtAantalGeraden.Text = "Aantal keer geraden: " + 
                this.i;
            }
        }

        private void BtnNieuw_Click(object sender, EventArgs e)
        {
            this.i = 1;
            TxtAantalGeraden.Clear();
            TxtGewonnen.Clear();
            TxtInputGetal.Clear();
            TxtInputGetal.Focus();
            this.randomGetal = new Random().Next(1, 101);
        }
    }
}