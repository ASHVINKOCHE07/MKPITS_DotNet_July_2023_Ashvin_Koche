using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace numberisprimeornot
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int f = 0;
            for (int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    f = 1;
                    break;
                }
            }
            if (f == 0)
                Label1.Text = "It is Prime Number.";
            else
                Label1.Text = "It is not Prime Number";
        }
    }
}