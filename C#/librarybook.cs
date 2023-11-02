using System.Text;

namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LibraryBook[] book = new LibraryBook[3];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            book[0] = new LibraryBook();
            book[1] = new LibraryBook();
            book[2] = new LibraryBook();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                book[cnt].Title = textBox1.Text;
                book[cnt].Author = textBox2.Text;
                if (checkBox1.Checked)
                {
                    book[cnt].isavailable = true;
                }
                cnt++;
                textBox1.Clear();
                textBox2.Clear();

                textBox1.Focus();
                if (cnt == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;

                    button2.Enabled = true;
                    MessageBox.Show("details of 3 books accepted");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Available books are : " + "\n");
            for (int i = 0; i < 3; i++)
            {
                if (book[i].isavailable == true)
                {
                    sb.Append("----------------------------------------\n");
                    sb.Append("title: " + book[i].Title + "\n");
                    sb.Append("author : " + book[i].Author + "\n");
                    sb.Append("----------------------------------------\n");
                }
            }
            label3.Text = sb.ToString();
        }
    }
}