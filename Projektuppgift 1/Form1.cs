using System.ComponentModel;

namespace Projektuppgift_1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int points = 0;
        int aces = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = rand.Next(1, 14);
            int suit = rand.Next(1, 5);
            if (value == 1) { aces++; points += 11; }
            else{ points += value; }

            if (points > 21) { while (points > 21 && aces > 1) { points -= 10; aces--; } }

            pointlabel.Text = $"{points}/21";

            cardbox.ImageLocation = $"C:\\Users\\miro\\source\\repos\\Projektuppgift 1\\Projektuppgift 1\\Sprites\\{suit}-{value}.png";
            cardbox.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
