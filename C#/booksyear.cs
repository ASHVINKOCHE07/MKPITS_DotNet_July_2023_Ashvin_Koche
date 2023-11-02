using System;
using System.Text;
using System.Windows.Forms;

namespace winform_books_array_properties
{
    public partial class Form1 : Form
    {
        private int cnt = 0;
        private Books[] book1 = new Books[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                book1[cnt] = new Books();
                book1[cnt].GetData(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if (cnt == 3)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    MessageBox.Show("Click on Result button");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < book1.Length; i++)
            {
                if (book1[i] != null)
                {
                    sb.Append("Title: " + book1[i].Title);
                    sb.Append("\nAuthor: " + book1[i].Author);
                    sb.Append("\nYear: " + book1[i].PublicationYear + "\n");
                }
            }

            label4.Text = sb.ToString();
        }
    }
}