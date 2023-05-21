namespace Novin
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.viBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet9 = new Novin.AccountingDataSet9();
            this.viBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet8 = new Novin.AccountingDataSet8();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet7 = new Novin.AccountingDataSet7();
            this.viTableAdapter = new Novin.AccountingDataSet7TableAdapters.viTableAdapter();
            this.viTableAdapter1 = new Novin.AccountingDataSet8TableAdapters.viTableAdapter();
            this.searchid = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.viTableAdapter2 = new Novin.AccountingDataSet9TableAdapters.viTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet7)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viBindingSource2, "FirstName", true));
            this.comboBox2.DataSource = this.viBindingSource2;
            this.comboBox2.DisplayMember = "FirstName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox2.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.ItemHeight = 30;
            this.comboBox2.Location = new System.Drawing.Point(225, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(234, 38);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.ValueMember = "FirstName";
            // 
            // viBindingSource2
            // 
            this.viBindingSource2.DataMember = "vi";
            this.viBindingSource2.DataSource = this.accountingDataSet9;
            // 
            // accountingDataSet9
            // 
            this.accountingDataSet9.DataSetName = "AccountingDataSet9";
            this.accountingDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viBindingSource1
            // 
            this.viBindingSource1.DataMember = "vi";
            this.viBindingSource1.DataSource = this.accountingDataSet8;
            // 
            // accountingDataSet8
            // 
            this.accountingDataSet8.DataSetName = "AccountingDataSet8";
            this.accountingDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("B Titr", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(342, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 40);
            this.label3.TabIndex = 22;
            this.label3.Text = "مشخصات مشتری";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Image = global::Novin.Properties.Resources.Screenshot_2023_05_19_2030122;
            this.label6.Location = new System.Drawing.Point(666, 53);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(89, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "کد حساب:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Image = global::Novin.Properties.Resources.Screenshot_2023_05_19_2030122;
            this.label7.Location = new System.Drawing.Point(697, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 37);
            this.label7.TabIndex = 17;
            this.label7.Text = ":تاریخ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Image = global::Novin.Properties.Resources.Screenshot_2023_05_19_2030122;
            this.label5.Location = new System.Drawing.Point(469, 108);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(108, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "شماره تماس:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Image = global::Novin.Properties.Resources.Screenshot_2023_05_19_2030122;
            this.label4.Location = new System.Drawing.Point(456, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = ":نام خریدار";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Farnaz", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Image = global::Novin.Properties.Resources.Screenshot_2023_05_19_2030122;
            this.label2.Location = new System.Drawing.Point(376, -38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "طلای نوین";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Tan;
            this.label9.Location = new System.Drawing.Point(56, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(699, 51);
            this.label9.TabIndex = 14;
            this.label9.Text = " ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(59, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = " ";
            // 
            // viBindingSource
            // 
            this.viBindingSource.DataMember = "vi";
            this.viBindingSource.DataSource = this.accountingDataSet7;
            // 
            // accountingDataSet7
            // 
            this.accountingDataSet7.DataSetName = "AccountingDataSet7";
            this.accountingDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viTableAdapter
            // 
            this.viTableAdapter.ClearBeforeFill = true;
            // 
            // viTableAdapter1
            // 
            this.viTableAdapter1.ClearBeforeFill = true;
            // 
            // searchid
            // 
            this.searchid.BackColor = System.Drawing.SystemColors.Menu;
            this.searchid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchid.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.searchid.Location = new System.Drawing.Point(608, 53);
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(58, 38);
            this.searchid.TabIndex = 28;
            this.searchid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchid.TextChanged += new System.EventHandler(this.searchid_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viBindingSource2, "5", true));
            this.comboBox3.DataSource = this.viBindingSource2;
            this.comboBox3.DisplayMember = "5";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox3.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.ItemHeight = 30;
            this.comboBox3.Location = new System.Drawing.Point(348, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox3.Size = new System.Drawing.Size(125, 38);
            this.comboBox3.TabIndex = 24;
            this.comboBox3.ValueMember = "5";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "خروج";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, -82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "چاپ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "ذخیره";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viBindingSource2, "6", true));
            this.comboBox1.DataSource = this.viBindingSource2;
            this.comboBox1.DisplayMember = "6";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 30;
            this.comboBox1.Location = new System.Drawing.Point(608, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(91, 38);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "6";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viBindingSource2, "3", true));
            this.comboBox4.DataSource = this.viBindingSource2;
            this.comboBox4.DisplayMember = "3";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox4.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.ItemHeight = 30;
            this.comboBox4.Location = new System.Drawing.Point(477, 209);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox4.Size = new System.Drawing.Size(179, 38);
            this.comboBox4.TabIndex = 24;
            this.comboBox4.ValueMember = "3";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.viBindingSource2, "4", true));
            this.comboBox5.DataSource = this.viBindingSource2;
            this.comboBox5.DisplayMember = "4";
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox5.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.IntegralHeight = false;
            this.comboBox5.ItemHeight = 30;
            this.comboBox5.Location = new System.Drawing.Point(88, 210);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox5.Size = new System.Drawing.Size(168, 38);
            this.comboBox5.TabIndex = 24;
            this.comboBox5.ValueMember = "4";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Image = global::Novin.Properties.Resources.Screenshot_2023_05_19_2030122;
            this.label8.Location = new System.Drawing.Point(649, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 38);
            this.label8.TabIndex = 19;
            this.label8.Text = ":بدهکار ریال";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Info;
            this.label12.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Image = global::Novin.Properties.Resources.Screenshot_2023_05_19_2030122;
            this.label12.Location = new System.Drawing.Point(222, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 38);
            this.label12.TabIndex = 19;
            this.label12.Text = ":بستانکار ریال";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "چاپ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // viTableAdapter2
            // 
            this.viTableAdapter2.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Tan;
            this.label10.Font = new System.Drawing.Font("B Titr", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(342, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 40);
            this.label10.TabIndex = 22;
            this.label10.Text = "صورتحساب";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Tan;
            this.label11.Location = new System.Drawing.Point(-2, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 60);
            this.label11.TabIndex = 14;
            this.label11.Text = " ";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Novin.Properties.Resources.of_gold_gradient_gold_gradient_background_texture_metallic_illustration_for_luxury_frame_ribbon_banner_web_coin_and_label_elegant_light_and_shine_template_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 322);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchid);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet7)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource viBindingSource1;
        private AccountingDataSet8 accountingDataSet8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource viBindingSource;
        private AccountingDataSet7 accountingDataSet7;
        private AccountingDataSet7TableAdapters.viTableAdapter viTableAdapter;
        private AccountingDataSet8TableAdapters.viTableAdapter viTableAdapter1;
        private System.Windows.Forms.TextBox searchid;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private AccountingDataSet9 accountingDataSet9;
        private System.Windows.Forms.BindingSource viBindingSource2;
        private AccountingDataSet9TableAdapters.viTableAdapter viTableAdapter2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}