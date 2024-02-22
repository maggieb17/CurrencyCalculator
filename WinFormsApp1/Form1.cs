namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (a == "1")
            {
                var myForm = new Form2();
                myForm.Show();
            }
            if (a == "2")
            {
                var myForm = new Form3();
                myForm.Show();
            }
        }
    }
}