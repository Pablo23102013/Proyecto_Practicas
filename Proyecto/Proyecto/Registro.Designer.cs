namespace Proyecto
{
    partial class Registro
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
            this.titulo = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.t_Password = new System.Windows.Forms.TextBox();
            this.Idiomas = new System.Windows.Forms.Label();
            this.s_Idioma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(338, 50);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(169, 54);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Registro";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_User
            // 
            this.label_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_User.AutoSize = true;
            this.label_User.BackColor = System.Drawing.Color.Transparent;
            this.label_User.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_User.Location = new System.Drawing.Point(95, 147);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(61, 32);
            this.label_User.TabIndex = 1;
            this.label_User.Text = "User";
            this.label_User.Click += new System.EventHandler(this.label_User_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(202, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Enviar
            // 
            this.button_Enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Enviar.Location = new System.Drawing.Point(375, 382);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(112, 34);
            this.button_Enviar.TabIndex = 3;
            this.button_Enviar.Text = "Enviar";
            this.button_Enviar.UseVisualStyleBackColor = true;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Email.Location = new System.Drawing.Point(202, 208);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(506, 31);
            this.textBox_Email.TabIndex = 5;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contraseña.Location = new System.Drawing.Point(22, 267);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(134, 32);
            this.Contraseña.TabIndex = 7;
            this.Contraseña.Text = "Contraseña";
            // 
            // t_Password
            // 
            this.t_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Password.Location = new System.Drawing.Point(202, 277);
            this.t_Password.Name = "t_Password";
            this.t_Password.Size = new System.Drawing.Size(506, 31);
            this.t_Password.TabIndex = 8;
            // 
            // Idiomas
            // 
            this.Idiomas.AutoSize = true;
            this.Idiomas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Idiomas.Location = new System.Drawing.Point(69, 336);
            this.Idiomas.Name = "Idiomas";
            this.Idiomas.Size = new System.Drawing.Size(87, 32);
            this.Idiomas.TabIndex = 10;
            this.Idiomas.Text = "Idioma";
            // 
            // s_Idioma
            // 
            this.s_Idioma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s_Idioma.FormattingEnabled = true;
            this.s_Idioma.Items.AddRange(new object[] {
            "Castellano",
            "English"});
            this.s_Idioma.Location = new System.Drawing.Point(202, 334);
            this.s_Idioma.Name = "s_Idioma";
            this.s_Idioma.Size = new System.Drawing.Size(506, 33);
            this.s_Idioma.TabIndex = 11;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.s_Idioma);
            this.Controls.Add(this.Idiomas);
            this.Controls.Add(this.t_Password);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Enviar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.titulo);
            this.Name = "Registro";
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titulo;
        private Label label_User;
        private TextBox textBox1;
        private Button button_Enviar;
        private Label label1;
        private TextBox textBox_Email;
        private Label Contraseña;
        private TextBox t_Password;
        private Label Idiomas;
        private ComboBox s_Idioma;
    }
}