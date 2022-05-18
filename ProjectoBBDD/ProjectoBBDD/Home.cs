using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectoBBDD
{
    public partial class Home : Form
    {
        private Panel panel1;
        private Button Setting_btn;
        private Button Create_Project_btn;
        private Button Project_btn;
        private PictureBox pictureBox1;
        private TextBox Txt_User_Name;
        private Label Lowcarboneconomy;
        private Label Home_in;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button Home_btn;

        public Home()
        {

            InitializeComponent();
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";

            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            { conn.Open(); 
            }
            catch (Exception )
            { MessageBox.Show("Sorry, you could check your Connection"); }
           
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Users FROM dbo.Users WHERE email='" + Form1.Email() + "'", conn);
            
            DataTable dt = new DataTable(); 
           
            sda.Fill(dt);

                Txt_User_Name.Text = dt.Rows[0][0].ToString();
            contador();

        }
        public int contador()
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";

            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
            }
            catch (Exception)
            { MessageBox.Show("Sorry, you could check your Connection"); }


            SqlDataAdapter sda = new SqlDataAdapter("SELECT Contador FROM dbo.Contador WHERE ID_Contador='" + 1 + "'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            string contadorS=dt.Rows[0][0].ToString();
            int contador = Convert.ToInt32(contadorS);
            contador++;

            string update = "UPDATE dbo.Contador SET Contador='" + contador + "'WHERE ID_Contador='"+1+"'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            

            return contador;
        }
        
        private void Home_btn_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }

        private void Home_btn_Click_1(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();
        }

        private void Project_btn_Click(object sender, EventArgs e)
        {
            new Project().Show();
            this.Close();
        }

        private void Create_Project_btn_Click(object sender, EventArgs e)
        {
            new CreatreProject().Show();
           
        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {
            new Opciones().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Arbol().Show();
        }

        private void Txt_User_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lowcarboneconomy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Setting_btn = new System.Windows.Forms.Button();
            this.Create_Project_btn = new System.Windows.Forms.Button();
            this.Project_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Txt_User_Name = new System.Windows.Forms.TextBox();
            this.Home_in = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.Lowcarboneconomy);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Setting_btn);
            this.panel1.Controls.Add(this.Create_Project_btn);
            this.panel1.Controls.Add(this.Project_btn);
            this.panel1.Controls.Add(this.Home_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 433);
            this.panel1.TabIndex = 0;
            // 
            // Lowcarboneconomy
            // 
            this.Lowcarboneconomy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lowcarboneconomy.AutoSize = true;
            this.Lowcarboneconomy.Location = new System.Drawing.Point(3, 413);
            this.Lowcarboneconomy.Name = "Lowcarboneconomy";
            this.Lowcarboneconomy.Size = new System.Drawing.Size(0, 20);
            this.Lowcarboneconomy.TabIndex = 5;
            this.Lowcarboneconomy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = global::ProjectoBBDD.Properties.Resources.TeamWorkNet__2_;
            this.pictureBox1.ErrorImage = global::ProjectoBBDD.Properties.Resources.TeamWorkNet_Logo1;
            this.pictureBox1.InitialImage = global::ProjectoBBDD.Properties.Resources.TeamWorkNet__1_;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Setting_btn
            // 
            this.Setting_btn.Location = new System.Drawing.Point(13, 319);
            this.Setting_btn.Name = "Setting_btn";
            this.Setting_btn.Size = new System.Drawing.Size(198, 32);
            this.Setting_btn.TabIndex = 3;
            this.Setting_btn.Text = "Setting";
            this.Setting_btn.UseVisualStyleBackColor = true;
            this.Setting_btn.Click += new System.EventHandler(this.Setting_btn_Click);
            // 
            // Create_Project_btn
            // 
            this.Create_Project_btn.Location = new System.Drawing.Point(11, 278);
            this.Create_Project_btn.Name = "Create_Project_btn";
            this.Create_Project_btn.Size = new System.Drawing.Size(198, 35);
            this.Create_Project_btn.TabIndex = 2;
            this.Create_Project_btn.Text = "Create Project";
            this.Create_Project_btn.UseVisualStyleBackColor = true;
            this.Create_Project_btn.Click += new System.EventHandler(this.Create_Project_btn_Click);
            // 
            // Project_btn
            // 
            this.Project_btn.Location = new System.Drawing.Point(11, 236);
            this.Project_btn.Name = "Project_btn";
            this.Project_btn.Size = new System.Drawing.Size(198, 36);
            this.Project_btn.TabIndex = 1;
            this.Project_btn.Text = "Project";
            this.Project_btn.UseVisualStyleBackColor = true;
            this.Project_btn.Click += new System.EventHandler(this.Project_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(12, 191);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(199, 39);
            this.Home_btn.TabIndex = 0;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click_1);
            // 
            // Txt_User_Name
            // 
            this.Txt_User_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_User_Name.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Txt_User_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_User_Name.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_User_Name.Location = new System.Drawing.Point(500, 77);
            this.Txt_User_Name.Name = "Txt_User_Name";
            this.Txt_User_Name.ReadOnly = true;
            this.Txt_User_Name.Size = new System.Drawing.Size(226, 39);
            this.Txt_User_Name.TabIndex = 2;
            this.Txt_User_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_User_Name.TextChanged += new System.EventHandler(this.Txt_User_Name_TextChanged);
            // 
            // Home_in
            // 
            this.Home_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Home_in.AutoSize = true;
            this.Home_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_in.Location = new System.Drawing.Point(720, 12);
            this.Home_in.Name = "Home_in";
            this.Home_in.Size = new System.Drawing.Size(106, 37);
            this.Home_in.TabIndex = 4;
            this.Home_in.Text = "Home";
            this.Home_in.Click += new System.EventHandler(this.Home_in_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(247, 307);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(715, 64);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectoBBDD.Properties.Resources.Lowcarboneconomy__sin_fondo___1_;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(104, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(984, 433);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Home_in);
            this.Controls.Add(this.Txt_User_Name);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "TeamWorkNet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Etic_Home_Click(object sender, EventArgs e)
        {

        }

        private void Lowcarboneconmy2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.lowcarboneconomy.org/");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.lowcarboneconomy.org/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://heliotec.es/");
        }

        private void Home_in_Click(object sender, EventArgs e)
        {

        }
    }
}
