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
    public partial class UserControl2 : UserControl
    {
        public static string static_day;

        string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
        public UserControl2()
        {
            InitializeComponent();
           // displayEvent();
        }
        public void Conexion()
        {

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();
        }
        public void days(int numday)
        {
            label1.Text = numday + "";
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            static_day = label1.Text;
            timer1.Start();
            new VentanaCalendario().Show();
        }

        private void LBEvent_Click(object sender, EventArgs e)
        {

        }
        private void displayEvent()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            /*
            String sql= "SELECT Event_ FROM dbo.Calendar WHERE Fecha_Inicio = ? ";

            SqlCommand cmd =  conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("Fecha_Inicio",Calendario.static_year+","+Calendario.static_month+","+label1.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                label1.Text=reader["Event_"].ToString();
            }
            reader.Dispose();
            */
            
              SqlDataAdapter sdan = new SqlDataAdapter("SELECT Event_ FROM dbo.Calendar WHERE Fecha_Inicio='"+VentanaCalendario.getday()+"'", conn);
                DataTable dtn = new DataTable();
                sdan.Fill(dtn);
                if(dtn.Rows.Count > 0)
                {
                    LBEvent.Text = dtn.Rows[0][0].ToString(); 
                }
             
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            static_day = label1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
