

using System.Diagnostics;

namespace _3_clases_con_bbdd_pero_sin_bbdd_pero_igual_le_meto_bbdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Database.OpenDatabase();
                MessageBox.Show("Conexión establecida con la base de datos.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al conectar con la base de datos: {ex}");
                MessageBox.Show("Error al conectar con la base de datos.");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

        }
    }
}
