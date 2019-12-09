using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Slots : Form
    {
        public int score = 0;
        public int coins = 3;
        public int highscore = -1;
        public Slots()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
           
            frm.ShowDialog();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(coins > 0)
            {
                Random rnd = new Random();
                int image1 = rnd.Next(0, 3);
                int image2 = rnd.Next(0, 3);
                int image3 = rnd.Next(0, 3);
                pictureBox1.Image = imageList1.Images[image1];
                pictureBox2.Image = imageList1.Images[image2];
                pictureBox3.Image = imageList1.Images[image3];

                if (image1 == image2 && image1 == image3)
                {
                    score = score + 100;
                    coins = coins + 1;
                }
                else if (image1 == image2)
                {
                    score = score + 50;
                }
                else if (image2 == image3)
                {
                    score = score + 25;
                }

                label2.Text = "Score: " + score.ToString();
                label3.Text = "Coins: " + coins.ToString();
                coins = coins - 1;
            }
            else
            {
                if (score > highscore)
                {
                    highscore = score;

                }
                label4.Text = "High Score: " + highscore.ToString();


                MessageBox.Show("Out of Coins! your score is " + score.ToString());
                score = 0;
                coins = 3;
                label2.Text = "Score: " + score.ToString();
                label3.Text = "Coins: " + coins.ToString();


            }

         

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
