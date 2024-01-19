using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Billingorder
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int p = Convert.ToInt32(TextBox4.Text);
            int q=Convert.ToInt32(TextBox5.Text);
            sb.Append("///////////////Bill//////////////////<br>");
            sb.Append("1.Order Number = " + TextBox1.Text+"<br>");
            sb.Append("2.Customer Name = " + TextBox2.Text+"<br>");
            sb.Append("3.Order Date = " + TextBox3.Text+"<br>");
            sb.Append("4.Product Ordered = " + DropDownList1.Text+"<br>");
            sb.Append("5.Price = Rs." + TextBox4.Text+"<br>");
            sb.Append("6.Quantity = " + q+"<br>");
            sb.Append("7.Total Amount = Rs." + (q*p)+"<br>");
            sb.Append("///////////////End//////////////////<br>");
            Label1.Text = sb.ToString();
        }
    }
}