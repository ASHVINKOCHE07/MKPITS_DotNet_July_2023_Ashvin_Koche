using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); 
            foreach (string s in list)
            {
               sb.Append("name : "+s+"\n");
            }
            label2.Text = sb.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (list.Contains(textBox1.Text))
            {
                label2.Text = "found in collection";
            }
            else
            {
                label2.Text = "not found in collections";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            list.Remove(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Insert(2, textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Sort();

        }
    }
}
