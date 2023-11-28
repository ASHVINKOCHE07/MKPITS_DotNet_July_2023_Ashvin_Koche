using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       LinkedList<int> li = new LinkedList<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            li.AddLast(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(int s in li)
            {
                sb.Append("num " + s + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkedListNode<int> node = li.Find(Convert.ToInt32(textBox1.Text));
            //  MessageBox.Show(node.ToString());
            li.AddBefore(node, 33);
         bool t=   li.Contains(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("found");


            /*
            if(li.Contains(textBox1.Text))
            {
                label2.Text = "found in collection";
            }
            else
            {
                label2.Text = "not found in collections";
            }
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            li.Remove(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            li.Insert(2, textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
            li.Sort();
            */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            li.AddFirst(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
