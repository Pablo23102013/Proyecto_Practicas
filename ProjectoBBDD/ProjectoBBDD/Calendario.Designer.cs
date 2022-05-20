namespace ProjectoBBDD
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            this.Lbproject = new System.Windows.Forms.Label();
            this.bt_Next = new System.Windows.Forms.Button();
            this.bt_Back = new System.Windows.Forms.Button();
            this.lUser = new System.Windows.Forms.Label();
            this.LMes = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.FlowLayoutPanel();
            this.LYear = new System.Windows.Forms.Label();
            this.LLunes = new System.Windows.Forms.Label();
            this.lMartes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Calendariopanel = new System.Windows.Forms.FlowLayoutPanel();
            this.db_a85839_appDataSet9 = new ProjectoBBDD.db_a85839_appDataSet9();
            this.calendarioViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendario_ViewTableAdapter = new ProjectoBBDD.db_a85839_appDataSet9TableAdapters.Calendario_ViewTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbproject
            // 
            this.Lbproject.AutoSize = true;
            this.Lbproject.Location = new System.Drawing.Point(42, 24);
            this.Lbproject.Name = "Lbproject";
            this.Lbproject.Size = new System.Drawing.Size(132, 20);
            this.Lbproject.TabIndex = 2;
            this.Lbproject.Text = "Texto_Provisional";
            this.Lbproject.Click += new System.EventHandler(this.Lbproject_Click);
            // 
            // bt_Next
            // 
            this.bt_Next.Location = new System.Drawing.Point(807, 635);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(94, 40);
            this.bt_Next.TabIndex = 3;
            this.bt_Next.Text = "Next>>>";
            this.bt_Next.UseVisualStyleBackColor = true;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // bt_Back
            // 
            this.bt_Back.Location = new System.Drawing.Point(637, 635);
            this.bt_Back.Name = "bt_Back";
            this.bt_Back.Size = new System.Drawing.Size(98, 39);
            this.bt_Back.TabIndex = 4;
            this.bt_Back.Text = "<<<Back";
            this.bt_Back.UseVisualStyleBackColor = true;
            this.bt_Back.Click += new System.EventHandler(this.bt_Back_Click);
            // 
            // lUser
            // 
            this.lUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(1468, 24);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(90, 20);
            this.lUser.TabIndex = 14;
            this.lUser.Text = "Name-User";
            this.lUser.Click += new System.EventHandler(this.lUser_Click);
            // 
            // LMes
            // 
            this.LMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LMes.AutoSize = true;
            this.LMes.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMes.Location = new System.Drawing.Point(3, 0);
            this.LMes.Name = "LMes";
            this.LMes.Size = new System.Drawing.Size(113, 41);
            this.LMes.TabIndex = 15;
            this.LMes.Text = "label6";
            this.LMes.Click += new System.EventHandler(this.lMes_Click);
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titulo.Controls.Add(this.LMes);
            this.Titulo.Controls.Add(this.LYear);
            this.Titulo.Location = new System.Drawing.Point(237, 98);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(557, 58);
            this.Titulo.TabIndex = 16;
            // 
            // LYear
            // 
            this.LYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LYear.AutoSize = true;
            this.LYear.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LYear.Location = new System.Drawing.Point(122, 0);
            this.LYear.Name = "LYear";
            this.LYear.Size = new System.Drawing.Size(113, 41);
            this.LYear.TabIndex = 16;
            this.LYear.Text = "label6";
            // 
            // LLunes
            // 
            this.LLunes.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLunes.Location = new System.Drawing.Point(56, 207);
            this.LLunes.Name = "LLunes";
            this.LLunes.Size = new System.Drawing.Size(104, 23);
            this.LLunes.TabIndex = 17;
            this.LLunes.Text = "Monday";
            this.LLunes.Click += new System.EventHandler(this.LLunes_Click);
            // 
            // lMartes
            // 
            this.lMartes.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMartes.Location = new System.Drawing.Point(196, 207);
            this.lMartes.Name = "lMartes";
            this.lMartes.Size = new System.Drawing.Size(102, 23);
            this.lMartes.TabIndex = 18;
            this.lMartes.Text = "Tuesday";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Wednesday";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thursday";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Friday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Saturday";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(803, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sunday";
            // 
            // Calendariopanel
            // 
            this.Calendariopanel.Location = new System.Drawing.Point(46, 227);
            this.Calendariopanel.Name = "Calendariopanel";
            this.Calendariopanel.Size = new System.Drawing.Size(886, 408);
            this.Calendariopanel.TabIndex = 24;
            // 
            // db_a85839_appDataSet9
            // 
            this.db_a85839_appDataSet9.DataSetName = "db_a85839_appDataSet9";
            this.db_a85839_appDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarioViewBindingSource
            // 
            this.calendarioViewBindingSource.DataMember = "Calendario_View";
            this.calendarioViewBindingSource.DataSource = this.db_a85839_appDataSet9;
            // 
            // calendario_ViewTableAdapter
            // 
            this.calendario_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(976, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(650, 408);
            this.dataGridView1.TabIndex = 25;
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 675);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Calendariopanel);
            this.Controls.Add(this.LLunes);
            this.Controls.Add(this.lMartes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.bt_Back);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.Lbproject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.Titulo.ResumeLayout(false);
            this.Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarioViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbproject;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.Button bt_Back;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label LMes;
        private System.Windows.Forms.FlowLayoutPanel Titulo;
        private System.Windows.Forms.Label LLunes;
        private System.Windows.Forms.Label lMartes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel Calendariopanel;
        private System.Windows.Forms.Label LYear;
        private db_a85839_appDataSet9 db_a85839_appDataSet9;
        private System.Windows.Forms.BindingSource calendarioViewBindingSource;
        private db_a85839_appDataSet9TableAdapters.Calendario_ViewTableAdapter calendario_ViewTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}