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
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Green;
            btnConnect.Dock = DockStyle.Fill;
            btnConnect.FlatStyle = FlatStyle.Popup;
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(15, 15);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(252, 23);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Conectar a base de datos";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.RoyalBlue;
            btnRead.Dock = DockStyle.Fill;
            btnRead.FlatStyle = FlatStyle.Popup;
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(273, 15);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(252, 23);
            btnRead.TabIndex = 2;
            btnRead.Text = "Leer datos";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.DarkGoldenrod;
            btnDisconnect.Dock = DockStyle.Fill;
            btnDisconnect.FlatStyle = FlatStyle.Popup;
            btnDisconnect.ForeColor = Color.White;
            btnDisconnect.Location = new Point(531, 15);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(254, 23);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Desconectar de base de datos";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Black;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(btnConnect, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDisconnect, 2, 0);
            tableLayoutPanel1.Controls.Add(btnRead, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(15, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(770, 391);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Clases globales";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnect;
        private Button btnRead;
        private Button btnDisconnect;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
    }
}
