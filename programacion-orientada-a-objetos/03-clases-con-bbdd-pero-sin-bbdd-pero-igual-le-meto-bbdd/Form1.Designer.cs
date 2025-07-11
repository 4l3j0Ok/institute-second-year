namespace _3_clases_con_bbdd_pero_sin_bbdd_pero_igual_le_meto_bbdd
{
    partial class Form1
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
            btnConnect = new Button();
            btnRead = new Button();
            btnDisconnect = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvMainData = new DataGridView();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbNombre = new TextBox();
            tbEdad = new TextBox();
            tbAnio = new TextBox();
            tbMateria = new TextBox();
            tbApellido = new TextBox();
            tbNota = new TextBox();
            tbCurso = new TextBox();
            label1 = new Label();
            btnModify = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainData).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Black;
            btnConnect.Dock = DockStyle.Fill;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(15, 15);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(241, 23);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Conectar a base de datos";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.Black;
            btnRead.Dock = DockStyle.Fill;
            btnRead.FlatStyle = FlatStyle.Flat;
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(262, 15);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(242, 23);
            btnRead.TabIndex = 2;
            btnRead.Text = "Leer datos";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.Black;
            btnDisconnect.Dock = DockStyle.Fill;
            btnDisconnect.FlatStyle = FlatStyle.Flat;
            btnDisconnect.ForeColor = Color.White;
            btnDisconnect.Location = new Point(510, 15);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(243, 23);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Desconectar de base de datos";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Black;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(btnConnect, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvMainData, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDisconnect, 2, 0);
            tableLayoutPanel1.Controls.Add(btnRead, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.4999962F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5000038F));
            tableLayoutPanel1.Size = new Size(768, 622);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // dgvMainData
            // 
            dgvMainData.AllowUserToAddRows = false;
            dgvMainData.AllowUserToDeleteRows = false;
            dgvMainData.AllowUserToResizeColumns = false;
            dgvMainData.AllowUserToResizeRows = false;
            dgvMainData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainData.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvMainData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvMainData, 3);
            dgvMainData.Dock = DockStyle.Fill;
            dgvMainData.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMainData.Location = new Point(15, 44);
            dgvMainData.MultiSelect = false;
            dgvMainData.Name = "dgvMainData";
            dgvMainData.ReadOnly = true;
            dgvMainData.RowHeadersVisible = false;
            dgvMainData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMainData.Size = new Size(738, 349);
            dgvMainData.TabIndex = 0;
            dgvMainData.SelectionChanged += dgvMainData_SelectionChanged;
            // 
            // panel1
            // 
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(12, 396);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 214);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.88889F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.88889F));
            tableLayoutPanel2.Controls.Add(label7, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 2, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 2, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(tbNombre, 1, 0);
            tableLayoutPanel2.Controls.Add(tbEdad, 1, 1);
            tableLayoutPanel2.Controls.Add(tbAnio, 1, 2);
            tableLayoutPanel2.Controls.Add(tbMateria, 1, 3);
            tableLayoutPanel2.Controls.Add(tbApellido, 3, 0);
            tableLayoutPanel2.Controls.Add(tbNota, 3, 1);
            tableLayoutPanel2.Controls.Add(tbCurso, 3, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnModify, 3, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(744, 214);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Left;
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 155);
            label7.Margin = new Padding(15);
            label7.Name = "label7";
            label7.Size = new Size(47, 39);
            label7.TabIndex = 14;
            label7.Text = "Materia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Left;
            label6.ForeColor = Color.White;
            label6.Location = new Point(386, 110);
            label6.Margin = new Padding(15);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 13;
            label6.Text = "Curso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Left;
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 110);
            label5.Margin = new Padding(15);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 12;
            label5.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Left;
            label4.ForeColor = Color.White;
            label4.Location = new Point(386, 65);
            label4.Margin = new Padding(15);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 11;
            label4.Text = "Nota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Left;
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 65);
            label3.Margin = new Padding(15);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Left;
            label2.ForeColor = Color.White;
            label2.Location = new Point(386, 20);
            label2.Margin = new Padding(15);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // tbNombre
            // 
            tbNombre.BackColor = Color.FromArgb(64, 64, 64);
            tbNombre.BorderStyle = BorderStyle.FixedSingle;
            tbNombre.Dock = DockStyle.Fill;
            tbNombre.ForeColor = Color.White;
            tbNombre.Location = new Point(96, 15);
            tbNombre.Margin = new Padding(10);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(265, 23);
            tbNombre.TabIndex = 0;
            // 
            // tbEdad
            // 
            tbEdad.BackColor = Color.FromArgb(64, 64, 64);
            tbEdad.BorderStyle = BorderStyle.FixedSingle;
            tbEdad.Dock = DockStyle.Fill;
            tbEdad.ForeColor = Color.White;
            tbEdad.Location = new Point(96, 60);
            tbEdad.Margin = new Padding(10);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(265, 23);
            tbEdad.TabIndex = 1;
            // 
            // tbAnio
            // 
            tbAnio.BackColor = Color.FromArgb(64, 64, 64);
            tbAnio.BorderStyle = BorderStyle.FixedSingle;
            tbAnio.Dock = DockStyle.Fill;
            tbAnio.ForeColor = Color.White;
            tbAnio.Location = new Point(96, 105);
            tbAnio.Margin = new Padding(10);
            tbAnio.Name = "tbAnio";
            tbAnio.Size = new Size(265, 23);
            tbAnio.TabIndex = 2;
            // 
            // tbMateria
            // 
            tbMateria.BackColor = Color.FromArgb(64, 64, 64);
            tbMateria.BorderStyle = BorderStyle.FixedSingle;
            tbMateria.Dock = DockStyle.Fill;
            tbMateria.ForeColor = Color.White;
            tbMateria.Location = new Point(96, 150);
            tbMateria.Margin = new Padding(10);
            tbMateria.Name = "tbMateria";
            tbMateria.Size = new Size(265, 23);
            tbMateria.TabIndex = 3;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = Color.FromArgb(64, 64, 64);
            tbApellido.BorderStyle = BorderStyle.FixedSingle;
            tbApellido.Dock = DockStyle.Fill;
            tbApellido.ForeColor = Color.White;
            tbApellido.Location = new Point(462, 15);
            tbApellido.Margin = new Padding(10);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(267, 23);
            tbApellido.TabIndex = 4;
            // 
            // tbNota
            // 
            tbNota.BackColor = Color.FromArgb(64, 64, 64);
            tbNota.BorderStyle = BorderStyle.FixedSingle;
            tbNota.Dock = DockStyle.Fill;
            tbNota.ForeColor = Color.White;
            tbNota.Location = new Point(462, 60);
            tbNota.Margin = new Padding(10);
            tbNota.Name = "tbNota";
            tbNota.Size = new Size(267, 23);
            tbNota.TabIndex = 5;
            // 
            // tbCurso
            // 
            tbCurso.BackColor = Color.FromArgb(64, 64, 64);
            tbCurso.BorderStyle = BorderStyle.FixedSingle;
            tbCurso.Dock = DockStyle.Fill;
            tbCurso.ForeColor = Color.White;
            tbCurso.Location = new Point(462, 105);
            tbCurso.Margin = new Padding(10);
            tbCurso.Name = "tbCurso";
            tbCurso.Size = new Size(267, 23);
            tbCurso.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Margin = new Padding(15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Black;
            btnModify.Dock = DockStyle.Top;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(462, 150);
            btnModify.Margin = new Padding(10);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(267, 23);
            btnModify.TabIndex = 15;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 622);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(784, 661);
            Name = "Form1";
            Text = "Clases globales";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMainData).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnect;
        private Button btnRead;
        private Button btnDisconnect;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvMainData;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbNombre;
        private TextBox tbEdad;
        private TextBox tbAnio;
        private TextBox tbMateria;
        private TextBox tbApellido;
        private TextBox tbNota;
        private TextBox tbCurso;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnModify;
    }
}
