using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1-create connection string
            string str = "server=LAPTOP-EL7M3D56\\SQLEXPRESS;integrated security=true;database=mksample";

            SqlConnection con = null;

            //2-use sql connection class to connect to sql database.
            try
            {
                con = new SqlConnection(str);
                con.Open();//in connected envi.
                           //You have to explicitly open the connection
                           //using open method.
                MessageBox.Show("Connectiond Sucessfully !");
            }
            catch(Exception ee)
            {
                ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
