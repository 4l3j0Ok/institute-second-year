namespace _04_conexion_bbdd
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
            dgvData = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            panel2 = new Panel();
            tbPhone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            tbEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            tbAddress = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            tbSurname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            tbName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            tbDNI = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(dgvData, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 495);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvData
            // 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Dock = DockStyle.Fill;
            dgvData.Location = new Point(323, 3);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersVisible = false;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(474, 489);
            dgvData.TabIndex = 0;
            dgvData.CellMouseDoubleClick += dgvData_CellMouseDoubleClick;
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
            tableLayoutPanel3.Size = new Size(314, 489);
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
            tableLayoutPanel2.Location = new Point(3, 442);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(308, 44);
            tableLayoutPanel2.TabIndex = 16;
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
            panel2.Controls.Add(tbPhone);
            panel2.Controls.Add(materialLabel6);
            panel2.Controls.Add(tbEmail);
            panel2.Controls.Add(materialLabel5);
            panel2.Controls.Add(tbAddress);
            panel2.Controls.Add(materialLabel4);
            panel2.Controls.Add(tbSurname);
            panel2.Controls.Add(materialLabel3);
            panel2.Controls.Add(tbName);
            panel2.Controls.Add(materialLabel2);
            panel2.Controls.Add(tbDNI);
            panel2.Controls.Add(materialLabel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 433);
            panel2.TabIndex = 15;
            // 
            // tbPhone
            // 
            tbPhone.AnimateReadOnly = false;
            tbPhone.AutoCompleteMode = AutoCompleteMode.None;
            tbPhone.AutoCompleteSource = AutoCompleteSource.None;
            tbPhone.BackgroundImageLayout = ImageLayout.None;
            tbPhone.CharacterCasing = CharacterCasing.Normal;
            tbPhone.Depth = 0;
            tbPhone.Dock = DockStyle.Top;
            tbPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPhone.HideSelection = true;
            tbPhone.LeadingIcon = null;
            tbPhone.Location = new Point(0, 354);
            tbPhone.MaxLength = 32767;
            tbPhone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbPhone.Name = "tbPhone";
            tbPhone.PasswordChar = '\0';
            tbPhone.PrefixSuffixText = null;
            tbPhone.ReadOnly = false;
            tbPhone.RightToLeft = RightToLeft.No;
            tbPhone.SelectedText = "";
            tbPhone.SelectionLength = 0;
            tbPhone.SelectionStart = 0;
            tbPhone.ShortcutsEnabled = true;
            tbPhone.Size = new Size(308, 48);
            tbPhone.TabIndex = 24;
            tbPhone.TabStop = false;
            tbPhone.TextAlign = HorizontalAlignment.Left;
            tbPhone.TrailingIcon = null;
            tbPhone.UseSystemPasswordChar = false;
            tbPhone.KeyPress += tbPhone_KeyPress;
            tbPhone.TextChanged += tb_TextChanged;
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
            materialLabel6.Size = new Size(64, 19);
            materialLabel6.TabIndex = 23;
            materialLabel6.Text = "Teléfono";
            // 
            // tbEmail
            // 
            tbEmail.AnimateReadOnly = false;
            tbEmail.AutoCompleteMode = AutoCompleteMode.None;
            tbEmail.AutoCompleteSource = AutoCompleteSource.None;
            tbEmail.BackgroundImageLayout = ImageLayout.None;
            tbEmail.CharacterCasing = CharacterCasing.Normal;
            tbEmail.Depth = 0;
            tbEmail.Dock = DockStyle.Top;
            tbEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbEmail.HideSelection = true;
            tbEmail.LeadingIcon = null;
            tbEmail.Location = new Point(0, 287);
            tbEmail.MaxLength = 32767;
            tbEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbEmail.Name = "tbEmail";
            tbEmail.PasswordChar = '\0';
            tbEmail.PrefixSuffixText = null;
            tbEmail.ReadOnly = false;
            tbEmail.RightToLeft = RightToLeft.No;
            tbEmail.SelectedText = "";
            tbEmail.SelectionLength = 0;
            tbEmail.SelectionStart = 0;
            tbEmail.ShortcutsEnabled = true;
            tbEmail.Size = new Size(308, 48);
            tbEmail.TabIndex = 22;
            tbEmail.TabStop = false;
            tbEmail.TextAlign = HorizontalAlignment.Left;
            tbEmail.TrailingIcon = null;
            tbEmail.UseSystemPasswordChar = false;
            tbEmail.TextChanged += tb_TextChanged;
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
            materialLabel5.Size = new Size(41, 19);
            materialLabel5.TabIndex = 21;
            materialLabel5.Text = "Email";
            // 
            // tbAddress
            // 
            tbAddress.AnimateReadOnly = false;
            tbAddress.AutoCompleteMode = AutoCompleteMode.None;
            tbAddress.AutoCompleteSource = AutoCompleteSource.None;
            tbAddress.BackgroundImageLayout = ImageLayout.None;
            tbAddress.CharacterCasing = CharacterCasing.Normal;
            tbAddress.Depth = 0;
            tbAddress.Dock = DockStyle.Top;
            tbAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbAddress.HideSelection = true;
            tbAddress.LeadingIcon = null;
            tbAddress.Location = new Point(0, 220);
            tbAddress.MaxLength = 32767;
            tbAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbAddress.Name = "tbAddress";
            tbAddress.PasswordChar = '\0';
            tbAddress.PrefixSuffixText = null;
            tbAddress.ReadOnly = false;
            tbAddress.RightToLeft = RightToLeft.No;
            tbAddress.SelectedText = "";
            tbAddress.SelectionLength = 0;
            tbAddress.SelectionStart = 0;
            tbAddress.ShortcutsEnabled = true;
            tbAddress.Size = new Size(308, 48);
            tbAddress.TabIndex = 20;
            tbAddress.TabStop = false;
            tbAddress.TextAlign = HorizontalAlignment.Left;
            tbAddress.TrailingIcon = null;
            tbAddress.UseSystemPasswordChar = false;
            tbAddress.TextChanged += tb_TextChanged;
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
            materialLabel4.Size = new Size(67, 19);
            materialLabel4.TabIndex = 19;
            materialLabel4.Text = "Dirección";
            // 
            // tbSurname
            // 
            tbSurname.AnimateReadOnly = false;
            tbSurname.AutoCompleteMode = AutoCompleteMode.None;
            tbSurname.AutoCompleteSource = AutoCompleteSource.None;
            tbSurname.BackgroundImageLayout = ImageLayout.None;
            tbSurname.CharacterCasing = CharacterCasing.Normal;
            tbSurname.Depth = 0;
            tbSurname.Dock = DockStyle.Top;
            tbSurname.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSurname.HideSelection = true;
            tbSurname.LeadingIcon = null;
            tbSurname.Location = new Point(0, 153);
            tbSurname.MaxLength = 32767;
            tbSurname.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbSurname.Name = "tbSurname";
            tbSurname.PasswordChar = '\0';
            tbSurname.PrefixSuffixText = null;
            tbSurname.ReadOnly = false;
            tbSurname.RightToLeft = RightToLeft.No;
            tbSurname.SelectedText = "";
            tbSurname.SelectionLength = 0;
            tbSurname.SelectionStart = 0;
            tbSurname.ShortcutsEnabled = true;
            tbSurname.Size = new Size(308, 48);
            tbSurname.TabIndex = 18;
            tbSurname.TabStop = false;
            tbSurname.TextAlign = HorizontalAlignment.Left;
            tbSurname.TrailingIcon = null;
            tbSurname.UseSystemPasswordChar = false;
            tbSurname.TextChanged += tb_TextChanged;
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
            materialLabel3.Size = new Size(58, 19);
            materialLabel3.TabIndex = 17;
            materialLabel3.Text = "Apellido";
            // 
            // tbName
            // 
            tbName.AnimateReadOnly = false;
            tbName.AutoCompleteMode = AutoCompleteMode.None;
            tbName.AutoCompleteSource = AutoCompleteSource.None;
            tbName.BackgroundImageLayout = ImageLayout.None;
            tbName.CharacterCasing = CharacterCasing.Normal;
            tbName.Depth = 0;
            tbName.Dock = DockStyle.Top;
            tbName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbName.HideSelection = true;
            tbName.LeadingIcon = null;
            tbName.Location = new Point(0, 86);
            tbName.MaxLength = 32767;
            tbName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbName.Name = "tbName";
            tbName.PasswordChar = '\0';
            tbName.PrefixSuffixText = null;
            tbName.ReadOnly = false;
            tbName.RightToLeft = RightToLeft.No;
            tbName.SelectedText = "";
            tbName.SelectionLength = 0;
            tbName.SelectionStart = 0;
            tbName.ShortcutsEnabled = true;
            tbName.Size = new Size(308, 48);
            tbName.TabIndex = 16;
            tbName.TabStop = false;
            tbName.TextAlign = HorizontalAlignment.Left;
            tbName.TrailingIcon = null;
            tbName.UseSystemPasswordChar = false;
            tbName.TextChanged += tb_TextChanged;
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
            materialLabel2.Size = new Size(57, 19);
            materialLabel2.TabIndex = 15;
            materialLabel2.Text = "Nombre";
            // 
            // tbDNI
            // 
            tbDNI.AnimateReadOnly = false;
            tbDNI.AutoCompleteMode = AutoCompleteMode.None;
            tbDNI.AutoCompleteSource = AutoCompleteSource.None;
            tbDNI.BackgroundImageLayout = ImageLayout.None;
            tbDNI.CharacterCasing = CharacterCasing.Normal;
            tbDNI.Depth = 0;
            tbDNI.Dock = DockStyle.Top;
            tbDNI.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDNI.HideSelection = true;
            tbDNI.LeadingIcon = null;
            tbDNI.Location = new Point(0, 19);
            tbDNI.MaxLength = 32767;
            tbDNI.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbDNI.Name = "tbDNI";
            tbDNI.PasswordChar = '\0';
            tbDNI.PrefixSuffixText = null;
            tbDNI.ReadOnly = false;
            tbDNI.RightToLeft = RightToLeft.No;
            tbDNI.SelectedText = "";
            tbDNI.SelectionLength = 0;
            tbDNI.SelectionStart = 0;
            tbDNI.ShortcutsEnabled = true;
            tbDNI.Size = new Size(308, 48);
            tbDNI.TabIndex = 14;
            tbDNI.TabStop = false;
            tbDNI.TextAlign = HorizontalAlignment.Left;
            tbDNI.TrailingIcon = null;
            tbDNI.UseSystemPasswordChar = false;
            tbDNI.KeyPress += tbDNI_KeyPress;
            tbDNI.TextChanged += tb_TextChanged;
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
            materialLabel1.Size = new Size(27, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "DNI";
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(tableLayoutPanel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_None;
            MinimumSize = new Size(800, 430);
            Name = "FormMain";
            Padding = new Padding(0, 24, 0, 0);
            Text = "Alta Baja y Modificación de Personas";
            Load += FormMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvData;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPhone;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbEmail;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbAddress;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbSurname;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbName;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbDNI;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton btnCancel;
    }
}
