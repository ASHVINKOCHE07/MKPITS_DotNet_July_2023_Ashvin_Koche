using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceApp
{
    public partial class Form1 : Form
    {
        List<Attendance> attendanceList = new List<Attendance>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get input from text boxes
            int rno = int.Parse(txtRno.Text);
            string name = txtName.Text;
            DateTime attdate = DateTime.Parse(txtDate.Text);
            string att = txtAtt.Text;

            // Create new Attendance object and add to list
            Attendance a = new Attendance(rno, name, attdate, att);
            attendanceList.Add(a);

            // Clear text boxes
            txtRno.Text = "";
            txtName.Text = "";
            txtDate.Text = "";
            txtAtt.Text = "";

            // Display success message
            MessageBox.Show("Attendance added successfully!");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Display all attendance information
            foreach (Attendance a in attendanceList)
            {
                MessageBox.Show("Roll No: " + a.Rno + ", Name: " + a.Name + ", Date: " + a.Attdate.ToString("dd/MM/yyyy") + ", Attendance: " + a.Att);
            }

            // Calculate total present and absent students
            int totalPresent = 0;
            int totalAbsent = 0;
            foreach (Attendance a in attendanceList)
            {
                if (a.Att == "P")
                {
                    totalPresent++;
                }
                else
                {
                    totalAbsent++;
                }
            }

            // Display total present and absent students
            MessageBox.Show("Total Present: " + totalPresent + ", Total Absent: " + totalAbsent);
        }
    }

    public class Attendance
    {
        public int Rno { get; set; }
        public string Name { get; set; }
        public DateTime Attdate { get; set; }
        public string Att { get; set; }

        public Attendance(int rno, string name, DateTime attdate, string att)
        {
            Rno = rno;
            Name = name;
            Attdate = attdate;
            Att = att;
        }
    }
}