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
        
        public PeopleAdd()
        {
            InitializeComponent();
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
            cmd.CommandText = "Select * FROM view_Users where Country like ('" + Select_Pais.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
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
    }
}
