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
    public partial class Project: Form
    {
        public static string projectID;
        public static int intID;
        public static List<Tuple<int, string>> list = new List<Tuple<int, string>>();
        public static string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
        public Project()
        {
            InitializeComponent();

           
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlDataAdapter sdan = new SqlDataAdapter("SELECT ID_User FROM dbo.Users WHERE email='" + Form1.Email() + "'", conn);

            DataTable dtn = new DataTable();

            sdan.Fill(dtn);

            string ID = dtn.Rows[0][0].ToString();
            int intID = int.Parse(ID);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(Name) FROM dbo.User_Project WHERE ID_User='" + intID + "'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            string ID3 = dt.Rows[0][0].ToString();
            int Tamano3 = int.Parse(ID3);

            textBox1.Text = "You are in " + Tamano3+ " projects";

            button();
        }

        private void Lowcarboneconmy2_Click(object sender, EventArgs e)
        {

        }

        

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.db_a85839_appDataSet5.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Setting_btn_Click(object sender, EventArgs e)
        {
            new Opciones().Show();
        }

        private void button()
        {
           
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlDataAdapter sdan = new SqlDataAdapter("SELECT ID_User FROM dbo.Users WHERE email='" + Form1.Email() + "'", conn);

            DataTable dtn = new DataTable();

            sdan.Fill(dtn);

            string ID = dtn.Rows[0][0].ToString();
            intID = int.Parse(ID);

            SqlDataAdapter sdan2 = new SqlDataAdapter("SELECT Name FROM dbo.User_Project WHERE ID_User='" + intID + "'", conn);

            DataTable dtn2 = new DataTable();
            sdan2.Fill(dtn2);
  

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(Name) FROM dbo.User_Project WHERE ID_User='" + intID + "'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            string ID2 = dt.Rows[0][0].ToString();
            int Tamano2 = int.Parse(ID2);
            if (dt.Rows[0][0].ToString() == "0")
            { 
                MessageBox.Show("You hasn't projects");

                Label lbl = new Label();
                lbl.Left = 45;
                lbl.Top = 20;
                lbl.AutoSize = true;
                
                lbl.Text = "TeamworkNet";
                lbl.Font=new Font(lbl.Font.Name,30);
                
                panel_2.Controls.Add(lbl);

            }
           else 
            {
                int posicion = 0;
                
                int posicio1 = 0;

                Point newLoc = new Point(5, 5);
                for(int i=0;i<Tamano2;i++)
                {
                    projectID = dtn2.Rows[posicio1][0].ToString();
                    
                    Button b=new Button();
                    b.AutoSize = true;
                    b.Text = dtn2.Rows[posicio1][0].ToString()+"  ID:"+posicio1;
                    
                    b.Location = newLoc;
                    // b.Click += new EventHandler(buttonclick);  

                    b.Margin = new Padding(3,3,3,3);
                    
                    posicion++;

                    if(posicion==3)
                    {
                        newLoc.Offset(-645,b.Width+15);
                        posicion = 0;
                    }
                    if(posicion==2)
                    {
                        newLoc.Offset(b.Height + 300, 0);
                    }
                    if (posicion==1)
                    {
                        newLoc.Offset(b.Height + 300, 0);
                    }
                    panel_2.Controls.Add(b);
                   
                    posicio1++;
                    list.Add(new Tuple<int, string>(posicio1,projectID));
                    lista(posicio1);
                }
                
            }
        }
        public int getintID()
        {
            int ID = intID;
            return ID;
        }
        public void lista(int select)
        {
            
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlDataAdapter sdan2 = new SqlDataAdapter("SELECT Name FROM dbo.User_Project WHERE ID_User='" + getintID() + "'", conn);

            DataTable dtn2 = new DataTable();
            sdan2.Fill(dtn2);
            int i = select;
            i--;
            string numero=txt_Project.Text;
            int nproject=int.Parse(numero);
            projectID = dtn2.Rows[nproject][0].ToString();
            conn.Close();
        }
        
        
        public static string getProject()
        {


            string project = projectID;
            return project;
        }
    
        protected void buttonclick(object sender,System.EventArgs e)
        {
            
            new time_Calandari().Show();
            
        }


        private void Lowcarboneconmy2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.lowcarboneconomy.org/");
        }

        private void Home_btn_Click(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button();
           button1.Click += new EventHandler(buttonclick);
            
        }
    }
}
