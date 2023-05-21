using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novin
{
    public partial class Form1 : Form
    {
        string user = "novin";
        string passwd = "novin";
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            label4.Text = DateTime.Now.ToString("dd/MM/yyyy");//tarikh feli ro mide
            label3.Text = DateTime.Now.ToString("HH:mm:ss tt");
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 800;
            timer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss tt");//zaman ro mide
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text == "a")
            {
                    Form objform = new Form6();
                    objform.Show();
                textBox1.Clear();
                textBox2.Clear();

            }
           else
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "پیام برای کاربر");
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
