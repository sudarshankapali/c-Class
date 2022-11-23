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
            string data = userName.Text;
            string data1 = password.Text;
         /*   try
            {
                int age_input = Convert.ToInt32(age.Text);
                MessageBox.Show("age: ", age_input);
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid input");
            }*/
            if (data == "sudarshan" && data1 == "hello") 
            {
                for(int i = 0; i < 3; i++)
                {
                    MessageBox.Show(data);
                }
            }
            else
            {
                MessageBox.Show("404 ERROR");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userName.Text = "TEST";
        }
    }
}