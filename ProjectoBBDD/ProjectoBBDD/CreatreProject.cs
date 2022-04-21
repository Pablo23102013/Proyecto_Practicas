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

            string name = txt_NombreProjecto.Text;
            string data_inicio = date_Start.Text;
            string data_fin = date_End.Text;

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM dbo.Projects WHERE Name='" + name + "' ", conn);
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
                    SqlDataAdapter sdan = new SqlDataAdapter("SELECT Users FROM dbo.Users WHERE email='" + Form1.Email() + "'", conn);

                    DataTable dtn = new DataTable();

                    sdan.Fill(dtn);

                    string Dueño = dtn.Rows[0][0].ToString();

                    string Query = "INSERT INTO dbo.Projects(Name,Start_Date,End_Date,ID_User_1)VALUES('" + name + "','" + data_inicio + "','" + data_fin + "','" + Dueño + "')";

                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Proyecto Registrado");
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
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
    }

}
