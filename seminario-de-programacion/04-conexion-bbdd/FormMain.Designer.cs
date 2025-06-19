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
            panel1 = new Panel();
            tbPhone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(dgvData, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
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
            dgvData.CellContentDoubleClick += dgvData_CellContentDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbPhone);
            panel1.Controls.Add(materialLabel6);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(materialLabel5);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(materialLabel4);
            panel1.Controls.Add(tbSurname);
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(tbDNI);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(314, 489);
            panel1.TabIndex = 1;
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
            tbPhone.Location = new Point(10, 364);
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
            tbPhone.Size = new Size(294, 48);
            tbPhone.TabIndex = 12;
            tbPhone.TabStop = false;
            tbPhone.TextAlign = HorizontalAlignment.Left;
            tbPhone.TrailingIcon = null;
            tbPhone.UseSystemPasswordChar = false;
            tbPhone.TextChanged += tb_TextChanged;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Dock = DockStyle.Top;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(10, 345);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(64, 19);
            materialLabel6.TabIndex = 11;
            materialLabel6.Text = "Teléfono";
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Enabled = false;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSave.Location = new Point(10, 443);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(294, 36);
            btnSave.TabIndex = 10;
            btnSave.Text = "Guardar";
            btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            tbEmail.Location = new Point(10, 297);
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
            tbEmail.Size = new Size(294, 48);
            tbEmail.TabIndex = 9;
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
            materialLabel5.Location = new Point(10, 278);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(41, 19);
            materialLabel5.TabIndex = 8;
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
            tbAddress.Location = new Point(10, 230);
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
            tbAddress.Size = new Size(294, 48);
            tbAddress.TabIndex = 7;
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
            materialLabel4.Location = new Point(10, 211);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(67, 19);
            materialLabel4.TabIndex = 6;
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
            tbSurname.Location = new Point(10, 163);
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
            tbSurname.Size = new Size(294, 48);
            tbSurname.TabIndex = 5;
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
            materialLabel3.Location = new Point(10, 144);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(58, 19);
            materialLabel3.TabIndex = 4;
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
            tbName.Location = new Point(10, 96);
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
            tbName.Size = new Size(294, 48);
            tbName.TabIndex = 3;
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
            materialLabel2.Location = new Point(10, 77);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(57, 19);
            materialLabel2.TabIndex = 2;
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
            tbDNI.Location = new Point(10, 29);
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
            tbDNI.Size = new Size(294, 48);
            tbDNI.TabIndex = 1;
            tbDNI.TabStop = false;
            tbDNI.TextAlign = HorizontalAlignment.Left;
            tbDNI.TrailingIcon = null;
            tbDNI.UseSystemPasswordChar = false;
            tbDNI.TextChanged += tb_TextChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Top;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(10, 10);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(27, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "DNI";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvData;
        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
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
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbPhone;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
    }
}
