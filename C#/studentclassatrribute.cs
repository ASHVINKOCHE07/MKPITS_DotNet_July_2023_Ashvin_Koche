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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList al = new ArrayList();
        student[] stud = new student[3];
        int i = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= 3)
            {
                stud[i - 1] = new student(Convert.ToInt32(textBox1.Text), textBox2.Text);
                al.Add(stud[i - 1]);
            }

            if (i == 3)
            {
                MessageBox.Show("3 student added");
                button1.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (student s in al)
            {
                sb.Append("rno " + s.rno + " name " + s.name + "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
