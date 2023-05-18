using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Novin
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountingDataSet5.vi' table. You can move, or remove it, as needed.
            this.viTableAdapter.Fill(this.accountingDataSet5.vi);
            // TODO: This line of code loads data into the 'accountingDataSet3.Ta' table. You can move, or remove it, as needed.
            this.taTableAdapter2.Fill(this.accountingDataSet3.Ta);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string addConn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:/database/Accounting.accdb";
            OleDbConnection conn = new OleDbConnection(addConn);
            string query = "SELECT * FROM [User] WHERE UserName LIKE '%' +@parametr+ '%'";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            
        }
    }
}
