using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num= Convert.ToInt32(textBox1.Text);
            int count = 1;
            StringBuilder sb= new StringBuilder();  
            while (count<= 10) 
            {
                sb.Append(num+"X"+count+"="+(num*count)+"\n");
                count++;
            }
            label2.Text = sb.ToString();
        }
    }
}
