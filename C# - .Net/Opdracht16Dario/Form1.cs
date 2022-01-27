using System.Collections.Generic;

namespace Opdracht16Dario
{
    public partial class FrmOpdracht16Dario : Form
    {
        public FrmOpdracht16Dario()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtGetal.Text = "1";
            TxtResultaat.Clear();
            TxtGetal.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            int getal = 1;
            int resultaat = 1;
            List<int> tempList = new List<int>();

            try
            {
                getal = Convert.ToInt16(TxtGetal.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geldig numerieke waarde in.");
            }

            for(int i = 0; i <= 10; i++)
            {
                resultaat = (int)Math.Pow(getal, i);
                tempList.Add(resultaat);
            }

            TxtResultaat.Text =
               "Macht 1 van " + getal.ToString() + " is " + tempList[0].ToString() + "\n\r" +
                "\n\r" +
                "Macht 2 van " + getal.ToString() + " is " + tempList[1].ToString() + "\n\r" +
                "\n\r" +
                "Macht 3 van " + getal.ToString() + " is " + tempList[2].ToString() + "\n\r" +
                "\n\r" +
                "Macht 4 van " + getal.ToString() + " is " + tempList[3].ToString() + "\n\r" +
                "\n\r" +
                "Macht 5 van " + getal.ToString() + " is " + tempList[4].ToString() + "\n\r" +
                "\n\r" +
                "Macht 6 van " + getal.ToString() + " is " + tempList[5].ToString() + "\n\r" +
                "\n\r" +
                "Macht 7 van " + getal.ToString() + " is " + tempList[6].ToString() + "\n\r" +
                "\n\r" +
                "Macht 8 van " + getal.ToString() + " is " + tempList[7].ToString() + "\n\r" +
                "\n\r" +
                "Macht 9 van " + getal.ToString() + " is " + tempList[8].ToString() + "\n\r" +
                "\n\r" +
                "Macht 10 van " + getal.ToString() + " is " + tempList[9].ToString() + "\n\r";
        }
    }
}