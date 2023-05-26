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
            this.SelectAllRecords();
        }

        public void SelectAllRecords()
        {

            OleDbConnection OleDbConnection1 = new OleDbConnection(cs);
            OleDbCommand OleDbCommand1 = new OleDbCommand();
            OleDbCommand1.CommandType = CommandType.Text;
            OleDbCommand1.CommandText = "SELECT * FROM vi";
            OleDbCommand1.Connection = OleDbConnection1;
            OleDbDataAdapter adapter = new OleDbDataAdapter(OleDbCommand1);
            DataSet DataSet1 = new DataSet();
            adapter.Fill(DataSet1, "vi");
            dataGridView1.DataSource = DataSet1.Tables["vi"];
            dataGridView1.Columns[0].HeaderText = "شناسه";
            dataGridView1.Columns[1].HeaderText = "نام";
            dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[3].HeaderText = "سن";
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                this.txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.deb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.cre.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.num.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.date.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {

                string currentPersonId = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                OleDbConnection OleDbConnection1 = new OleDbConnection(cs);
                OleDbCommand OleDbCommand1 = new OleDbCommand(cs);
                OleDbCommand1.Connection = OleDbConnection1;
                OleDbCommand1.CommandText = "UPDATE vi SET FirstName=@Name,3=@deb,4=@cre,5=@num,6=@date WHERE id = @Id";
                OleDbCommand1.Parameters.AddWithValue("@Name", this.txtname.Text);
                OleDbCommand1.Parameters.AddWithValue("@deb", this.deb.Text);
                OleDbCommand1.Parameters.AddWithValue("@cre", this.cre.Text);
                OleDbCommand1.Parameters.AddWithValue("@num", this.cre.Text);
                OleDbCommand1.Parameters.AddWithValue("@date", this.num.Text);
                OleDbCommand1.Parameters.AddWithValue("@cre", this.date.Text);
                OleDbCommand1.Parameters.AddWithValue("@Id", currentPersonId);
                OleDbConnection1.Open();
                int result = OleDbCommand1.ExecuteNonQuery();
                OleDbConnection1.Close();

                if (result > 0)
                {
                    MessageBox.Show("به روزرسانی شد");
                    SelectAllRecords();
                }
                else
                {
                    MessageBox.Show("عملیات با خطا مواجه شد");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.Rows.Count > 0)
            {
                string currentPersonId = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                OleDbConnection OleDbConnection1 = new OleDbConnection(cs);
                OleDbCommand OleDbCommand1 = new OleDbCommand();
                OleDbCommand1.Connection = OleDbConnection1;
                OleDbCommand1.CommandType = CommandType.Text;
                OleDbCommand1.CommandText = "DELETE FROM vi WHERE id=" + currentPersonId;
                OleDbConnection1.Open();
                MessageBox.Show("آیا از خروج مطمئن هستید؟!", "پیام برای کاربر", MessageBoxButtons.OKCancel);
                int result = OleDbCommand1.ExecuteNonQuery();
                OleDbConnection1.Close();
                if (result > 0)
                {
                    MessageBox.Show("حذف شد");
                    SelectAllRecords();
                }
                else
                {
                    MessageBox.Show("عملیات انجام نشد");
                }
            }
        }
    }
}
