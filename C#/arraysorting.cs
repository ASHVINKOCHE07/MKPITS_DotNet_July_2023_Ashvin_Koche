using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity:  " + ar.Capacity);
            MessageBox.Show("Count: " + ar.Count);
            StringBuilder sb = new StringBuilder();
            //  ar.Sort();
            foreach (object o in ar)
            {
                sb.Append("name = " + o.ToString() + "\n");
            }
            label2.Text = sb.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ar.Insert(2, textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
