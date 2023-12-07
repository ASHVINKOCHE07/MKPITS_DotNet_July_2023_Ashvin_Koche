using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginpanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin"&&textBox2.Text=="admin")
            {
                MessageBox.Show("login sucessful");
                panel1.Visible = false;
                menuStrip1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid credentials,please try again");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void addmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addmission a= new addmission();
            a.MdiParent = this;
            a.Show();
        }
       
        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enquiry enquiry = new Enquiry();
            enquiry.MdiParent = this;
            enquiry.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
    }

