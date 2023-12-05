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
            StringBuilder sb= new StringBuilder();
            sb.Append("username : "+textBox1.Text+"\n");
            sb.Append("password : "+textBox2.Text+"\n");
            string gender = null;
            if(radioButton1.Checked)
             {
                  gender = radioButton1.Text;
             }
            else if(radioButton2.Checked)
            {
                gender=radioButton2.Text;
            }
            else if (radioButton3.Checked) 
            {
                gender = radioButton3.Text;
            }
            sb.Append("Gender : "+gender+"\n");
            if(checkBox1.Checked)
            {
                sb.Append("Courses Joined : "+checkBox1.Text+"\n");
            }
            if (checkBox2.Checked)
            {
                sb.Append("Courses Joined : " + checkBox2.Text + "\n");
            }
            if (checkBox3.Checked)
            {
                sb.Append("Courses Joined : " + checkBox3.Text + "\n");
            }
            sb.Append("City : " + comboBox1.Text + "\n");
            label6.Text=sb.ToString();
        }
    }
}
