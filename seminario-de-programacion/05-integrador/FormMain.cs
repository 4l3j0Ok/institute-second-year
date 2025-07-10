using Microsoft.Data.SqlClient;
using ReaLTaiizor.Forms;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _05_integrador
{
    public partial class FormMain : MaterialForm
    {
        private bool updating = false;
        private string currentId = "";

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
            SqlDataReader data = Database.ExecuteReader("USE Electrodomesticos; SELECT * FROM Electrodomestico");
            if (!data.HasRows)
                Database.InsertDefaultValues();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView(bool showAll = false)
        {
            string query = @"USE Electrodomesticos;
                    SELECT
                    Id, 
                    electrodomesticos_codigo AS Codigo,
                    electrodomesticos_tipo AS Tipo,
                    electrodomesticos_marca AS Marca,
                    electrodomesticos_modelo AS Modelo,
                    electrodomesticos_caracteristicas AS Características,
                    electrodomesticos_cantidad_stock AS Stock,
                    electrodomesticos_precio AS Precio,
                    electrodomesticos_fecha_ingreso AS 'Fecha de ingreso'
                    FROM Electrodomestico
                ";
            if (!showAll)
                query += " WHERE electrodomesticos_estado = 1;";
            else
                query += ";";
            SqlDataReader data = Database.ExecuteReader(query);

            DataTable dt = new DataTable();
            dt.Load(data);
            dgvData.DataSource = dt;
            dgvData.Columns["Id"].Visible = false;
        }

        private void dgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dgvData.Rows[e.RowIndex];
            if (selectedRow == null || selectedRow.IsNewRow) return;
            string id = selectedRow.Cells["Id"].Value.ToString() ?? string.Empty;
            string codigo = selectedRow.Cells["Codigo"].Value.ToString() ?? string.Empty;
            string tipo = selectedRow.Cells["Tipo"].Value.ToString() ?? string.Empty;
            string marca = selectedRow.Cells["Marca"].Value.ToString() ?? string.Empty;
            string modelo = selectedRow.Cells["Modelo"].Value.ToString() ?? string.Empty;
            string caracteristicas = selectedRow.Cells["Características"].Value.ToString() ?? string.Empty;
            string stock = selectedRow.Cells["Stock"].Value.ToString() ?? string.Empty;
            string precio = selectedRow.Cells["Precio"].Value.ToString() ?? string.Empty;
            DateTime fecha_ingreso = DateTime.Parse(selectedRow.Cells["Fecha de ingreso"].Value.ToString() ?? DateTime.Now.ToString());
            tbCodigo.Enabled = false;
            tbCodigo.Text = codigo;
            tbTipo.Text = tipo;
            tbMarca.Text = marca;
            tbModelo.Text = modelo;
            tbCaracteristicas.Text = caracteristicas;
            tbStock.Text = stock;
            tbPrecio.Text = precio;
            dtFechaIngreso.Value = fecha_ingreso;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Text = "Actualizar";
            this.updating = true;
            this.currentId = id;
            return;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(tbCodigo.Text.Trim()) ||
                string.IsNullOrEmpty(tbTipo.Text.Trim()) ||
                string.IsNullOrEmpty(tbMarca.Text.Trim()) ||
                string.IsNullOrEmpty(tbModelo.Text.Trim()) ||
                string.IsNullOrEmpty(tbCaracteristicas.Text.Trim()) ||
                string.IsNullOrEmpty(tbStock.Text.Trim()) ||
                string.IsNullOrEmpty(tbPrecio.Text.Trim())))
                btnSave.Enabled = true;
            else btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string codigo = tbCodigo.Text.Trim();
            string tipo = tbTipo.Text.Trim();
            string marca = tbMarca.Text.Trim();
            string modelo = tbModelo.Text.Trim();
            string caracteristicas = tbCaracteristicas.Text.Trim();
            string stock = tbStock.Text.Trim();
            string precio = tbPrecio.Text.Trim().Replace(",", ".");
            string fecha_ingreso = dtFechaIngreso.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string query;
            if (!this.updating) query = File.ReadAllText(".\\queries\\04-insert.sql");
            else if (tbStock.Text == "0") query = File.ReadAllText(".\\queries\\06-delete.sql");
            else query = File.ReadAllText(".\\queries\\05-update.sql");
            query = query.Replace("{ electrodomesticos_tipo }", tipo)
                            .Replace("{ electrodomesticos_marca }", marca)
                            .Replace("{ electrodomesticos_modelo }", modelo)
                            .Replace("{ electrodomesticos_caracteristicas }", caracteristicas)
                            .Replace("{ electrodomesticos_cantidad_stock }", stock)
                            .Replace("{ electrodomesticos_precio }", precio)
                            .Replace("{ electrodomesticos_fecha_ingreso }", fecha_ingreso)
                            .Replace("{ electrodomesticos_codigo }", codigo)
                            .Replace("{ Id }", this.currentId);
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
            string query = File.ReadAllText(".\\queries\\06-delete.sql");
            query = query.Replace("{ Id }", this.currentId);
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
            this.currentId = string.Empty;
            tbCodigo.Clear();
            tbCodigo.Enabled = true;
            tbTipo.Clear();
            tbMarca.Clear();
            tbModelo.Clear();
            tbCaracteristicas.Clear();
            tbStock.Clear();
            tbModelo.Clear();
            tbCodigo.Focus();
        }

        private void tbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{0,5}$");
            if (!regex.IsMatch(tbCodigo.Text + e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{0,10}?$");
            if (!regex.IsMatch(tbStock.Text + e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
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

        private void cbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataGridView(showAll: cbShowAll.Checked);
        }

        private void tbPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
