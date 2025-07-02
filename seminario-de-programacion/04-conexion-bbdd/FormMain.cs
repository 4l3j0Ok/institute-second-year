using Microsoft.Data.SqlClient;
using ReaLTaiizor.Forms;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

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

        private void dgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];
            if (selectedRow == null || selectedRow.IsNewRow) return;
            string dni = selectedRow.Cells["DNI"].Value.ToString() ?? string.Empty;
            string nombre = selectedRow.Cells["Nombre"].Value.ToString() ?? string.Empty;
            string apellido = selectedRow.Cells["Apellido"].Value.ToString() ?? string.Empty;
            string direccion = selectedRow.Cells["Direccion"].Value.ToString() ?? string.Empty;
            string email = selectedRow.Cells["Email"].Value.ToString() ?? string.Empty;
            string telefono = selectedRow.Cells["Telefono"].Value.ToString() ?? string.Empty;
            tbDNI.Text = dni;
            tbName.Text = nombre;
            tbSurname.Text = apellido;
            tbAddress.Text = direccion;
            tbEmail.Text = email;
            tbPhone.Text = telefono;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Text = "Actualizar";
            this.updating = true;
            this.oldDNI = dni;
            return;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tbDNI.Text) ||
                string.IsNullOrEmpty(tbName.Text) ||
                string.IsNullOrEmpty(tbSurname.Text) ||
                string.IsNullOrEmpty(tbAddress.Text) ||
                string.IsNullOrEmpty(tbEmail.Text) ||
                string.IsNullOrEmpty(tbPhone.Text) ||
                tbDNI.Text.Length < 8 ||
                tbPhone.Text.Length < 10 ||
                !tbEmail.Text.Contains("@")))
                btnSave.Enabled = true;
            else btnSave.Enabled = false;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que quieres eliminar este registro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result != DialogResult.Yes) return;
            string dni = this.oldDNI;
            string query = File.ReadAllText(".\\queries\\05-delete.sql");
            query = query.Replace("{ DNI }", dni);
            Database.ExecuteNonQuery(query);
            MessageBox.Show("Datos eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnSave.Text = "Guardar";
            this.updating = false;
            this.oldDNI = string.Empty;
            tbDNI.Clear();
            tbName.Clear();
            tbSurname.Clear();
            tbAddress.Clear();
            tbEmail.Clear();
            tbPhone.Clear();
            tbAddress.Clear();
            tbDNI.Focus();
        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{0,8}?$");
            if (!regex.IsMatch(tbDNI.Text + e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{0,13}?$");
            if (!regex.IsMatch(tbPhone.Text + e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbOnlyChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z\s]{0,50}?$");
            if (!regex.IsMatch(((TextBox)sender).Text + e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
