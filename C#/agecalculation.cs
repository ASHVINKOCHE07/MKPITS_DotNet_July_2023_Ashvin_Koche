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

        private void button1_Click(object sender, EventArgs e)
        {
            string age= dateTimePicker1.Text;
            MessageBox.Show("DOB : "+age);
           // string dyr=age.Substring(12);
           
            int yr = dateTimePicker1.Value.Year;
            MessageBox.Show("Birth year : " + yr);
            int cy=DateTime.Now.Year;
            MessageBox.Show("Current year :"+cy);
            int currentage = cy - yr;
            MessageBox.Show("your age: "+currentage);
        }
    }
}
