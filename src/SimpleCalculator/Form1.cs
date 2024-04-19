namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text += "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }
    }
}