namespace ProjectoBBDD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.Enviar = new System.Windows.Forms.Button();
            this.Etiqueta_User = new System.Windows.Forms.Label();
            this.Etiqueta_Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Idioma = new System.Windows.Forms.Label();
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Idiomas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_a85839_appDataSet = new ProjectoBBDD.db_a85839_appDataSet();
            this.countryTableAdapter = new ProjectoBBDD.db_a85839_appDataSetTableAdapters.CountryTableAdapter();
            this.Select_Pais = new System.Windows.Forms.ComboBox();
            this.viewContryandContinentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_a85839_appDataSet1 = new ProjectoBBDD.db_a85839_appDataSet1();
            this.view_Contry_and_ContinentsTableAdapter = new ProjectoBBDD.db_a85839_appDataSet1TableAdapters.view_Contry_and_ContinentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewContryandContinentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Enviar
            // 
            this.Enviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Enviar.Location = new System.Drawing.Point(317, 401);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(108, 37);
            this.Enviar.TabIndex = 0;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Etiqueta_User
            // 
            this.Etiqueta_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Etiqueta_User.AutoSize = true;
            this.Etiqueta_User.Location = new System.Drawing.Point(17, 129);
            this.Etiqueta_User.Name = "Etiqueta_User";
            this.Etiqueta_User.Size = new System.Drawing.Size(43, 20);
            this.Etiqueta_User.TabIndex = 1;
            this.Etiqueta_User.Text = "User";
            this.Etiqueta_User.Click += new System.EventHandler(this.Etiqueta_User_Click);
            // 
            // Etiqueta_Email
            // 
            this.Etiqueta_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Etiqueta_Email.AutoSize = true;
            this.Etiqueta_Email.Location = new System.Drawing.Point(17, 173);
            this.Etiqueta_Email.Name = "Etiqueta_Email";
            this.Etiqueta_Email.Size = new System.Drawing.Size(48, 20);
            this.Etiqueta_Email.TabIndex = 2;
            this.Etiqueta_Email.Text = "Email";
            this.Etiqueta_Email.Click += new System.EventHandler(this.Etiqueta_Email_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(17, 215);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Idioma
            // 
            this.Idioma.AutoSize = true;
            this.Idioma.Location = new System.Drawing.Point(17, 264);
            this.Idioma.Name = "Idioma";
            this.Idioma.Size = new System.Drawing.Size(57, 20);
            this.Idioma.TabIndex = 4;
            this.Idioma.Text = "Idioma";
            this.Idioma.Click += new System.EventHandler(this.Idioma_Click);
            // 
            // Txt_User
            // 
            this.Txt_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_User.Location = new System.Drawing.Point(118, 123);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(616, 26);
            this.Txt_User.TabIndex = 5;
            this.Txt_User.TextChanged += new System.EventHandler(this.Txt_User_TextChanged);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Email.Location = new System.Drawing.Point(118, 167);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(616, 26);
            this.Txt_Email.TabIndex = 6;
            this.Txt_Email.TextChanged += new System.EventHandler(this.Txt_Email_TextChanged);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Password.Location = new System.Drawing.Point(118, 215);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(616, 26);
            this.Txt_Password.TabIndex = 7;
            this.Txt_Password.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            // 
            // Idiomas
            // 
            this.Idiomas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Idiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Idiomas.FormattingEnabled = true;
            this.Idiomas.Items.AddRange(new object[] {
            "Castellano",
            "Ingles"});
            this.Idiomas.Location = new System.Drawing.Point(118, 256);
            this.Idiomas.Name = "Idiomas";
            this.Idiomas.Size = new System.Drawing.Size(616, 28);
            this.Idiomas.TabIndex = 8;
            this.Idiomas.SelectedIndexChanged += new System.EventHandler(this.Idiomas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Country";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.db_a85839_appDataSet;
            // 
            // db_a85839_appDataSet
            // 
            this.db_a85839_appDataSet.DataSetName = "db_a85839_appDataSet";
            this.db_a85839_appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // Select_Pais
            // 
            this.Select_Pais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Select_Pais.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryBindingSource, "Name_Country", true));
            this.Select_Pais.DataSource = this.countryBindingSource;
            this.Select_Pais.DisplayMember = "Name_Country";
            this.Select_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Select_Pais.FormattingEnabled = true;
            this.Select_Pais.Location = new System.Drawing.Point(118, 297);
            this.Select_Pais.Name = "Select_Pais";
            this.Select_Pais.Size = new System.Drawing.Size(616, 28);
            this.Select_Pais.TabIndex = 12;
            this.Select_Pais.ValueMember = "Name_Country";
            // 
            // viewContryandContinentsBindingSource
            // 
            this.viewContryandContinentsBindingSource.DataMember = "view_Contry_and_Continents";
            this.viewContryandContinentsBindingSource.DataSource = this.db_a85839_appDataSet1;
            // 
            // db_a85839_appDataSet1
            // 
            this.db_a85839_appDataSet1.DataSetName = "db_a85839_appDataSet1";
            this.db_a85839_appDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_Contry_and_ContinentsTableAdapter
            // 
            this.view_Contry_and_ContinentsTableAdapter.ClearBeforeFill = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Select_Pais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Idiomas);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_User);
            this.Controls.Add(this.Idioma);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Etiqueta_Email);
            this.Controls.Add(this.Etiqueta_User);
            this.Controls.Add(this.Enviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "TeamworkNet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewContryandContinentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a85839_appDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Label Etiqueta_User;
        private System.Windows.Forms.Label Etiqueta_Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Idioma;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.ComboBox Idiomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private db_a85839_appDataSet db_a85839_appDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private db_a85839_appDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.ComboBox Select_Pais;
        private db_a85839_appDataSet1 db_a85839_appDataSet1;
        private System.Windows.Forms.BindingSource viewContryandContinentsBindingSource;
        private db_a85839_appDataSet1TableAdapters.view_Contry_and_ContinentsTableAdapter view_Contry_and_ContinentsTableAdapter;
    }
}