namespace ProjectoBBDD
{
    partial class PeopleAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.db_a85839_appDataSet = new ProjectoBBDD.db_a85839_appDataSet();
            this.dba85839appDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new ProjectoBBDD.db_a85839_appDataSetTableAdapters.CountryTableAdapter();
            this.db_a85839_appDataSet2 = new ProjectoBBDD.db_a85839_appDataSet2();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new ProjectoBBDD.db_a85839_appDataSet2TableAdapters.UsersTableAdapter();
            this.db_a85839_appDataSet3 = new ProjectoBBDD.db_a85839_appDataSet3();
            this.viewUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_UsersTableAdapter = new ProjectoBBDD.db_a85839_appDataSet3TableAdapters.view_UsersTableAdapter();
            this.button_share = new System.Windows.Forms.Button();
            this.txt_Id_Share = new System.Windows.Forms.TextBox();
            this.Text_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Company = new System.Windows.Forms.TextBox();
            this.viewUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_a85839_appDataSet4 = new ProjectoBBDD.db_a85839_appDataSet4();
            this.kBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new ProjectoBBDD.db_a85839_appDataSet4TableAdapters.UsersTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dba85839appDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(114, 50);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(282, 26);
            this.txt_Name.TabIndex = 3;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // db_a85839_appDataSet
            // 
            this.db_a85839_appDataSet.DataSetName = "db_a85839_appDataSet";
            this.db_a85839_appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dba85839appDataSetBindingSource
            // 
            this.dba85839appDataSetBindingSource.DataSource = this.db_a85839_appDataSet;
            this.dba85839appDataSetBindingSource.Position = 0;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.dba85839appDataSetBindingSource;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // db_a85839_appDataSet2
            // 
            this.db_a85839_appDataSet2.DataSetName = "db_a85839_appDataSet2";
            this.db_a85839_appDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.db_a85839_appDataSet2;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // db_a85839_appDataSet3
            // 
            this.db_a85839_appDataSet3.DataSetName = "db_a85839_appDataSet3";
            this.db_a85839_appDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewUsersBindingSource
            // 
            this.viewUsersBindingSource.DataMember = "view_Users";
            this.viewUsersBindingSource.DataSource = this.db_a85839_appDataSet3;
            // 
            // view_UsersTableAdapter
            // 
            this.view_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // button_share
            // 
            this.button_share.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_share.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_share.ForeColor = System.Drawing.Color.Red;
            this.button_share.Location = new System.Drawing.Point(672, 417);
            this.button_share.Name = "button_share";
            this.button_share.Size = new System.Drawing.Size(183, 38);
            this.button_share.TabIndex = 16;
            this.button_share.Text = "SHARE";
            this.button_share.UseVisualStyleBackColor = false;
            this.button_share.Click += new System.EventHandler(this.button_share_Click);
            // 
            // txt_Id_Share
            // 
            this.txt_Id_Share.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Id_Share.Location = new System.Drawing.Point(635, 373);
            this.txt_Id_Share.Name = "txt_Id_Share";
            this.txt_Id_Share.Size = new System.Drawing.Size(249, 26);
            this.txt_Id_Share.TabIndex = 17;
            this.txt_Id_Share.TextChanged += new System.EventHandler(this.txt_Id_Share_TextChanged);
            // 
            // Text_ID
            // 
            this.Text_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_ID.AutoSize = true;
            this.Text_ID.Location = new System.Drawing.Point(633, 350);
            this.Text_ID.Name = "Text_ID";
            this.Text_ID.Size = new System.Drawing.Size(251, 20);
            this.Text_ID.TabIndex = 18;
            this.Text_ID.Text = "Put the ID_User for Share Proyect";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Company";
            // 
            // txt_Company
            // 
            this.txt_Company.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Company.Location = new System.Drawing.Point(501, 116);
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.Size = new System.Drawing.Size(383, 26);
            this.txt_Company.TabIndex = 20;
            this.txt_Company.TextChanged += new System.EventHandler(this.txt_Company_TextChanged);
            // 
            // viewUsersBindingSource1
            // 
            this.viewUsersBindingSource1.DataMember = "view_Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUserDataGridViewTextBoxColumn,
            this.usersDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.Company});
            this.dataGridView1.DataSource = this.usersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(52, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(560, 214);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // iDUserDataGridViewTextBoxColumn
            // 
            this.iDUserDataGridViewTextBoxColumn.DataPropertyName = "ID_User";
            this.iDUserDataGridViewTextBoxColumn.HeaderText = "ID_User";
            this.iDUserDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDUserDataGridViewTextBoxColumn.Name = "iDUserDataGridViewTextBoxColumn";
            this.iDUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUserDataGridViewTextBoxColumn.Width = 105;
            // 
            // usersDataGridViewTextBoxColumn
            // 
            this.usersDataGridViewTextBoxColumn.DataPropertyName = "Users";
            this.usersDataGridViewTextBoxColumn.HeaderText = "Users";
            this.usersDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usersDataGridViewTextBoxColumn.Name = "usersDataGridViewTextBoxColumn";
            this.usersDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersDataGridViewTextBoxColumn.Width = 87;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 84;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 8;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 112;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.db_a85839_appDataSet4;
            // 
            // db_a85839_appDataSet4
            // 
            this.db_a85839_appDataSet4.DataSetName = "db_a85839_appDataSet4";
            this.db_a85839_appDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DisplayMember = "Name_Country";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(501, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "Name_Country";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PeopleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 467);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Company);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Text_ID);
            this.Controls.Add(this.txt_Id_Share);
            this.Controls.Add(this.button_share);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeopleAdd";
            this.Text = "TeamWorkNet";
            this.Load += new System.EventHandler(this.PeopleAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dba85839appDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dba85839appDataSetBindingSource;
        private db_a85839_appDataSet db_a85839_appDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private db_a85839_appDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private db_a85839_appDataSet2 db_a85839_appDataSet2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private db_a85839_appDataSet2TableAdapters.UsersTableAdapter usersTableAdapter;
        private db_a85839_appDataSet3 db_a85839_appDataSet3;
        private System.Windows.Forms.BindingSource viewUsersBindingSource;
        private db_a85839_appDataSet3TableAdapters.view_UsersTableAdapter view_UsersTableAdapter;
        private System.Windows.Forms.Button button_share;
        private System.Windows.Forms.TextBox txt_Id_Share;
        private System.Windows.Forms.Label Text_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Company;
       
        private System.Windows.Forms.BindingSource viewUsersBindingSource1;
        
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kBindingSource;
        private db_a85839_appDataSet4 db_a85839_appDataSet4;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private db_a85839_appDataSet4TableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}