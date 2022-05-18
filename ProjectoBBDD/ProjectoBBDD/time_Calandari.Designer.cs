namespace ProjectoBBDD
{
    partial class time_Calandari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(time_Calandari));
            this.btn_Calendario = new System.Windows.Forms.Button();
            this.btn_Timesheet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Calendario
            // 
            this.btn_Calendario.Location = new System.Drawing.Point(75, 76);
            this.btn_Calendario.Name = "btn_Calendario";
            this.btn_Calendario.Size = new System.Drawing.Size(323, 230);
            this.btn_Calendario.TabIndex = 7;
            this.btn_Calendario.Text = "Calendar";
            this.btn_Calendario.UseVisualStyleBackColor = true;
            this.btn_Calendario.Click += new System.EventHandler(this.btn_Calendario_Click);
            // 
            // btn_Timesheet
            // 
            this.btn_Timesheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Timesheet.Location = new System.Drawing.Point(586, 76);
            this.btn_Timesheet.Name = "btn_Timesheet";
            this.btn_Timesheet.Size = new System.Drawing.Size(284, 230);
            this.btn_Timesheet.TabIndex = 8;
            this.btn_Timesheet.Text = "Timesheet";
            this.btn_Timesheet.UseVisualStyleBackColor = true;
            this.btn_Timesheet.Click += new System.EventHandler(this.btn_Timesheet_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(179, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(612, 82);
            this.button1.TabIndex = 9;
            this.button1.Text = "Setting Project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // time_Calandari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Timesheet);
            this.Controls.Add(this.btn_Calendario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "time_Calandari";
            this.Text = "time_Calandari";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Calendario;
        private System.Windows.Forms.Button btn_Timesheet;
        private System.Windows.Forms.Button button1;
    }
}