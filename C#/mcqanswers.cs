using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testpaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ca=0,ia=0;
        private void button1_Click(object sender, EventArgs e)
        {
            int res=0;
          if(radioButton2.Checked==true)
            {
                ca++;
            }
            else
            {
                ia++;
            }
            if (radioButton6.Checked == true)
            {
                ca++;
            }
            else
            {
                ia++;
            }
            if (radioButton7.Checked == true)
            {
                ca++;
            }
            else
            {
                ia++;
            }
            res = ca * 10;
            StringBuilder sb=new StringBuilder();
            sb.Append("Total marks out of 30:"+res+"\n");
            sb.Append("Total correct out of 3:"+ca+"\n");
            sb.Append("Total incorrect out of 3:"+ia+"\n");
            label5.Text=sb.ToString();

        }
    }
}
