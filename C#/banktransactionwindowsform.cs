using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bank;

namespace bankingtransactions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account account = null;

        private void button1_Click(object sender, EventArgs e)
        {
            account.actno=Convert.ToInt32(textBox1.Text);
            String res = account.deposit(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "saving")
            {
                account = new Saving();
            }
            else if (comboBox1.Text == "current")
            {
                account = new Current();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            account.actno = Convert.ToInt32(textBox1.Text); 
            string res=account.withdrawl(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            account.actno = Convert.ToInt32(textBox1.Text);
            string res = account.showbalance(); 
            label4.Text = res;
        }
    }
}
