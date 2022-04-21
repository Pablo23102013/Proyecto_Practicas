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
    public partial class Form1 : Form
    {
        public static string email;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
           // string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string contrsaeña=Txt_contraseña.Text;
             email=Txt_Email.Text;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM dbo.Users WHERE email='"+email+"' AND password='"+ contrsaeña+ "'", conn);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
              
               new Home().Show();
               
               
            }
            else
                MessageBox.Show("Invalid username or password");

        
    }
        public static string Email()
        {
            string correo = email;
            return correo;
        }

        private void Txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
