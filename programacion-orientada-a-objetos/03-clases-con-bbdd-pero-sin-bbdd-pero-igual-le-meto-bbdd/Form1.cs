

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
            dgvMainData.DataSource = GetData();
        }

        private void dgvMainData_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMainData.CurrentRow;
            string nombre = row.Cells["Nombre"].Value.ToString() ?? "";
            string apellido = row.Cells["Apellido"].Value.ToString() ?? "";
            string edad = row.Cells["Edad"].Value.ToString() ?? "";
            string nota = row.Cells["Nota"].Value.ToString() ?? "";
            string anio = row.Cells["Año"].Value.ToString() ?? "";
            string curso = row.Cells["Curso"].Value.ToString() ?? "";
            string materia = row.Cells["Materia"].Value.ToString() ?? "";
            tbNombre.Text = nombre;
            tbApellido.Text = apellido;
            tbEdad.Text = edad;
            tbNota.Text = nota;
            tbAnio.Text = anio;
            tbCurso.Text = curso;
            tbMateria.Text = materia;

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvMainData.CurrentRow;
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string nombre = tbNombre.Text;
                string apellido = tbApellido.Text;
                int edad = int.Parse(tbEdad.Text);
                double nota = double.Parse(tbNota.Text);
                int anio = int.Parse(tbAnio.Text);
                string curso = tbCurso.Text;
                string materia = tbMateria.Text;
                string query = @$"UPDATE Usuarios SET 
                                nombre = '{nombre}',
                                apellido = '{apellido}',
                                edad = {edad},
                                nota = {nota},
                                anio = {anio},
                                curso = '{curso}',
                                materia = '{materia}'
                                WHERE id = {id}";
                Database.Execute(query);
                dgvMainData.DataSource = GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar los datos: {ex.Message}");
                return;
            }
        }
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            try
            {
                Database.CreateInitialTables();
                string query = @"SELECT 
                                id AS 'ID',
                                nombre AS 'Nombre',
                                apellido AS 'Apellido',
                                edad AS 'Edad',
                                nota AS 'Nota',
                                anio AS 'Año',
                                curso AS Curso,
                                materia AS Materia
                                FROM Usuarios";
                dt = Database.ExecuteRead(query);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer de la base de datos: {ex}");
            }
            return dt;
        }
    }
}
