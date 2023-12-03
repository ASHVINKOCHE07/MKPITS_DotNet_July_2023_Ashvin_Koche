using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);
            int flag = 0;
            int count = 2;
            while (count<num)
            {
                if (num % count == 0)
                {
                    flag = 1;
                    break;
                }
                count++;
            }
            if(flag==0)
            {
                label2.Text=num.ToString() + " is a prime number.";
                
            }
            else
            {
                label2.Text = num.ToString() + "is not a prime number.";
            }
        }
    }
}
