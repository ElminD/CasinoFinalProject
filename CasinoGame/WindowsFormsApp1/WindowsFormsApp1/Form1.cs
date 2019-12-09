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
    

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
          
            

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            CoinFlip frm2 = new CoinFlip();
            this.Hide();
            frm2.ShowDialog();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Slots frm = new Slots();
            this.Hide();
            frm.ShowDialog();

            
        }
    }
}
