namespace Proyecto
{
    partial class Control
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Registro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Registro
            // 
            this.button_Registro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Registro.Location = new System.Drawing.Point(644, 378);
            this.button_Registro.Name = "button_Registro";
            this.button_Registro.Size = new System.Drawing.Size(112, 34);
            this.button_Registro.TabIndex = 0;
            this.button_Registro.Text = "Registro";
            this.button_Registro.UseVisualStyleBackColor = true;
            this.button_Registro.Click += new System.EventHandler(this.button_Registro_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Registro);
            this.Name = "Control";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_Registro;
    }
}