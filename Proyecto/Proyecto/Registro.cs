using MySql.Data.MySqlClient;
using Proyecto.Clases;
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

namespace Proyecto
{
    public partial class Registro : Form
    {
        MySqlConnection conn;
        string connString;
        
        public Registro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //User

        }
        public void insert()
        {
            SqlConnection=
            connection = new SqlConnection();

        }
        
        private void insertar2()
        {
            connString = "SERVER=remotemysql.com;PORT=3306;DATABASE=;UID=mPylUpf84I;PASSWORD=EBA7lZ9lUa;";
            
            conn = new MySqlConnection(connString);
            MySqlCommand cmd;

            try
            {
                cmd= conn.CreateCommand();
                cmd.CommandText = "INSERT INTO User(User,Email,Password) VALUES(@USER,@Email,@Password)";
                cmd.Parameters.AddWithValue("@USER",textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox_Email.Text);
                cmd.Parameters.AddWithValue("Password",Contraseña.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Viva");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
            connString = "SERVER=remotemysql.com;PORT=3306;DATABASE=;UID=mPylUpf84I;PASSWORD=EBA7lZ9lUa;";
            try
            {
                conn = new MySqlConnection("SERVER=remotemysql.com;PORT=3306;DATABASE=mPylUpf84I;UID=mPylUpf84I;PASSWORD=EBA7lZ9lUa;");
               // conn.ConnectionString= connString;
                conn.Open();

                MessageBox.Show("Conexion");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo siento");
            }
            //insert(textBox1.Text,textBox_Email.Text,t_Password.Text,s_Idioma.Text);
            //insert("Ana","Inventado","123456","Castellano");
            insertar2();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label_User_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
