﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace simplepatternmatrix
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for(int i=1;i<=num;i++)
            {
                for(int j=1;j<=num;j++)
                {
                    sb.Append(i);
                }
                sb.Append("<br>");
            }
            Label1.Text= sb.ToString(); 
        }
    }
}