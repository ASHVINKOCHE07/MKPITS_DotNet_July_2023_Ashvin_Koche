using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace addmultiplywithxheckbox
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(TextBox1.Text);
            int n2=Convert.ToInt32(TextBox2.Text);  
            System.Text.StringBuilder sb=new System.Text.StringBuilder();
            if(CheckBox1.Checked)
            {
                sb.Append("Addition : "+(n1+n2)+"<br>");
            }
            if(CheckBox2.Checked)
            {
                sb.Append("Subtraction : "+(n1-n2)+"<br>");
            }
            if(CheckBox3.Checked)
            {
                sb.Append("Multiplication : " + (n1 * n2) + "<br>");
            }
            Label1.Text = sb.ToString();
        }
    }
}