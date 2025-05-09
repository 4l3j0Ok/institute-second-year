namespace _02_listbox
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
            groupBox1 = new GroupBox();
            lbMain = new ListBox();
            btnClearAll = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tbUserInput = new TextBox();
            groupBox3 = new GroupBox();
            tbInfo = new TextBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbMain);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            tableLayoutPanel1.SetRowSpan(groupBox1, 2);
            groupBox1.Size = new Size(384, 389);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de items";
            // 
            // lbMain
            // 
            lbMain.BackColor = Color.White;
            lbMain.Dock = DockStyle.Fill;
            lbMain.ForeColor = Color.Black;
            lbMain.FormattingEnabled = true;
            lbMain.ItemHeight = 15;
            lbMain.Location = new Point(3, 19);
            lbMain.Name = "lbMain";
            lbMain.Size = new Size(378, 367);
            lbMain.TabIndex = 1;
            lbMain.SelectedIndexChanged += lbMain_SelectedIndexChanged;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.DarkGoldenrod;
            tableLayoutPanel1.SetColumnSpan(btnClearAll, 2);
            btnClearAll.Dock = DockStyle.Fill;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.ForeColor = Color.White;
            btnClearAll.Location = new Point(13, 408);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(774, 29);
            btnClearAll.TabIndex = 1;
            btnClearAll.Text = "Limpiar todo";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += clearListBox;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(238, 238, 238);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnClearAll, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbUserInput);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(403, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 191);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar datos";
            // 
            // tbUserInput
            // 
            tbUserInput.BackColor = Color.White;
            tbUserInput.Dock = DockStyle.Fill;
            tbUserInput.ForeColor = Color.Black;
            tbUserInput.Location = new Point(3, 19);
            tbUserInput.Name = "tbUserInput";
            tbUserInput.PlaceholderText = "Ingrese aquí el texto a agregar";
            tbUserInput.Size = new Size(378, 23);
            tbUserInput.TabIndex = 3;
            tbUserInput.KeyPress += tbUserInput_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbInfo);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(403, 210);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 192);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información";
            // 
            // tbInfo
            // 
            tbInfo.Dock = DockStyle.Fill;
            tbInfo.Location = new Point(3, 19);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.ReadOnly = true;
            tbInfo.Size = new Size(378, 170);
            tbInfo.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listbox dinámico";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lbMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClearAll;
        private GroupBox groupBox2;
        private TextBox tbUserInput;
        private GroupBox groupBox3;
        private TextBox tbInfo;
    }
}
