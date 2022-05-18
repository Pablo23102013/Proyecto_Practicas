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
    public partial class Calendario : Form
    {
        public static int Meses, Years;
        public static string static_month, static_year;
        public static string meses;
        public static string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
        public Calendario()
        {
            InitializeComponent();
            bot();
            user();
            

        }
        public void Event()
        {
            string ConnectionString = "Data Source=SQL5108.site4now.net;Initial Catalog=db_a85839_app;User Id=db_a85839_app_admin;Password=Pablo-23";
            //string ConnectionString = "Data Source=LAPTOP-E1RMVQD6\\SQLEXPRESS;Initial Catalog=App;Integrated Security=True";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM dbo.Calendario_View WHERE Name='" + Project.getProject() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void bot()
        {
          //  Lbproject.Text = Project.getProject().ToString();
            DateTime now = DateTime.Now;
            Meses = now.Month;
            Years = now.Year;
            DateTime startofmonnth = new DateTime(Years, Meses, 1);
            int day = DateTime.DaysInMonth(Years, Meses);
            int dayoftheweek = Convert.ToInt32(startofmonnth.DayOfWeek.ToString("d") + 06);
            Mes();
            
            static_month = Meses.ToString();
            static_year = Years.ToString();

            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControl1 u = new UserControl1();
                
                Calendariopanel.Controls.Add(u);
            }
            day++;
            for (int i = 1; i < day; i++)
            {
                UserControl2 uday = new UserControl2();
                uday.days(i);
                
                Calendariopanel.Controls.Add(uday);
            }
        }
        public void user()
        {
            

            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
            }
            catch (Exception)
            { MessageBox.Show("Sorry, you could check your Connection"); }


            SqlDataAdapter sda = new SqlDataAdapter("SELECT Users FROM dbo.Users WHERE email='" + Form1.Email() + "'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            lUser.Text = dt.Rows[0][0].ToString();

            Lbproject.Text = Project.getProject();

        }

        private void lMes_Click(object sender, EventArgs e)
        {

        }

        private void lUser_Click(object sender, EventArgs e)
        {

        }

        private void Calendariopanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Mes()
        {
            
           if(Meses==1)
            {
                lMes.Text = "January";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);
                
            }
            else if (Meses == 2)
            {
                lMes.Text = "February";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);

            }
           else if (Meses == 3)
            {
                lMes.Text = "March";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);

            }
            else if(Meses == 4)
            {
                lMes.Text = "April";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);

            }
            else if(Meses == 5)
            {
                lMes.Text = "May";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);
            }
            else if(Meses == 6)
            {
                lMes.Text = "June";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);
            }
            else if(Meses == 7)
            {
                lMes.Text = "July";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);
            }
            else if(Meses == 8)
            {
                lMes.Text = "August";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);
            }
            else if(Meses == 9)
            {
                lMes.Text = "September"; IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);
            }
            else if(Meses == 10)
            {
                lMes.Text = "October";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);
            }
            else if(Meses == 11)
            {
                lMes.Text = "November";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);
            }
           else if(Meses==12)
            {
                lMes.Text = "December";
                IYear.Text = Years.ToString();
                Titulo.Controls.Add(lMes);
                Titulo.Controls.Add(IYear);
            }
           

        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            Calendariopanel.Controls.Clear();
            Titulo.Controls.Clear();
            if (Meses == 1)
            {
                Years--;
                Meses = 13;
            }
         
            Meses--;
            Mes();
            
            static_month = Meses.ToString();
            static_year = Years.ToString();

            DateTime startofmonnth = new DateTime(Years, Meses, 1);
            int day = DateTime.DaysInMonth(Years, Meses);
            int dayoftheweek = Convert.ToInt32(startofmonnth.DayOfWeek.ToString("d"));
            Mes();

            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControl1 u = new UserControl1();
                Calendariopanel.Controls.Add(u);
            }
            day++;
            for (int i = 1; i < day; i++)
            {
                UserControl2 uday = new UserControl2();
                uday.days(i);
                Calendariopanel.Controls.Add(uday);
            }
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_a85839_appDataSet9.Calendario_View' Puede moverla o quitarla según sea necesario.
            this.calendario_ViewTableAdapter.Fill(this.db_a85839_appDataSet9.Calendario_View);

        }

        private void LLunes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lbproject_Click(object sender, EventArgs e)
        {

        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            Calendariopanel.Controls.Clear();
            Titulo.Controls.Clear();
            if (Meses == 12)
            {
                Years++;
                Meses = 0;
            }

            Meses++;
            Mes();
            
            static_month = Meses.ToString();
            static_year = Years.ToString();
            DateTime startofmonnth = new DateTime(Years, Meses, 1);
            int day = DateTime.DaysInMonth(Years, Meses);
            int dayoftheweek = Convert.ToInt32(startofmonnth.DayOfWeek.ToString("d"));



            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControl1 u = new UserControl1();
                Calendariopanel.Controls.Add(u);
            }
            day++;
            for (int i = 1; i < day; i++)
            {
                UserControl2 uday = new UserControl2();
                uday.days(i);
                Calendariopanel.Controls.Add(uday);
            }
        }
    }
}
