using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fabonachiiseries
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int t= Convert.ToInt32(TextBox1.Text);
            int num1 = 0;
            int num2 = 1;
            int add;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(num1+","+num2);
            for(int i=3;i<=t;i++)
            {
                add = num1 + num2;
                sb.Append("," + add);
                num1 = num2;
                num2 = add;
                

            }
            Label1.Text = sb.ToString();
        }
    }
}