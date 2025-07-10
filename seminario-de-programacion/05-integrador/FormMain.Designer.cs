namespace _05_integrador
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            panel2 = new Panel();
            dtFechaIngreso = new ReaLTaiizor.Controls.PoisonDateTime();
            materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            tbPrecio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            tbStock = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            tbCaracteristicas = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            tbModelo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            tbMarca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            tbTipo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            tbCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvData = new DataGridView();
            cbShowAll = new ReaLTaiizor.Controls.MaterialCheckBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 653);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(314, 647);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnCancel, 2, 0);
            tableLayoutPanel2.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 600);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(308, 44);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.Dock = DockStyle.Top;
            btnCancel.Enabled = false;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancel.Location = new Point(209, 5);
            btnCancel.Margin = new Padding(5);
            btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(94, 34);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancelar";
            btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.Dock = DockStyle.Top;
            btnSave.Enabled = false;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSave.Location = new Point(5, 5);
            btnSave.Margin = new Padding(5);
            btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(92, 34);
            btnSave.TabIndex = 14;
            btnSave.Text = "Guardar";
            btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.Dock = DockStyle.Top;
            btnDelete.Enabled = false;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDelete.Location = new Point(107, 5);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(92, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = true;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtFechaIngreso);
            panel2.Controls.Add(materialLabel8);
            panel2.Controls.Add(tbPrecio);
            panel2.Controls.Add(materialLabel7);
            panel2.Controls.Add(tbStock);
            panel2.Controls.Add(materialLabel6);
            panel2.Controls.Add(tbCaracteristicas);
            panel2.Controls.Add(materialLabel5);
            panel2.Controls.Add(tbModelo);
            panel2.Controls.Add(materialLabel4);
            panel2.Controls.Add(tbMarca);
            panel2.Controls.Add(materialLabel3);
            panel2.Controls.Add(tbTipo);
            panel2.Controls.Add(materialLabel2);
            panel2.Controls.Add(tbCodigo);
            panel2.Controls.Add(materialLabel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 591);
            panel2.TabIndex = 15;
            // 
            // dtFechaIngreso
            // 
            dtFechaIngreso.Dock = DockStyle.Top;
            dtFechaIngreso.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtFechaIngreso.Location = new Point(0, 488);
            dtFechaIngreso.MinimumSize = new Size(0, 29);
            dtFechaIngreso.Name = "dtFechaIngreso";
            dtFechaIngreso.Size = new Size(308, 29);
            dtFechaIngreso.TabIndex = 28;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Dock = DockStyle.Top;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(0, 469);
            materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(121, 19);
            materialLabel8.TabIndex = 27;
            materialLabel8.Text = "Fecha de ingreso";
            // 
            // tbPrecio
            // 
            tbPrecio.AnimateReadOnly = false;
            tbPrecio.AutoCompleteMode = AutoCompleteMode.None;
            tbPrecio.AutoCompleteSource = AutoCompleteSource.None;
            tbPrecio.BackgroundImageLayout = ImageLayout.None;
            tbPrecio.CharacterCasing = CharacterCasing.Normal;
            tbPrecio.Depth = 0;
            tbPrecio.Dock = DockStyle.Top;
            tbPrecio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPrecio.HideSelection = true;
            tbPrecio.LeadingIcon = null;
            tbPrecio.Location = new Point(0, 421);
            tbPrecio.MaxLength = 32767;
            tbPrecio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPrecio.Name = "tbPrecio";
            tbPrecio.PasswordChar = '\0';
            tbPrecio.PrefixSuffixText = null;
            tbPrecio.ReadOnly = false;
            tbPrecio.RightToLeft = RightToLeft.No;
            tbPrecio.SelectedText = "";
            tbPrecio.SelectionLength = 0;
            tbPrecio.SelectionStart = 0;
            tbPrecio.ShortcutsEnabled = false;
            tbPrecio.Size = new Size(308, 48);
            tbPrecio.TabIndex = 26;
            tbPrecio.TabStop = false;
            tbPrecio.TextAlign = HorizontalAlignment.Left;
            tbPrecio.TrailingIcon = null;
            tbPrecio.UseSystemPasswordChar = false;
            tbPrecio.Click += tbPrecio_Click;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Dock = DockStyle.Top;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(0, 402);
            materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(45, 19);
            materialLabel7.TabIndex = 25;
            materialLabel7.Text = "Precio";
            // 
            // tbStock
            // 
            tbStock.AnimateReadOnly = false;
            tbStock.AutoCompleteMode = AutoCompleteMode.None;
            tbStock.AutoCompleteSource = AutoCompleteSource.None;
            tbStock.BackgroundImageLayout = ImageLayout.None;
            tbStock.CharacterCasing = CharacterCasing.Normal;
            tbStock.Depth = 0;
            tbStock.Dock = DockStyle.Top;
            tbStock.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbStock.HideSelection = true;
            tbStock.LeadingIcon = null;
            tbStock.Location = new Point(0, 354);
            tbStock.MaxLength = 32767;
            tbStock.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbStock.Name = "tbStock";
            tbStock.PasswordChar = '\0';
            tbStock.PrefixSuffixText = null;
            tbStock.ReadOnly = false;
            tbStock.RightToLeft = RightToLeft.No;
            tbStock.SelectedText = "";
            tbStock.SelectionLength = 0;
            tbStock.SelectionStart = 0;
            tbStock.ShortcutsEnabled = false;
            tbStock.Size = new Size(308, 48);
            tbStock.TabIndex = 24;
            tbStock.TabStop = false;
            tbStock.TextAlign = HorizontalAlignment.Left;
            tbStock.TrailingIcon = null;
            tbStock.UseSystemPasswordChar = false;
            tbStock.KeyPress += tbStock_KeyPress;
            tbStock.TextChanged += tb_TextChanged;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Dock = DockStyle.Top;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(0, 335);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(128, 19);
            materialLabel6.TabIndex = 23;
            materialLabel6.Text = "Cantidad de stock";
            // 
            // tbCaracteristicas
            // 
            tbCaracteristicas.AnimateReadOnly = false;
            tbCaracteristicas.AutoCompleteMode = AutoCompleteMode.None;
            tbCaracteristicas.AutoCompleteSource = AutoCompleteSource.None;
            tbCaracteristicas.BackgroundImageLayout = ImageLayout.None;
            tbCaracteristicas.CharacterCasing = CharacterCasing.Normal;
            tbCaracteristicas.Depth = 0;
            tbCaracteristicas.Dock = DockStyle.Top;
            tbCaracteristicas.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCaracteristicas.HideSelection = true;
            tbCaracteristicas.LeadingIcon = null;
            tbCaracteristicas.Location = new Point(0, 287);
            tbCaracteristicas.MaxLength = 32767;
            tbCaracteristicas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCaracteristicas.Name = "tbCaracteristicas";
            tbCaracteristicas.PasswordChar = '\0';
            tbCaracteristicas.PrefixSuffixText = null;
            tbCaracteristicas.ReadOnly = false;
            tbCaracteristicas.RightToLeft = RightToLeft.No;
            tbCaracteristicas.SelectedText = "";
            tbCaracteristicas.SelectionLength = 0;
            tbCaracteristicas.SelectionStart = 0;
            tbCaracteristicas.ShortcutsEnabled = false;
            tbCaracteristicas.Size = new Size(308, 48);
            tbCaracteristicas.TabIndex = 22;
            tbCaracteristicas.TabStop = false;
            tbCaracteristicas.TextAlign = HorizontalAlignment.Left;
            tbCaracteristicas.TrailingIcon = null;
            tbCaracteristicas.UseSystemPasswordChar = false;
            tbCaracteristicas.TextChanged += tb_TextChanged;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Dock = DockStyle.Top;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(0, 268);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(106, 19);
            materialLabel5.TabIndex = 21;
            materialLabel5.Text = "Características";
            // 
            // tbModelo
            // 
            tbModelo.AnimateReadOnly = false;
            tbModelo.AutoCompleteMode = AutoCompleteMode.None;
            tbModelo.AutoCompleteSource = AutoCompleteSource.None;
            tbModelo.BackgroundImageLayout = ImageLayout.None;
            tbModelo.CharacterCasing = CharacterCasing.Normal;
            tbModelo.Depth = 0;
            tbModelo.Dock = DockStyle.Top;
            tbModelo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbModelo.HideSelection = true;
            tbModelo.LeadingIcon = null;
            tbModelo.Location = new Point(0, 220);
            tbModelo.MaxLength = 32767;
            tbModelo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbModelo.Name = "tbModelo";
            tbModelo.PasswordChar = '\0';
            tbModelo.PrefixSuffixText = null;
            tbModelo.ReadOnly = false;
            tbModelo.RightToLeft = RightToLeft.No;
            tbModelo.SelectedText = "";
            tbModelo.SelectionLength = 0;
            tbModelo.SelectionStart = 0;
            tbModelo.ShortcutsEnabled = false;
            tbModelo.Size = new Size(308, 48);
            tbModelo.TabIndex = 20;
            tbModelo.TabStop = false;
            tbModelo.TextAlign = HorizontalAlignment.Left;
            tbModelo.TrailingIcon = null;
            tbModelo.UseSystemPasswordChar = false;
            tbModelo.TextChanged += tb_TextChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Dock = DockStyle.Top;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(0, 201);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(54, 19);
            materialLabel4.TabIndex = 19;
            materialLabel4.Text = "Modelo";
            // 
            // tbMarca
            // 
            tbMarca.AnimateReadOnly = false;
            tbMarca.AutoCompleteMode = AutoCompleteMode.None;
            tbMarca.AutoCompleteSource = AutoCompleteSource.None;
            tbMarca.BackgroundImageLayout = ImageLayout.None;
            tbMarca.CharacterCasing = CharacterCasing.Normal;
            tbMarca.Depth = 0;
            tbMarca.Dock = DockStyle.Top;
            tbMarca.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbMarca.HideSelection = true;
            tbMarca.LeadingIcon = null;
            tbMarca.Location = new Point(0, 153);
            tbMarca.MaxLength = 32767;
            tbMarca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbMarca.Name = "tbMarca";
            tbMarca.PasswordChar = '\0';
            tbMarca.PrefixSuffixText = null;
            tbMarca.ReadOnly = false;
            tbMarca.RightToLeft = RightToLeft.No;
            tbMarca.SelectedText = "";
            tbMarca.SelectionLength = 0;
            tbMarca.SelectionStart = 0;
            tbMarca.ShortcutsEnabled = false;
            tbMarca.Size = new Size(308, 48);
            tbMarca.TabIndex = 18;
            tbMarca.TabStop = false;
            tbMarca.TextAlign = HorizontalAlignment.Left;
            tbMarca.TrailingIcon = null;
            tbMarca.UseSystemPasswordChar = false;
            tbMarca.KeyPress += tbOnlyChar_KeyPress;
            tbMarca.TextChanged += tb_TextChanged;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Top;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(0, 134);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(46, 19);
            materialLabel3.TabIndex = 17;
            materialLabel3.Text = "Marca";
            // 
            // tbTipo
            // 
            tbTipo.AnimateReadOnly = false;
            tbTipo.AutoCompleteMode = AutoCompleteMode.None;
            tbTipo.AutoCompleteSource = AutoCompleteSource.None;
            tbTipo.BackgroundImageLayout = ImageLayout.None;
            tbTipo.CharacterCasing = CharacterCasing.Normal;
            tbTipo.Depth = 0;
            tbTipo.Dock = DockStyle.Top;
            tbTipo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbTipo.HideSelection = true;
            tbTipo.LeadingIcon = null;
            tbTipo.Location = new Point(0, 86);
            tbTipo.MaxLength = 32767;
            tbTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbTipo.Name = "tbTipo";
            tbTipo.PasswordChar = '\0';
            tbTipo.PrefixSuffixText = null;
            tbTipo.ReadOnly = false;
            tbTipo.RightToLeft = RightToLeft.No;
            tbTipo.SelectedText = "";
            tbTipo.SelectionLength = 0;
            tbTipo.SelectionStart = 0;
            tbTipo.ShortcutsEnabled = false;
            tbTipo.Size = new Size(308, 48);
            tbTipo.TabIndex = 16;
            tbTipo.TabStop = false;
            tbTipo.TextAlign = HorizontalAlignment.Left;
            tbTipo.TrailingIcon = null;
            tbTipo.UseSystemPasswordChar = false;
            tbTipo.KeyPress += tbOnlyChar_KeyPress;
            tbTipo.TextChanged += tb_TextChanged;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Top;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(0, 67);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(33, 19);
            materialLabel2.TabIndex = 15;
            materialLabel2.Text = "Tipo";
            // 
            // tbCodigo
            // 
            tbCodigo.AnimateReadOnly = false;
            tbCodigo.AutoCompleteMode = AutoCompleteMode.None;
            tbCodigo.AutoCompleteSource = AutoCompleteSource.None;
            tbCodigo.BackgroundImageLayout = ImageLayout.None;
            tbCodigo.CharacterCasing = CharacterCasing.Normal;
            tbCodigo.Depth = 0;
            tbCodigo.Dock = DockStyle.Top;
            tbCodigo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbCodigo.HideSelection = true;
            tbCodigo.LeadingIcon = null;
            tbCodigo.Location = new Point(0, 19);
            tbCodigo.MaxLength = 32767;
            tbCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbCodigo.Name = "tbCodigo";
            tbCodigo.PasswordChar = '\0';
            tbCodigo.PrefixSuffixText = null;
            tbCodigo.ReadOnly = false;
            tbCodigo.RightToLeft = RightToLeft.No;
            tbCodigo.SelectedText = "";
            tbCodigo.SelectionLength = 0;
            tbCodigo.SelectionStart = 0;
            tbCodigo.ShortcutsEnabled = false;
            tbCodigo.Size = new Size(308, 48);
            tbCodigo.TabIndex = 14;
            tbCodigo.TabStop = false;
            tbCodigo.TextAlign = HorizontalAlignment.Left;
            tbCodigo.TrailingIcon = null;
            tbCodigo.UseSystemPasswordChar = false;
            tbCodigo.KeyPress += tbCode_KeyPress;
            tbCodigo.TextChanged += tb_TextChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Top;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(0, 0);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(51, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Código";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dgvData, 0, 0);
            tableLayoutPanel4.Controls.Add(cbShowAll, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(323, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(474, 647);
            tableLayoutPanel4.TabIndex = 16;
            // 
            // dgvData
            // 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Fill;
            dgvData.Location = new Point(3, 3);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersVisible = false;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(468, 604);
            dgvData.TabIndex = 1;
            dgvData.CellMouseDoubleClick += dgvData_CellMouseDoubleClick;
            // 
            // cbShowAll
            // 
            cbShowAll.AutoSize = true;
            cbShowAll.Depth = 0;
            cbShowAll.Location = new Point(0, 610);
            cbShowAll.Margin = new Padding(0);
            cbShowAll.MouseLocation = new Point(-1, -1);
            cbShowAll.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cbShowAll.Name = "cbShowAll";
            cbShowAll.ReadOnly = false;
            cbShowAll.Ripple = true;
            cbShowAll.Size = new Size(134, 37);
            cbShowAll.TabIndex = 0;
            cbShowAll.Text = "Mostrar todos";
            cbShowAll.UseAccentColor = false;
            cbShowAll.UseVisualStyleBackColor = true;
            cbShowAll.CheckedChanged += cbShowAll_CheckedChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 677);
            Controls.Add(tableLayoutPanel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MinimumSize = new Size(800, 430);
            Name = "FormMain";
            Padding = new Padding(0, 24, 0, 0);
            Text = "Alta Baja y Modificación de Personas";
            Load += FormMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbStock;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCaracteristicas;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbModelo;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbMarca;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbTipo;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbCodigo;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton btnCancel;
        private ReaLTaiizor.Controls.PoisonDateTime dtFechaIngreso;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPrecio;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvData;
        private ReaLTaiizor.Controls.MaterialCheckBox cbShowAll;
    }
}
