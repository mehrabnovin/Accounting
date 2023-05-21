using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Novin
{
    public partial class Form3 : Form
    {
        string cs = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/database/Accounting.accdb";
        OleDbConnection con;
        OleDbDataAdapter adapt;
        DataTable dt;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(cs);
            con.Open();
            adapt = new OleDbDataAdapter("select * from vi", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection(cs);
            con.Open();
            adapt = new OleDbDataAdapter("select * from vi where id like '" + txt_SearchName.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

            con = new OleDbConnection(cs);
            con.Open();
            adapt = new OleDbDataAdapter("select * from vi where FirstName like '" + txt_SearchName.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            con = new OleDbConnection(cs);
            con.Open();
            adapt = new OleDbDataAdapter("select * from vi where id like '" + txt_SearchName.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            button1.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
