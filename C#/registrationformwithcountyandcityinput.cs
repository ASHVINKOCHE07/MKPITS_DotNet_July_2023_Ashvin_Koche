using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            switch (comboBox2.Text)
            {
                case "india":
                    comboBox1.Items.Add("Nagpur");
                    comboBox1.Items.Add("Pune");
                    comboBox1.Items.Add("Mumbai");
                    break;
                case "usa":
                    comboBox1.Items.Add("LA");
                    comboBox1.Items.Add("NewYork");
                    comboBox1.Items.Add("Manhattan");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("username :" + textBox1.Text + "\n");
            sb.Append("password :" + textBox2.Text + "\n");
            string gender = null;
            if(radioButton1.Checked)
            {
                gender=radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
           else if (radioButton3.Checked)
            {
                gender = radioButton3.Text;
            }
            sb.Append("Gender : " + gender + "\n");
            string course = null;
            if (checkBox1.Checked)
            {
                course = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                course =course+""+checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                course = course+""+checkBox3.Text;
            }
            sb.Append("Course : "+course+"\n");
            sb.Append("country : " + comboBox2.Text + "\n");
            sb.Append("city : " + comboBox1.Text + "\n");
            label6.Text=sb.ToString();


        }
    }
}
