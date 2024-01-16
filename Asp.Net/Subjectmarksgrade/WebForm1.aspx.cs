using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subjectmarksgrade
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int total=Convert.ToInt32(TextBox1.Text)+Convert.ToInt32(TextBox2.Text)
                       +Convert.ToInt32(TextBox3.Text);
            float per = (total / 300f) * 100;
            string grade = null;
            if (per >= 75)
                grade = "A+";
            else if (per < 75 && per >= 60)
                grade = "A";
            else if(per<60&&per<=55)
                grade = "B";
            else if(per <55&&per>=40)
                grade = "C";
            else
                grade = "Fail,try again next time.";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("1.Total Marks :" + total + "<br>2.Percentage :" + per+"%" + "<br>3.Grade : " + grade);
            Label1.Text = sb.ToString();
            }
        }
    }
