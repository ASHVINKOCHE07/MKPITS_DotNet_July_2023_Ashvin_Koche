using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            float a, ci;
            r = Convert.ToInt32(textBox2.Text);
            a = 3.14f * r * r;
            ci = 2 * 3.14f * r;
            label2.Text = "1.Area =" + a;
            label3.Text = "2.Circumference =" + ci;
        }
    }
}