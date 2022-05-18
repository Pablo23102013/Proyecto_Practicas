namespace ProjectoBBDD
{
    partial class VentanaCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaCalendario));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Color = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtEnviar = new System.Windows.Forms.Button();
            this.txt_Event = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.time_end = new System.Windows.Forms.DateTimePicker();
            this.Time_start = new System.Windows.Forms.DateTimePicker();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.date_Start = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Color);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtEnviar);
            this.panel1.Controls.Add(this.txt_Event);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.time_end);
            this.panel1.Controls.Add(this.Time_start);
            this.panel1.Controls.Add(this.end_date);
            this.panel1.Controls.Add(this.date_Start);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 395);
            this.panel1.TabIndex = 0;
            // 
            // bt_Color
            // 
            this.bt_Color.Location = new System.Drawing.Point(146, 192);
            this.bt_Color.Name = "bt_Color";
            this.bt_Color.Size = new System.Drawing.Size(72, 30);
            this.bt_Color.TabIndex = 28;
            this.bt_Color.Text = "Color";
            this.bt_Color.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Color";
            // 
            // BtEnviar
            // 
            this.BtEnviar.Location = new System.Drawing.Point(502, 338);
            this.BtEnviar.Name = "BtEnviar";
            this.BtEnviar.Size = new System.Drawing.Size(167, 33);
            this.BtEnviar.TabIndex = 26;
            this.BtEnviar.Text = "Enviar";
            this.BtEnviar.UseVisualStyleBackColor = true;
            // 
            // txt_Event
            // 
            this.txt_Event.Location = new System.Drawing.Point(146, 24);
            this.txt_Event.Name = "txt_Event";
            this.txt_Event.Size = new System.Drawing.Size(495, 26);
            this.txt_Event.TabIndex = 25;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(146, 245);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(524, 76);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // time_end
            // 
            this.time_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_end.Location = new System.Drawing.Point(327, 132);
            this.time_end.Name = "time_end";
            this.time_end.Size = new System.Drawing.Size(200, 26);
            this.time_end.TabIndex = 23;
            // 
            // Time_start
            // 
            this.Time_start.CustomFormat = "";
            this.Time_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Time_start.Location = new System.Drawing.Point(327, 68);
            this.Time_start.Name = "Time_start";
            this.Time_start.Size = new System.Drawing.Size(200, 26);
            this.Time_start.TabIndex = 22;
            // 
            // end_date
            // 
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date.Location = new System.Drawing.Point(146, 128);
            this.end_date.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(140, 26);
            this.end_date.TabIndex = 21;
            this.end_date.Value = new System.DateTime(2022, 5, 8, 0, 0, 0, 0);
            // 
            // date_Start
            // 
            this.date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Start.Location = new System.Drawing.Point(146, 68);
            this.date_Start.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.date_Start.Name = "date_Start";
            this.date_Start.Size = new System.Drawing.Size(140, 26);
            this.date_Start.TabIndex = 20;
            this.date_Start.Value = new System.DateTime(2022, 5, 8, 0, 0, 0, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(557, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "All Day";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripton";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Event";
            // 
            // VentanaCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 385);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaCalendario";
            this.Text = "TeamworkNet";
            this.Load += new System.EventHandler(this.VentanaCalendario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtEnviar;
        private System.Windows.Forms.TextBox txt_Event;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker time_end;
        private System.Windows.Forms.DateTimePicker Time_start;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker date_Start;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}