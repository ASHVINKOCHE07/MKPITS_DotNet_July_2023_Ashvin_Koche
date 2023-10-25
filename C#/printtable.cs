using System.Text;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stringbuilder class used to add new string to existing string.
            StringBuilder sb = new StringBuilder();
            int num = Convert.ToInt32(textBox1.Text);
            int res = 1;
            for (int count = 1; count <= 10; count++)
            {
                res = num * count;
                sb.Append(num + "*" + count + "=" + res +"\n");
                label2.Text = sb.ToString();
            }
        }
    }
}