using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace primenumberprint
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int f=1;
            for(int i=3;i<20;i++)
            {
                f = 1;
                for(int j=3;j<i;j++)
                {
                    if(i%j==0)
                    {
                        f = 0;
                        break;
                    }
                }
                if (f == 1)
                {
                    sb.Append(i + "<br>");
                }
            }
            Label1.Text= sb.ToString();
        }
    }
}