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
    public partial class CreatreProject : Form
    {
        public static string name_;
        public static string data_inicio;
        public static string data_fin;
        public static int intDueño;
        public CreatreProject()
        {
            InitializeComponent();
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Company FROM dbo.Users WHERE email='" + Form1.Email() + "'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            txt_Creator_Project.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Company FROM dbo.Users WHERE email='" + Form1.Email() + "'", conn);

            DataTable dt2 = new DataTable();

            sda2.Fill(dt2);

            txt_Project_Company.Text = dt2.Rows[0][0].ToString();

            date_Start.Value = DateTime.Today;
            date_End.Value = DateTime.Today.AddMonths(3);
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Start_Date_Click(object sender, EventArgs e)
        {

        }
        

        private void Create_Project_Btn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

             name_ = txt_NombreProjecto.Text;
             data_inicio = date_Start.Text;
             data_fin = date_End.Text;

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM dbo.Projects WHERE Name='" + name_ + "' ", conn);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("This name is already registered😔");
            }

            else
            {

                try
                {
                    SqlDataAdapter sdan = new SqlDataAdapter("SELECT ID_User FROM dbo.Users WHERE email='" + Form1.Email() + "'", conn);

                    DataTable dtn = new DataTable();

                    sdan.Fill(dtn);

                    string Dueño = dtn.Rows[0][0].ToString();
                    intDueño = int.Parse(Dueño);



                    string Query = "INSERT INTO dbo.Projects(Name,Start_Date,End_Date)VALUES('" + name_ + "','" + data_inicio + "','" + data_fin + "')";

                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter sdan2 = new SqlDataAdapter("SELECT ID_Project FROM dbo.Projects WHERE Name='" + GetName() + "'", conn);
                    DataTable dtn2 = new DataTable();
                    sdan2.Fill(dtn2);

                    string Pro = dtn2.Rows[0][0].ToString();
                    int Project = int.Parse(Pro);

                   

                    string Query2 = "INSERT INTO dbo.User_Project(ID_User,Name,Start_Date,End_Date,ID_Project)VALUES('" + intDueño + "','" + GetName() + "','" + GetDateStart() + "','" + GetDateEnd() + "','" + Project + "')";

                    SqlCommand cmd2 = new SqlCommand(Query2, conn);
                    cmd2.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Proyecto Registrado");

                    
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }
        public static string GetName()
        {
            string Name = name_ ;
            return Name;
        }
        public static string GetDateStart()
        {
            string D_Start = data_inicio;
            return D_Start;
        }
        public static string GetDateEnd()
        {
            string D_End = data_fin;
            return D_End;
        }
        public static int id_user ()
        {
            int Dueño_int = intDueño;

            return Dueño_int;
        }
        private void CreatreProject_Load(object sender, EventArgs e)
        {

        }

        private void Add_People_btm_Click(object sender, EventArgs e)
        {
            new PeopleAdd().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_Project_Company_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Creator_Project_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_End_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_Start_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
