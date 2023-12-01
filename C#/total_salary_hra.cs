using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ename=textBox1.Text;
            int bsal=Convert.ToInt32(textBox1.Text);
            string designation = textBox3.Text;
            float hra = 0;
            float bonus = 0;
            float totalsal = 0;
            switch (designation)
            {
                case "manager":
                    hra = bsal * 0.35f;
                    bonus = bsal * 0.5f;
                    break;
                case "clerk":
                    hra = bsal * 0.25f;
                    bonus = bsal * 0.3f;
                    break;
                case "peon":
                    hra = bsal * 0.15f;
                    bonus = bsal * 0.2f;
                    break;
            }
            label4.Text = "hra " + hra;
            label5.Text = "bonus " + bonus;
            totalsal = hra + bonus + bsal;
            label6.Text = "total sal " + totalsal;


        }
    }
}
