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

namespace updateandloadstudentdetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;integrated security=true;database=adoserver");

        DataSet ds= new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from students", con);
            cb = new SqlCommandBuilder(da);
            //use the fill method sqldataadapter  to load data into dataset;
            da.Fill(ds, "stud");
            dataGridView1.DataSource = ds.Tables["stud"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                da.Update(ds.Tables["stud"]);
                MessageBox.Show("Record updated");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
    }
}
