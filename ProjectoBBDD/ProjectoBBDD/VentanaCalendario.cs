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
using static System.Windows.Forms.DataFormats;

namespace ProjectoBBDD
{
    public partial class VentanaCalendario : Form
    {
        public static Color Colores;
        public static string static_Mes, static_year;
        public static string date_,po;
        
        public VentanaCalendario()
        {
            InitializeComponent();
            date(); 
        }
        public void date()
        {
            date_Start.Text =UserControl2.static_day+"/"+Calendario.static_month+"/"+Calendario.static_year;
            end_date.Text = UserControl2.static_day + "/" + Calendario.static_month + "/" + Calendario.static_year;

            //time_end.Value = DateTime.Today.AddHours(1);

             po=date_Start.ToString();

            time_end.Format = DateTimePickerFormat.Custom;
            time_end.CustomFormat = "HH:mm";
            time_end.ShowUpDown = true;

            Time_start.Format = DateTimePickerFormat.Custom;
            Time_start.CustomFormat = "HH:mm";
            Time_start.ShowUpDown = true;
        }
        public static string getday()
        {
            date_ = po;
            return date_;
        }

        private void VentanaCalendario_Load(object sender, EventArgs e)
        {

        }

        private void time_end_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Time_start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";

            SqlConnection conn = new SqlConnection(ConnectionString);
           
                conn.Open();
            
            

            SqlDataAdapter sdan = new SqlDataAdapter("SELECT ID_User FROM dbo.Users WHERE email='" + Form1.Email() + "'", conn);

            DataTable dtn = new DataTable();

            sdan.Fill(dtn);

            string Dueño = dtn.Rows[0][0].ToString();
           int intDueño = int.Parse(Dueño);

            string data_inicio = date_Start.Text;
            string data_final = end_date.Text;
            string hora_inicio = Time_start.Text;
            string Hora_final = time_end.Text;
            
            if(checkBox1.Checked)
            {
                Hora_final = null;
                hora_inicio = null;
            }
            SqlDataAdapter sdan2 = new SqlDataAdapter("SELECT ID_Project FROM dbo.Projects WHERE Name='"+ProjectoBBDD.Project.getProject()+"'",conn);
            DataTable dtn2 = new DataTable();
            sdan2.Fill(dtn2);

            string Pro = dtn2.Rows[0][0].ToString();
            int Project = int.Parse(Pro);
            string Query = "INSERT INTO dbo.Calendar(ID_Project,ID_User,Fecha_Final,Fecha_Inicio,Tiempo_inicio,Tiempo_Final,Event_,Description_,Allday,Color)VALUES('" + Project + "','" + intDueño + "','" + data_final + "','" + data_inicio + "','" + hora_inicio + "','" + Hora_final + "','" + txt_Event.Text + "','" + richTextBox1.Text + "','" + checkBox1.Checked + "','" + Colores.ToString() + "')";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Your event is registered");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void date_Start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_Color_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Colores = colorDialog1.Color;
                UserControl2 userControl2 = new UserControl2();
                userControl2.BackColor = colorDialog1.Color;
                
            }
        }
    }
}
