using System.Security.Cryptography.Xml;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] marks = new int[3];
        int total = 0;
        float per;
        int Count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Count < 3)
            {
                marks[Count] = Convert.ToInt32(textBox1.Text);
                Count++;
                textBox1.Clear();
                textBox1.Focus();
                if (Count == 3)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("you have entered 3 subject now click on result button");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int count1=0;count1<marks.Length;count1++)
            {
                total = total + marks[count1];
            }
            label2.Text = "total marks : " + total; ;
            per = (total / 300.0f) * 100.0f;
            label3.Text = "percentage : %" + per;
        }
    }
}