using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace employeesalarycalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string empname=TextBox1.Text,ds=DropDownList1.SelectedItem.ToString();
            float ts=0,da=0,hra = 0,bs=Convert.ToSingle(TextBox2.Text);

             if(ds=="Maneger")
            {
                da = 0.45f * bs;
                hra = 0.35f*bs;
            }
             else if (ds=="Peon")
            {
                da = 0.25f * bs;
                hra = 0.15f * bs;
            }
            else
            {
                Label1.Text= "Invalid designation";
                return;
            }
            ts = bs+da+hra;
            sb.Append("1.Employee Name : "+empname+"<br>"+"2.House Rent Allowance :"+hra+"<br>"+"3.Dearness Allowance : "+da+"<br>"+"4.Base Salary : "+bs+"<br>"+"5.Total Salary : "+ts);
            Label1.Text = sb.ToString();

        }
    }
}