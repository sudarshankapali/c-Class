namespace calculator
{
    public partial class Form1 : Form
    {
        public int displayValue = Convert.ToInt32(display.Text);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "7";
            display.Text = data;
        }

        private void display_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "8";
            display.Text = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "9";
            display.Text = data;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "4";
            display.Text = data;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "5";
            display.Text = data;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "6";
            display.Text = data;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string data = display.Text;

            data = data + "1";
            display.Text = data;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "2";
            display.Text = data;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "3";
            display.Text = data;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "0";
            display.Text = data;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + ".";
            display.Text = data;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "+";
            display.Text = data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "/";
            display.Text = data;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "*";
            display.Text = data;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            data = data + "-";
            display.Text = data;
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Clear();
        }
    }
}