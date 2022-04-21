namespace ProjectoBBDD
{
    partial class CreatreProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatreProject));
            this.Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NombreProjecto = new System.Windows.Forms.TextBox();
            this.Start_Date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_Start = new System.Windows.Forms.DateTimePicker();
            this.date_End = new System.Windows.Forms.DateTimePicker();
            this.Add_People_btm = new System.Windows.Forms.Button();
            this.Create_Project_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Creator_Project = new System.Windows.Forms.TextBox();
            this.txt_Project_Company = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(248, 40);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(356, 47);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Create Project";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name project";
            // 
            // txt_NombreProjecto
            // 
            this.txt_NombreProjecto.Location = new System.Drawing.Point(184, 172);
            this.txt_NombreProjecto.Name = "txt_NombreProjecto";
            this.txt_NombreProjecto.Size = new System.Drawing.Size(592, 26);
            this.txt_NombreProjecto.TabIndex = 2;
            // 
            // Start_Date
            // 
            this.Start_Date.AutoSize = true;
            this.Start_Date.Location = new System.Drawing.Point(12, 265);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(83, 20);
            this.Start_Date.TabIndex = 3;
            this.Start_Date.Text = "Start Date";
            this.Start_Date.Click += new System.EventHandler(this.Start_Date_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // date_Start
            // 
            this.date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Start.Location = new System.Drawing.Point(101, 260);
            this.date_Start.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.date_Start.Name = "date_Start";
            this.date_Start.Size = new System.Drawing.Size(317, 26);
            this.date_Start.TabIndex = 5;
            this.date_Start.Value = new System.DateTime(2022, 4, 21, 11, 27, 17, 0);
            // 
            // date_End
            // 
            this.date_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_End.Location = new System.Drawing.Point(518, 261);
            this.date_End.Name = "date_End";
            this.date_End.Size = new System.Drawing.Size(317, 26);
            this.date_End.TabIndex = 6;
            this.date_End.Value = new System.DateTime(2022, 4, 21, 0, 0, 0, 0);
            // 
            // Add_People_btm
            // 
            this.Add_People_btm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_People_btm.Location = new System.Drawing.Point(528, 330);
            this.Add_People_btm.Name = "Add_People_btm";
            this.Add_People_btm.Size = new System.Drawing.Size(307, 33);
            this.Add_People_btm.TabIndex = 7;
            this.Add_People_btm.Text = "Add people";
            this.Add_People_btm.UseVisualStyleBackColor = false;
            this.Add_People_btm.Click += new System.EventHandler(this.Add_People_btm_Click);
            // 
            // Create_Project_Btn
            // 
            this.Create_Project_Btn.Location = new System.Drawing.Point(548, 483);
            this.Create_Project_Btn.Name = "Create_Project_Btn";
            this.Create_Project_Btn.Size = new System.Drawing.Size(287, 39);
            this.Create_Project_Btn.TabIndex = 8;
            this.Create_Project_Btn.Text = "Create Project";
            this.Create_Project_Btn.UseVisualStyleBackColor = true;
            this.Create_Project_Btn.Click += new System.EventHandler(this.Create_Project_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = " Creator of the Project";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Project Company";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_Creator_Project
            // 
            this.txt_Creator_Project.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Creator_Project.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Creator_Project.Location = new System.Drawing.Point(64, 392);
            this.txt_Creator_Project.Name = "txt_Creator_Project";
            this.txt_Creator_Project.ReadOnly = true;
            this.txt_Creator_Project.Size = new System.Drawing.Size(235, 19);
            this.txt_Creator_Project.TabIndex = 12;
            // 
            // txt_Project_Company
            // 
            this.txt_Project_Company.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_Project_Company.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Project_Company.Location = new System.Drawing.Point(63, 461);
            this.txt_Project_Company.Name = "txt_Project_Company";
            this.txt_Project_Company.ReadOnly = true;
            this.txt_Project_Company.Size = new System.Drawing.Size(236, 19);
            this.txt_Project_Company.TabIndex = 13;
            this.txt_Project_Company.TextChanged += new System.EventHandler(this.txt_Project_Company_TextChanged);
            // 
            // CreatreProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(847, 534);
            this.Controls.Add(this.txt_Project_Company);
            this.Controls.Add(this.txt_Creator_Project);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Create_Project_Btn);
            this.Controls.Add(this.Add_People_btm);
            this.Controls.Add(this.date_End);
            this.Controls.Add(this.date_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Start_Date);
            this.Controls.Add(this.txt_NombreProjecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreatreProject";
            this.Text = "TeamworkNet";
            this.Load += new System.EventHandler(this.CreatreProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NombreProjecto;
        private System.Windows.Forms.Label Start_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_Start;
        private System.Windows.Forms.DateTimePicker date_End;
        private System.Windows.Forms.Button Add_People_btm;
        private System.Windows.Forms.Button Create_Project_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Creator_Project;
        internal System.Windows.Forms.TextBox txt_Project_Company;
    }
}