using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1,s2,s3,total;
            float per;
            string grade;
            s1=Convert.ToInt32(textBox1.Text);
            s2=Convert.ToInt32(textBox2.Text);
            s3=Convert.ToInt32(textBox3.Text);
            total = s1 + s2 + s3;
            per = (total / 300.0f) * 100;
            label4.Text = "1. Total Marks = " + total;
            label5.Text = "2. Percentage = " + per;
            if (per >= 75)
                grade = "Distinction";
            else if(per>=60 && per<75)
                grade = "First Class";
            else if (per >= 40 && per < 60)
                grade = "Second Class";
            else
                grade = "Fail";
            label6.Text = "Result = "+grade;
        }
    }
}