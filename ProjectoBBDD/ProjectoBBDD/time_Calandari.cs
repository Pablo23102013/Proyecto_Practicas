using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoBBDD
{
    public partial class time_Calandari : Form
    {
        public static bool apagar=false;
        public time_Calandari()
        {
            InitializeComponent();
        }
        public bool getapagar()
        {
            return apagar;
        }

       

        private void btn_Calendario_Click(object sender, EventArgs e)
        {
            apagar=true;
            //new VentanaCalendario().Show();
            new Calendario().Show(); 
            this.Close();
        }

        private void btn_Timesheet_Click(object sender, EventArgs e)
        {
            apagar = true;
            new Timesheet().Show();
            this.Close();
            
        }
    }
}
