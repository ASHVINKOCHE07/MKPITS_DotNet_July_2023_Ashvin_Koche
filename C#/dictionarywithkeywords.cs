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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Dictionary<string, string> domains = new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            domains.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            MessageBox.Show("added in dictionary");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(domains.Keys);
foreach(string key in keys)
            {
                sb.Append("keys in dictionay " + key + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(domains.Values);
            foreach (string key in keys)
            {
                sb.Append("values in dictionay " + key + "\n");
            }
            label4.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
           foreach(KeyValuePair<string,string> kvp in domains)
            {
                sb.Append("key " + kvp.Key + " value " + kvp.Value + "\n");
            }
            label4.Text = sb.ToString();
        }
    }
}

