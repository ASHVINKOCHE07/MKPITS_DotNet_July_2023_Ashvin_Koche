using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DepositandWithdrawl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        int amt, bal = 1000;
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        public void deposit(int amt)
        {
           bal=bal+amt;
            sb.Append("2.Balance :" + bal+"<br>"); 
            sb.Append("3.Deposited Amount :" + amt+"<br>"); 
            sb.Append("4.New Balance:" + bal+"<br>"); 
        }

        public void withdrawl(int amt) 
        {
            if(bal<300)
            {
                Label1.Text = "Minimum balance limit reached cannot withdrawl";
            }
            else
            {
                bal = bal - amt;
                sb.Append("2.Balance :" + bal + "<br>");
                sb.Append("3.Withdrew Amount :" + amt + "<br>");
                sb.Append("4.New Balance:" + bal + "<br>");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            amt=Convert.ToInt32(TextBox2.Text);
            sb.Append("1.Account Number : " + TextBox1.Text + "<br>");
            
          if(RadioButton1.Checked)
            {
              deposit(amt);
            }
          else if(RadioButton2.Checked)
            {
                withdrawl(amt);
            }
          Label1.Text=sb.ToString();
        }
    }
}