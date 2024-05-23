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

        private void btn_mult_Click(object sender, EventArgs e)
        {
            display.Text += "*";
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

        private void btn_equal_Click(object sender, EventArgs e)
        {
             display.Text = Utility.EvaluateCalculationComplex(display.Text).ToString();

        }
               

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sum_Click(object sender, EventArgs e)
        {

            display.Text += "+";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            display.Text += "/";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            display.Text += "-";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            display.Clear();
        }
    }
}