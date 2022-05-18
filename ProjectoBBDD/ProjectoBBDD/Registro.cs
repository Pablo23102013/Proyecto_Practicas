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
    public partial class Registro : Form
    {
       
        public Registro()
        {
            InitializeComponent();
            cargar_datos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Idioma_Click(object sender, EventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            string User=Txt_User.Text;
            string Email=Txt_Email.Text;
            string Password=Txt_Password.Text;
            string Idioma=Idiomas.Text;
            string Pais = Select_Pais.Text;
            string Empresa=TX_Company.Text;

            string Query = "INSERT INTO dbo.Users(Users,Email,Password,Idioma,Country,Company)VALUES('"+User+"','"+Email+"','"+Password+"','"+Idioma+"','"+Pais+ "','" + Empresa + "')";

            SqlCommand cmd = new SqlCommand(Query,conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Datos Guardados");

            this.Close();

        }
        public void cargar_datos()
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * From dbo.Country ORDER BY ID_Continents,Name_Country ASC",conn);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            DataRow fila = dt.NewRow();
            fila["Name_Country"] = "Select Country";
            dt.Rows.InsertAt(fila,0);

            Select_Pais.ValueMember = "Name_Country";
            Select_Pais.DisplayMember = "Name_Country";
            Select_Pais.DataSource = dt;

        }
       

        private void Password_Click(object sender, EventArgs e)
        {
           
        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Etiqueta_Email_Click(object sender, EventArgs e)
        {

        }

        private void Etiqueta_User_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Idiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
          

        }

        private void TX_Company_TextChanged(object sender, EventArgs e)
        {

        }

        private void Select_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
