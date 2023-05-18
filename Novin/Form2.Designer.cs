namespace Novin
{
    partial class Form2
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.taBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet1 = new Novin.AccountingDataSet1();
            this.accountingDataSet = new Novin.AccountingDataSet();
            this.accountingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taTableAdapter = new Novin.AccountingDataSetTableAdapters.TaTableAdapter();
            this.taBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.taBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.taTableAdapter1 = new Novin.AccountingDataSet1TableAdapters.TaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.creditor = new System.Windows.Forms.TextBox();
            this.debit = new System.Windows.Forms.TextBox();
            this.callnumber = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // taBindingSource4
            // 
            this.taBindingSource4.DataMember = "Ta";
            this.taBindingSource4.DataSource = this.accountingDataSet1BindingSource;
            // 
            // accountingDataSet1BindingSource
            // 
            this.accountingDataSet1BindingSource.DataSource = this.accountingDataSet1;
            this.accountingDataSet1BindingSource.Position = 0;
            // 
            // accountingDataSet1
            // 
            this.accountingDataSet1.DataSetName = "AccountingDataSet1";
            this.accountingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "AccountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingDataSetBindingSource
            // 
            this.accountingDataSetBindingSource.DataSource = this.accountingDataSet;
            this.accountingDataSetBindingSource.Position = 0;
            // 
            // accountingDataSetBindingSource1
            // 
            this.accountingDataSetBindingSource1.DataSource = this.accountingDataSet;
            this.accountingDataSetBindingSource1.Position = 0;
            // 
            // taBindingSource
            // 
            this.taBindingSource.DataMember = "Ta";
            this.taBindingSource.DataSource = this.accountingDataSetBindingSource1;
            // 
            // taTableAdapter
            // 
            this.taTableAdapter.ClearBeforeFill = true;
            // 
            // taBindingSource1
            // 
            this.taBindingSource1.DataMember = "Ta";
            this.taBindingSource1.DataSource = this.accountingDataSetBindingSource;
            // 
            // taBindingSource2
            // 
            this.taBindingSource2.DataMember = "Ta";
            this.taBindingSource2.DataSource = this.accountingDataSet;
            // 
            // taBindingSource3
            // 
            this.taBindingSource3.DataMember = "Ta";
            this.taBindingSource3.DataSource = this.accountingDataSetBindingSource;
            // 
            // taTableAdapter1
            // 
            this.taTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(53, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(645, 41);
            this.button2.TabIndex = 55;
            this.button2.Text = "ثبت";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(230, 152);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(121, 37);
            this.label2.TabIndex = 52;
            this.label2.Text = "تاریخ  :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(215, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 53;
            this.label1.Text = "بستانکار ریال  :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(582, 152);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(116, 37);
            this.label4.TabIndex = 54;
            this.label4.Text = "بدهکار ریال  :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("B Titr", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(235, 94);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(116, 37);
            this.label3.TabIndex = 51;
            this.label3.Text = "شماره تماس:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(582, 94);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(116, 37);
            this.label5.TabIndex = 50;
            this.label5.Text = "نام حساب :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(582, 36);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(116, 39);
            this.label6.TabIndex = 49;
            this.label6.Text = "کد حساب  :";
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.BackColor = System.Drawing.SystemColors.ControlLight;
            this.date.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.date.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.date.Location = new System.Drawing.Point(53, 152);
            this.date.Multiline = true;
            this.date.Name = "date";
            this.date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date.Size = new System.Drawing.Size(177, 37);
            this.date.TabIndex = 46;
            // 
            // creditor
            // 
            this.creditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creditor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.creditor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.creditor.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.creditor.Location = new System.Drawing.Point(53, 38);
            this.creditor.Multiline = true;
            this.creditor.Name = "creditor";
            this.creditor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.creditor.Size = new System.Drawing.Size(162, 37);
            this.creditor.TabIndex = 47;
            // 
            // debit
            // 
            this.debit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.debit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.debit.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.debit.Location = new System.Drawing.Point(420, 152);
            this.debit.Multiline = true;
            this.debit.Name = "debit";
            this.debit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.debit.Size = new System.Drawing.Size(162, 37);
            this.debit.TabIndex = 48;
            // 
            // callnumber
            // 
            this.callnumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.callnumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.callnumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.callnumber.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.callnumber.Location = new System.Drawing.Point(53, 93);
            this.callnumber.Multiline = true;
            this.callnumber.Name = "callnumber";
            this.callnumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.callnumber.Size = new System.Drawing.Size(183, 38);
            this.callnumber.TabIndex = 45;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.BackColor = System.Drawing.Color.Gainsboro;
            this.name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(421, 94);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(161, 38);
            this.name.TabIndex = 44;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // code
            // 
            this.code.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.code.BackColor = System.Drawing.SystemColors.ControlLight;
            this.code.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.code.Font = new System.Drawing.Font("B Titr", 13F, System.Drawing.FontStyle.Bold);
            this.code.Location = new System.Drawing.Point(421, 36);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(161, 39);
            this.code.TabIndex = 43;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Novin.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date);
            this.Controls.Add(this.creditor);
            this.Controls.Add(this.debit);
            this.Controls.Add(this.callnumber);
            this.Controls.Add(this.name);
            this.Controls.Add(this.code);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource accountingDataSetBindingSource1;
        private AccountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource accountingDataSetBindingSource;
        private System.Windows.Forms.BindingSource taBindingSource;
        private AccountingDataSetTableAdapters.TaTableAdapter taTableAdapter;
        private System.Windows.Forms.BindingSource taBindingSource1;
        private System.Windows.Forms.BindingSource taBindingSource2;
        private System.Windows.Forms.BindingSource taBindingSource3;
        private System.Windows.Forms.BindingSource accountingDataSet1BindingSource;
        private AccountingDataSet1 accountingDataSet1;
        private System.Windows.Forms.BindingSource taBindingSource4;
        private AccountingDataSet1TableAdapters.TaTableAdapter taTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox creditor;
        private System.Windows.Forms.TextBox debit;
        private System.Windows.Forms.TextBox callnumber;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox code;
    }
}