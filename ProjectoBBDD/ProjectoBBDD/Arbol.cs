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
    public partial class Arbol : Form
    {
        int Contar = 0;
        int Arbol2=0;
        int ContarArbol = 10;
        
        public Arbol()
        {
            InitializeComponent();
        }

        private void Arbol_Click(object sender, EventArgs e)
        {
            Contar++;
            
            label2.Text = Contar.ToString();
            label4.Text = Arbol2.ToString();

            if(Contar == ContarArbol)
            {
                
                Arbol2++;
                MessageBox.Show("Win 1 Trees");
                Contar = Contar + (Contar / 2);
                ContarArbol = ContarArbol + Contar;

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Arbol_Load(object sender, EventArgs e)
        {

        }
    }
}
