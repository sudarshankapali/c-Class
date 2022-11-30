using System.Data.SqlClient;

namespace calculator
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal result = 0;
        
        SqlConnection connec = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;
            initial catalog=bit3sem;
            user id=sa;
            password=kist@123;"
            );
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "7";

            }
            else
            {
                string data = display.Text;

                data = data + "7";
                display.Text = data;
            }
        }

        private void display_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "8";

            }
            else
            {
                string data = display.Text;

                data = data + "8";
                display.Text = data;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "9";

            }
            else
            {
                string data = display.Text;

                data = data + "9";
                display.Text = data;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "4";

            }
            else
            {
                string data = display.Text;

                data = data + "4";
                display.Text = data;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "5";

            }
            else
            {
                string data = display.Text;

                data = data + "5";
                display.Text = data;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "6";

            }
            else
            {
                string data = display.Text;

                data = data + "6";
                display.Text = data;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "1";

            }
            else
            {
                string data = display.Text;

                data = data + "1";
                display.Text = data;
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "2";

            }
            else
            {
                string data = display.Text;

                data = data + "2";
                display.Text = data;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "3";

            }
            else
            {
                string data = display.Text;

                data = data + "3";
                display.Text = data;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "/")
            {
                display.Text = "0";

            }
            else
            {
                string data = display.Text;

                data = data + "0";
                display.Text = data;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            string data = display.Text;
            data = data + ".";
            display.Text = data;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "+";
            display.Text = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "/";
            display.Text = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "*";
            display.Text = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "-";
            display.Text = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            decimal firstNumber = result;
            decimal secondNumber = Convert.ToDecimal(display.Text);
            switch (operate)
            {
                case "+":
                    {
                        result = firstNumber + secondNumber;
                        display.Text = result.ToString();
                    }
                    break;
                    case "-":
                    {
                        result = firstNumber - secondNumber;
                        display.Text = result.ToString();
                    }
                    break;
                case "*":
                    {
                        result = firstNumber * secondNumber;
                        display.Text= result.ToString();
                    }
                    break;
                case "/":
                    if(secondNumber == 0)
                    {
                        MessageBox.Show("invalid");
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        display.Text =result.ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Clear();
        }
        public void GetResultValue()
        {
            if (display.Text != "" && display.Text != "+" && display.Text != "-" && display.Text != "*" && display.Text !="/")
            {
                result = Convert.ToDecimal(display.Text);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            link newForm = new link();
            this.Hide();
            newForm.ShowDialog();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                connec.Open();
                string query = "insert into student(name,address,contact,college) values ('justinMaharjan','bhaktapur','9813919623','kist college')";
                SqlCommand cmd = new SqlCommand(query, connec);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saved sucessfully");
                connec.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: "+ ex.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            connec.Open();
            string query = "update student set name='bye' where id =2";
            SqlCommand cmd = new SqlCommand(query, connec);
            cmd.ExecuteNonQuery();
            MessageBox.Show("query updated sucessfully");
            connec.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            connec.Open();
            string query = "delete from student where id = 4";
            SqlCommand cmd = new SqlCommand(query, connec);
            cmd.ExecuteNonQuery();
            MessageBox.Show("query deleted sucessfully");
            connec.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            connec.Open();
            string query = "select * from student where id>=2";
            SqlCommand cmd = new SqlCommand(query, connec);
            cmd.ExecuteNonQuery();
            MessageBox.Show("selected saved sucessfully");
            connec.Close();
        }
    }
}