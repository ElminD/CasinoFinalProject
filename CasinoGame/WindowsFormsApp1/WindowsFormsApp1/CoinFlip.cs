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
    public partial class CoinFlip : Form
    {
        
        public CoinFlip()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void CoinFlip_Load(object sender, EventArgs e)
        {

        }

       
        
        private void headPictureBox_Click(object sender, EventArgs e)
        {
           
        }
        int score = 0;
        private void startButton_Click(object sender, EventArgs e)
        {
            try {
                
                Random rnd = new Random();
                int coin = rnd.Next(0, 2);
                headPictureBox.Hide();
                tailPictureBox.Hide();

                if(coin == 1)
                {
                    headPictureBox.Show();
                }
                else
                {
                    tailPictureBox.Show();
                }

                int userGuess = int.Parse(textBox1.Text);

                if(coin != userGuess)
                {
                    MessageBox.Show("You Lost!");
                    
                }
                else
                {
                    score++;
                    outputLabel.Text = "score: " + score.ToString();
                    MessageBox.Show("You Won!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

