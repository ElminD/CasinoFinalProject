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
        public List<String> pswds = new List<String>();
        public List<String> usernames = new List<String>();

        public Form1()
        {
            InitializeComponent();

            button1.Hide();
            button2.Hide();

          

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

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;


            int index = 1;
            for(int i = 0; i < usernames.Count; i++)
            {
                if (usernames[i].Equals(username))
                {
                    index = i;
                }
            }

            if (pswds[index].Equals(password))
            {
                textBox1.Hide();
                textBox2.Hide();
                button3.Hide();
                button1.Show();
                button2.Show();
            };
            
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet1.Table);

            foreach (DataRow row in this.database1DataSet1.Table)
            {
                pswds.Add(row["Password"].ToString());
                usernames.Add(row["Username"].ToString());
                MessageBox.Show(row["Password"].ToString());
                MessageBox.Show(row["Username"].ToString());
            }

        }
    }
}
