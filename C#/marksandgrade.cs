using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1=Convert.ToInt32(textBox1.Text);
            int s2=Convert.ToInt32(textBox2.Text);
            int s3=Convert.ToInt32(textBox3.Text);
            int total = s1 + s2 + s3;
            label5.Text = total.ToString();
            float per = ((float)total / 300f) * 100;
            label6.Text = per.ToString()+"%";
            string grade = null;
             if(per>=75)
            {
                grade = "Distinction";
                
            }
            else if (per < 75 && per>=60 )
            {
                grade = "First Class";
            }
            else if (per < 60 && per >= 40)
            {
                grade = "Second Class";
            }
            else 
            {
                grade = "Failed Better Luck Next Time.";
            }
            label7.Text = grade;
        }
    }
}
