﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "server=LAPTOP-EL7M3D56\\sqlexpress;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "update users set password='" + textBox2.Text + "' where username='" + textBox1.Text + "'";

                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record updated successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string constr = "server=LAPTOP-EL7M3D56\\SQLEXPRESS;integrated security=true;database=mksample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                MessageBox.Show("Connection sucessful.");
                con.Close();
            }
            catch(Exception ee) 
            {
                Console.WriteLine("Connection failed , Error : "+ee.Message);
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "server=LAPTOP-EL7M3D56\\sqlexpress;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "insert into users values('" + textBox1.Text + "','" + textBox2.Text + "')";

                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record inserted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = "server=LAPTOP-EL7M3D56\\sqlexpress;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "delete from  users where username='" + textBox1.Text + "' or password ='" + textBox2.Text + "'";

                SqlCommand command = new SqlCommand(strcmd,con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record deleted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server=LAPTOP-EL7M3D56\\sqlexpress;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "delete from  users where username='" + textBox1.Text + "' or password ='" + textBox2.Text + "'";

                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record deleted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string constr = "server=LAPTOP-EL7M3D56\\sqlexpress;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "select * from users where username='" + textBox1.Text + "'";

                SqlCommand command = new SqlCommand(strcmd, con);
                SqlDataReader dr;
                int flag = 0;
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["password"].ToString();
                }
                dr.Close();
                con.Close();
                if (flag == 0)
                {
                    label3.Text = "record not found";
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
    }
}
