using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;
            initial catalog=bit3sem;
            user id=sa;
            password=kist@123;"
            );

        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "select * from employee";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           // dataGridView1.DataSource = dt;
            int  sn =1;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string std_name = dt.Rows[i]["id"].ToString();
                string std_address = dt.Rows[i]["name"].ToString();  
                string std_contact = dt.Rows[i]["address"].ToString();
                string std_college = dt.Rows[i]["salary"].ToString();
                dataGridView2.Rows.Add(sn++,std_name,std_address,std_contact,std_college);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            int id = Int32.Parse(textBox1.Text);
            int salary = Int32.Parse(textBox4.Text);
            string query = " update employee set name= '"+textBox2.Text+"', address= '"+textBox3.Text+"',salary ='"+textBox4.Text+"' where id = "+id+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated sucessfully");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView2.Rows.Add();
            dataGridView2.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView2.Rows[n].Cells[1].Value = textBox2.Text;
            dataGridView2.Rows[n].Cells[2].Value = textBox3.Text;
            dataGridView2.Rows[n].Cells[3].Value = textBox4.Text;
            int id = Int32.Parse(textBox1.Text);
            int salary = Int32.Parse(textBox4.Text);
            conn.Open();
            string query = "insert into employee(id,name,address,salary) values (" + id + ",'"+textBox2.Text+"','"+textBox3.Text+"',"+salary+")";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted sucessfully");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBox1.Text);
            conn.Open();
            string query = " delete from employee where id = "+id+"";
            SqlCommand cmd = new SqlCommand(query,conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted sucessfully");
            MessageBox.Show("Data deleted sucessfully");
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
