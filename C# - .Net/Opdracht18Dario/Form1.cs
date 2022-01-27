namespace Opdracht18Dario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LblResultaat.Text =
                "Getal 1 : " + "\n\r" +
                "Getal 2 : " + "\n\r" +
                "Getal 3 : " + "\n\r" +
                "Getal 4 : " + "\n\r" +
                "Getal 5 : " + "\n\r" +
                "Getal 6 : " + "\n\r";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r1 = new();
            int r1Int = r1.Next(0, 45);           

            Random r2 = new();
            int r2Int = r2.Next(0, 45);

            Random r3 = new();
            int r3Int = r3.Next(0, 45);

            Random r4 = new();
            int r4Int = r4.Next(0, 45);

            Random r5 = new();
            int r5Int = r5.Next(0, 45);

            Random r6 = new();
            int r6Int = r6.Next(0, 45);

            LblResultaat.Text =
                "Getal 1 : " + r1Int + "\n\r" +
                "Getal 2 : " + r2Int + "\n\r" +
                "Getal 3 : " + r3Int + "\n\r" +
                "Getal 4 : " + r4Int + "\n\r" +
                "Getal 5 : " + r5Int + "\n\r" +
                "Getal 6 : " + r6Int + "\n\r";
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            LblResultaat.Text =
                "Getal 1 : " + "\n\r" +
                "Getal 2 : " + "\n\r" +
                "Getal 3 : " + "\n\r" +
                "Getal 4 : " + "\n\r" +
                "Getal 5 : " + "\n\r" +
                "Getal 6 : " + "\n\r";
        }
    }
}