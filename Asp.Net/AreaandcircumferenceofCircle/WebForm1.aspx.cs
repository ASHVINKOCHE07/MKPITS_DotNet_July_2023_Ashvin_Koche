using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AreaandcircumferenceofCircle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float r = Convert.ToSingle(TextBox1.Text);
            float a, cir;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            a=3.14f*r*r;
            cir=2*3.14f*r;
            sb.Append("Area : "+a + "<br>" +"Circumference : "+cir);
            Label1.Text = sb.ToString();
        }
    }
}