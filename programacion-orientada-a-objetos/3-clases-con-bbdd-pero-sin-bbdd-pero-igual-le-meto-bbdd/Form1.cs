

using Microsoft.Data.SqlClient;
using System.Data;
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
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error inesperado: {ex}");
                return;
            }
            MessageBox.Show("Conectado a la base de datos.");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                Database.CloseDatabase();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error inesperado: {ex}");
                return;
            }
            dgvMainData.DataSource = null;
            MessageBox.Show("Desconectado de la base de datos.");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                Database.CreateInitialTables();
                string query = "SELECT * FROM Usuarios";
                DataTable dt = Database.ExecuteRead(query);
                // Establecemos el datatable como fuente de datos del DataGridView
                dgvMainData.DataSource = dt;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al leer de la base de datos: {ex}");
                return;
            }
        }
    }
}
