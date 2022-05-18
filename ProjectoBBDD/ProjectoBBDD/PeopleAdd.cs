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
    public partial class PeopleAdd : Form
    {
        public static int intProject; 
        public PeopleAdd()
        {
            InitializeComponent();
            cargar_datos();
        }

        private void PeopleAdd_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_a85839_appDataSet4.Users' Puede moverla o quitarla según sea necesario.
            this.usersTableAdapter1.Fill(this.db_a85839_appDataSet4.Users);
            // TODO: esta línea de código carga datos en la tabla 'k.view_Users' Puede moverla o quitarla según sea necesario.
           


        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Select_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM view_Users where Country like ('" + comboBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }
        public void cargar_datos()
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * From dbo.Country ORDER BY ID_Continents,Name_Country ASC", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            DataRow fila = dt.NewRow();
            fila["Name_Country"] = "Select Country";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "Name_Country";
            comboBox1.DisplayMember = "Name_Country";
            comboBox1.DataSource = dt;

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM view_Users where Users like ('%"+txt_Name.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM view_Users where Email like ('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void txt_Id_Share_TextChanged(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

        }

        private void txt_Company_TextChanged(object sender, EventArgs e)
        {

            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM view_Users where Company like ('" + txt_Company.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }
      

        private void button_share_Click(object sender, EventArgs e)
        {
            /*
             * Actualizacion de las Tablas y integracion de los usuarios que van ha poder aceder al proyecto
            */

            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlDataAdapter sdan = new SqlDataAdapter("SELECT ID_Project FROM dbo.Projects WHERE Name='" + CreatreProject.GetName() + "'", conn);
            DataTable dtn = new DataTable();
            sdan.Fill(dtn);

            string Pro = dtn.Rows[0][0].ToString();
            int Project = int.Parse(Pro);

            SqlDataAdapter sdan2 = new SqlDataAdapter("SELECT ID_User FROM dbo.Users WHERE ID_User='" + txt_Id_Share.Text + "'", conn);
            DataTable dtn2 = new DataTable();
            sdan2.Fill(dtn2);

            string Dueño = dtn2.Rows[0][0].ToString();
             intProject = int.Parse(Dueño);

            SqlDataAdapter sdan3 = new SqlDataAdapter("SELECT Users FROM dbo.Users WHERE ID_User='" + txt_Id_Share.Text + "'", conn);
            DataTable dtn3 = new DataTable();
            sdan2.Fill(dtn3);

            string User = dtn3.Rows[0][0].ToString();
            

            string Query = "INSERT INTO dbo.User_Project(ID_User,Name,Start_Date,End_Date,ID_Project)VALUES('" + intProject + "','" + CreatreProject.GetName() + "','" + CreatreProject.GetDateStart() + "','" + CreatreProject.GetDateEnd() + "','" + Project + "')";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(User+" was added to the project");




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM view_Users where Country like ('" + comboBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
