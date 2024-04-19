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

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text += "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }
    }
}