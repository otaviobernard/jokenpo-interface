using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        List<string> jogos;
        public Form1()
        {
            InitializeComponent();
            jogos = new List<string>
            {
                "paper",
                "rock",
                "scissor"
            };
        }

        private void scoreControl(string s){
            if(s == "l")
            {
                int iaScore = int.Parse(label7.Text);
                iaScore = iaScore + 1;
                label7.Text = iaScore.ToString();
            }
            else if(s == "w")
            {
                int youScore = int.Parse(label6.Text);
                youScore = youScore + 1;
                label6.Text = youScore.ToString();
            }
        }

        private void WinImage(string s)
        {
            if(s == "l"){
                pictureBox3.Image = Image.FromFile("images/lose.png");
            }
            else if(s == "w")
            {
                pictureBox3.Image = Image.FromFile("images/win.png");
            }
            else
            {
                pictureBox3.Image = Image.FromFile("images/draw.png");
            }

            scoreControl(s);
        }

        private void Winner(string you, string iA)
        {
            if(you == "rock" && iA == "paper"){
                WinImage("l");
            }
            else if (you == "rock" && iA == "scissor") {
                WinImage("w");
            }
            else if (you == "scissor" && iA == "rock")
            {
                WinImage("l");
            }
            else if (you == "scissor" && iA == "paper")
            {
                WinImage("w");
            }
            else if (you == "paper" && iA == "scissor")
            {
                WinImage("l");
            }
            else if (you == "paper" && iA == "rock")
            {
                WinImage("w");
            }
            else
            {
                WinImage("draw");
            }
        }

        private string RandomGenerator()
        {
            Random random = new Random();
            int i = random.Next(jogos.Count);
            string s = jogos[i];
            pictureBox2.Image = Image.FromFile("images/" + s + "Hand.png");
            return s;
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("images/paperHand.png");
            string s = RandomGenerator();
            Winner("paper", s);
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("images/rockHand.png");
            string s = RandomGenerator();
            Winner("rock", s);
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("images/scissorHand.png");
            string s = RandomGenerator();
            Winner("scissor", s);
        }
    }
}
