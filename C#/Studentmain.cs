using System.Text;

namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] s = new Student[10];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            s[0] = new Student();
            s[1] = new Student();
            s[2] = new Student();
            s[3] = new Student();
            s[4] = new Student();
            s[5] = new Student();
            s[6] = new Student();
            s[7] = new Student();
            s[8] = new Student();
            s[9] = new Student();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 10)
            {
                s[cnt].sname = textBox1.Text;
                s[cnt].rollno = Convert.ToInt32(textBox2.Text);
                s[cnt].fess = Convert.ToDouble(textBox3.Text);
                s[cnt].d1 = Convert.ToInt32(textBox4.Text);
                s[cnt].d2 = Convert.ToInt32(textBox5.Text);
                s[cnt].d3 = Convert.ToInt32(textBox6.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox1.Focus();

                if (cnt == 10)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("details of 10 employees accepted");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("employee details are : " + "\n");
            for (int i = 0; i < 10; i++)
            {
                sb.Append("----------------------------------------\n");
                sb.Append("1.Student Name : " + s[i].sname + "\n");
                sb.Append("2.Student Rollno : " + s[i].rollno + "\n");
                sb.Append("3.Fees : " + s[i].fess + "\n");
                sb.Append("4.Date : " + s[i].d1 + " / " + s[i].d2 + " / " + s[i].d3 + "\n");
                sb.Append("----------------------------------------\n");
            }

            richTextBox1.Text = sb.ToString();
            //code to find highest fees
            double high = s[0].fess;
            int foundat = 0;
            for (int i = 0; i < 10; i++)
            {
                if (high < s[i].fess)
                {
                    high = s[i].fess;
                    foundat = i;
                }
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Highest fees paid: \n");
            sb1.Append("1.Student Name : " + s[foundat].sname + "\n");
            sb1.Append("2.Student Rollno : " + s[foundat].rollno + "\n");
            sb1.Append("3.Fees : " + s[foundat].fess + "\n");
            sb1.Append("4.Date : " + s[foundat].d1 + " / " + s[foundat].d2 + " / " + s[foundat].d3 + "\n");
            sb1.Append("----------------------------------------\n");
            label8.Text = sb1.ToString();
        }
    }
}