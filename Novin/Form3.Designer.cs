namespace Novin
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.accountingDataSet1 = new Novin.AccountingDataSet1();
            this.accountingDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taTableAdapter = new Novin.AccountingDataSet1TableAdapters.TaTableAdapter();
            this.taBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet2 = new Novin.AccountingDataSet2();
            this.taBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.taTableAdapter1 = new Novin.AccountingDataSet2TableAdapters.TaTableAdapter();
            this.taBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet3 = new Novin.AccountingDataSet3();
            this.taBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.taTableAdapter2 = new Novin.AccountingDataSet3TableAdapters.TaTableAdapter();
            this.accountingDataSet4 = new Novin.AccountingDataSet4();
            this.accountingDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Novin.AccountingDataSet2TableAdapters.TableAdapterManager();
            this.taBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet7 = new Novin.AccountingDataSet7();
            this.viBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingDataSet5 = new Novin.AccountingDataSet5();
            this.viTableAdapter = new Novin.AccountingDataSet5TableAdapters.viTableAdapter();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountingDataSet6 = new Novin.AccountingDataSet6();
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EmployeeTableAdapter = new Novin.AccountingDataSet6TableAdapters.tbl_EmployeeTableAdapter();
            this.viBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viTableAdapter1 = new Novin.AccountingDataSet7TableAdapters.viTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountingDataSet1
            // 
            this.accountingDataSet1.DataSetName = "AccountingDataSet1";
            this.accountingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingDataSet1BindingSource
            // 
            this.accountingDataSet1BindingSource.DataSource = this.accountingDataSet1;
            this.accountingDataSet1BindingSource.Position = 0;
            // 
            // taBindingSource
            // 
            this.taBindingSource.DataMember = "Ta";
            this.taBindingSource.DataSource = this.accountingDataSet1BindingSource;
            // 
            // taTableAdapter
            // 
            this.taTableAdapter.ClearBeforeFill = true;
            // 
            // taBindingSource1
            // 
            this.taBindingSource1.DataMember = "Ta";
            this.taBindingSource1.DataSource = this.accountingDataSet1BindingSource;
            // 
            // accountingDataSet2
            // 
            this.accountingDataSet2.DataSetName = "AccountingDataSet2";
            this.accountingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taBindingSource2
            // 
            this.taBindingSource2.DataMember = "Ta";
            this.taBindingSource2.DataSource = this.accountingDataSet2;
            // 
            // taTableAdapter1
            // 
            this.taTableAdapter1.ClearBeforeFill = true;
            // 
            // taBindingSource3
            // 
            this.taBindingSource3.DataMember = "Ta";
            this.taBindingSource3.DataSource = this.accountingDataSet2;
            // 
            // accountingDataSet3
            // 
            this.accountingDataSet3.DataSetName = "AccountingDataSet3";
            this.accountingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taBindingSource4
            // 
            this.taBindingSource4.DataMember = "Ta";
            this.taBindingSource4.DataSource = this.accountingDataSet3;
            // 
            // taTableAdapter2
            // 
            this.taTableAdapter2.ClearBeforeFill = true;
            // 
            // accountingDataSet4
            // 
            this.accountingDataSet4.DataSetName = "AccountingDataSet4";
            this.accountingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingDataSet4BindingSource
            // 
            this.accountingDataSet4BindingSource.DataSource = this.accountingDataSet4;
            this.accountingDataSet4BindingSource.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TaTableAdapter = this.taTableAdapter1;
            this.tableAdapterManager.UpdateOrder = Novin.AccountingDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taBindingSource5
            // 
            this.taBindingSource5.DataMember = "Ta";
            this.taBindingSource5.DataSource = this.accountingDataSet2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FirstName,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.viBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.Color.Gold;
            this.dataGridView1.Location = new System.Drawing.Point(-32, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 491);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // viBindingSource2
            // 
            this.viBindingSource2.DataMember = "vi";
            this.viBindingSource2.DataSource = this.accountingDataSet7;
            // 
            // accountingDataSet7
            // 
            this.accountingDataSet7.DataSetName = "AccountingDataSet7";
            this.accountingDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viBindingSource
            // 
            this.viBindingSource.DataMember = "vi";
            this.viBindingSource.DataSource = this.accountingDataSet5;
            // 
            // accountingDataSet5
            // 
            this.accountingDataSet5.DataSetName = "AccountingDataSet5";
            this.accountingDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viTableAdapter
            // 
            this.viTableAdapter.ClearBeforeFill = true;
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchName.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_SearchName.Location = new System.Drawing.Point(627, 79);
            this.txt_SearchName.Multiline = true;
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(179, 34);
            this.txt_SearchName.TabIndex = 3;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(669, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "جستجو با نام";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountingDataSet6
            // 
            this.accountingDataSet6.DataSetName = "AccountingDataSet6";
            this.accountingDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeBindingSource
            // 
            this.tblEmployeeBindingSource.DataMember = "tbl_Employee";
            this.tblEmployeeBindingSource.DataSource = this.accountingDataSet6;
            // 
            // tbl_EmployeeTableAdapter
            // 
            this.tbl_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // viBindingSource1
            // 
            this.viBindingSource1.DataMember = "vi";
            this.viBindingSource1.DataSource = this.accountingDataSet7;
            // 
            // viTableAdapter1
            // 
            this.viTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(674, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "کد حساب";
            this.Column1.Name = "Column1";
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "FirstName";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FirstName.HeaderText = "نام حساب";
            this.FirstName.Name = "FirstName";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "3";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "بدهکار ریال";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "4";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "بستانکار ریال";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "5";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn5.HeaderText = "شماره تماس";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "6";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Novin.Properties.Resources.d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SearchName);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource accountingDataSet1BindingSource;
        private AccountingDataSet1 accountingDataSet1;
        private System.Windows.Forms.BindingSource taBindingSource;
        private AccountingDataSet1TableAdapters.TaTableAdapter taTableAdapter;
        private System.Windows.Forms.BindingSource taBindingSource1;
        private AccountingDataSet2 accountingDataSet2;
        private System.Windows.Forms.BindingSource taBindingSource2;
        private AccountingDataSet2TableAdapters.TaTableAdapter taTableAdapter1;
        private System.Windows.Forms.BindingSource taBindingSource3;
        private AccountingDataSet3 accountingDataSet3;
        private System.Windows.Forms.BindingSource taBindingSource4;
        private AccountingDataSet3TableAdapters.TaTableAdapter taTableAdapter2;
        private System.Windows.Forms.BindingSource accountingDataSet4BindingSource;
        private AccountingDataSet4 accountingDataSet4;
        private AccountingDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource taBindingSource5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AccountingDataSet5 accountingDataSet5;
        private System.Windows.Forms.BindingSource viBindingSource;
        private AccountingDataSet5TableAdapters.viTableAdapter viTableAdapter;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.Label label1;
        private AccountingDataSet6 accountingDataSet6;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private AccountingDataSet6TableAdapters.tbl_EmployeeTableAdapter tbl_EmployeeTableAdapter;
        private AccountingDataSet7 accountingDataSet7;
        private System.Windows.Forms.BindingSource viBindingSource1;
        private AccountingDataSet7TableAdapters.viTableAdapter viTableAdapter1;
        private System.Windows.Forms.BindingSource viBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}