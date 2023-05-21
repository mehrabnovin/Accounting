﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace Novin
{
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
        }
        string cs = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/database/Accounting.accdb";
        OleDbConnection con;
        OleDbDataAdapter adapt;
        DataTable dt;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(cs);
            con.Open();
            adapt = new OleDbDataAdapter("select * from vi", con);
            dt = new DataTable();
            adapt.Fill(dt);
            comboBox2.DataSource = dt;
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchid_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection(cs);
            con.Open();
            adapt = new OleDbDataAdapter("select * from vi where id like '" + searchid.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox3.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            memoryImage.Save(Application.StartupPath + @"\image.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument myPrintDocument2 = new System.Drawing.Printing.PrintDocument();

            PrintDialog myPrinDialog2 = new PrintDialog();

            myPrintDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument2_PrintPage);

            myPrinDialog2.Document = myPrintDocument2;



            if (myPrinDialog2.ShowDialog() == DialogResult.OK)
            {

                myPrintDocument2.Print();

            }
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap myBitmap2 = new Bitmap(this.Width, this.Height);

            this.DrawToBitmap(myBitmap2, new Rectangle(0, 0, this.Width, this.Height));

            e.Graphics.DrawImage(myBitmap2, 0, 0);

            myBitmap2.Dispose();
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
