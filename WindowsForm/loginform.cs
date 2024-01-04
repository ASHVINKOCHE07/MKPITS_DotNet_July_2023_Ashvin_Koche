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
namespace sado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS;integrated security=true;database=adoserver";
        SqlConnection con= null;
        SqlCommand cmd = null;

        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string qr = "select count(*) from users where username=@username and pass=@password";
                cmd = new SqlCommand(qr, con);
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = textBox1.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = textBox2.Text;

                con.Open();
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());

                if (cnt > 0)
                    label3.Text = "login sucessfull";
                else
                    label3.Text = "invalid credentials,try again.";
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
