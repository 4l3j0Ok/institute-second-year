using Microsoft.Data.SqlClient;
using ReaLTaiizor.Forms;
using System.Data;
using System.Diagnostics;

namespace _04_conexion_bbdd
{
    public partial class FormMain : MaterialForm
    {
        private bool updating = false;
        private string oldDNI = "";
        public FormMain()
        {
            InitializeComponent();
            try
            {
                Database.CheckConnection();
                Debug.WriteLine("Conexión establecida");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Database.CreateDatabaseIfNotExists();
            Database.CreateTablesIfNotExists();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            SqlDataReader data = Database.ExecuteReader("USE SeminarioABM; SELECT * FROM Personas");
            DataTable dt = new DataTable();
            dt.Load(data);
            dgvData.DataSource = dt;
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtenemos el seleccionado y sacamos datos por el nombre de la columna
            DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];
            string dni = selectedRow.Cells["DNI"].Value.ToString();
            string nombre = selectedRow.Cells["Nombre"].Value.ToString();
            string apellido = selectedRow.Cells["Apellido"].Value.ToString();
            string direccion = selectedRow.Cells["Direccion"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string telefono = selectedRow.Cells["Telefono"].Value.ToString();

            tbDNI.Text = dni;
            tbName.Text = nombre;
            tbSurname.Text = apellido;
            tbAddress.Text = direccion;
            tbEmail.Text = email;
            tbPhone.Text = telefono;

            this.updating = true;
            this.oldDNI = dni;
            btnSave.Text = "Actualizar";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dni = tbDNI.Text.Trim();
            string nombre = tbName.Text.Trim();
            string apellido = tbSurname.Text.Trim();
            string direccion = tbAddress.Text.Trim();
            string email = tbEmail.Text.Trim();
            string telefono = tbPhone.Text.Trim();
            string query;
            if (!this.updating) query = File.ReadAllText(".\\queries\\03-insert.sql");
            else query = File.ReadAllText(".\\queries\\04-update.sql");
            query = query.Replace("{ DNI }", dni)
                .Replace("{ Nombre }", nombre)
                .Replace("{ Apellido }", apellido)
                .Replace("{ Direccion }", direccion)
                .Replace("{ Email }", email)
                .Replace("{ Telefono }", telefono)
                .Replace("{ oldDNI }", this.oldDNI);
            Debug.WriteLine(query);
            Database.ExecuteNonQuery(query);
            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tbDNI.Text) ||
                string.IsNullOrEmpty(tbName.Text) ||
                string.IsNullOrEmpty(tbSurname.Text) ||
                string.IsNullOrEmpty(tbAddress.Text) ||
                string.IsNullOrEmpty(tbEmail.Text) ||
                string.IsNullOrEmpty(tbPhone.Text)))
                btnSave.Enabled = true;
            else btnSave.Enabled = false;
        }
    }
}
