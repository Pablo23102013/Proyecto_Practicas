namespace Proyecto
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void button_Registro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
           
        }
    }
}