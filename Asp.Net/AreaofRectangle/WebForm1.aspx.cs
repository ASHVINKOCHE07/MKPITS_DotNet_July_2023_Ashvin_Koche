using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AreaofRectangle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float a;
            float l=Convert.ToSingle(TextBox1.Text);
            float b=Convert.ToSingle(TextBox2.Text);
            a=l*b;
            Label1.Text=a.ToString();
        }
    }
}