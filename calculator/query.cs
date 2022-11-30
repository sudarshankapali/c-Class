using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class query : Form
    {
        public query()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void query_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = idbox.Text;
            dataGridView1.Rows[n].Cells[1].Value = namebox.Text;
            dataGridView1.Rows[n].Cells[2].Value = addressbox.Text;
            dataGridView1.Rows[n].Cells[3].Value = contactbox.Text;
            dataGridView1.Rows[n].Cells[4].Value = collegebox.Text;

            
        }

        private void contactbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
