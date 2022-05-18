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
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
            cargar_datos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_a85839_appDataSet7.view_Contry_and_Continents' Puede moverla o quitarla según sea necesario.
            this.view_Contry_and_ContinentsTableAdapter2.Fill(this.db_a85839_appDataSet7.view_Contry_and_Continents);
            // TODO: esta línea de código carga datos en la tabla 'db_a85839_appDataSet6.view_Contry_and_Continents' Puede moverla o quitarla según sea necesario.
            this.view_Contry_and_ContinentsTableAdapter1.Fill(this.db_a85839_appDataSet6.view_Contry_and_Continents);
            // TODO: esta línea de código carga datos en la tabla 'db_a85839_appDataSet1.view_Contry_and_Continents' Puede moverla o quitarla según sea necesario.
            this.view_Contry_and_ContinentsTableAdapter.Fill(this.db_a85839_appDataSet1.view_Contry_and_Continents);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string Name=txt_Name.Text;
            string Email=txt_Email.Text;
            string Contrseña=txt_Password.Text;
            string Pais = Select_Pais.Text;
            string compania = txt_Company.Text;

            SqlCommand cmd = new SqlCommand("UPDATE dbo.Users SET Users='"+Name+"',Email='"+Email+"',Password='"+Contrseña+"',Country='"+Pais+"',Company='"+compania+"' Where Email = '"+Form1.Email()+"'",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tus Datos han sido modificados");
        }

        private void Select_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            Select_Pais.ValueMember = "Name_Country";
            Select_Pais.DisplayMember = "Name_Country";
            Select_Pais.DataSource = dt;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_Contry_and_ContinentsTableAdapter2.FillBy(this.db_a85839_appDataSet7.view_Contry_and_Continents);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
