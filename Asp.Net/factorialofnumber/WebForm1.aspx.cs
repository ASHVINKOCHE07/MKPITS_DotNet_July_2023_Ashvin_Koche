using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace factorialofnumber
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(TextBox1.Text);
            int fac = 1;

            for(int i=num;i>0;i--)
            {
                fac = fac * i;
            }
            Label1.Text= "Factorial : "+fac.ToString();
        }
    }
}