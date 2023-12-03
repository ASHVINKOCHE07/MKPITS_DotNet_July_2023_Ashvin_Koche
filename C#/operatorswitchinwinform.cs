using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(textBox1.Text);
            int num2=Convert.ToInt32(textBox2.Text);
            String op=comboBox1.Text;
            switch (op)
            {
                case "+":
                    label4.Text = "addition = "+(num1+num2);
                    break;
                case "-":
                    label4.Text = "subtraction = " + (num1 - num2);
                    break;
                case "*":
                    label4.Text = "multiplication = " + (num1 * num2);
                    break;
                case "/":
                    label4.Text = "Division = " + (num1 / num2);
                    break;
            }
        }
    }
}
