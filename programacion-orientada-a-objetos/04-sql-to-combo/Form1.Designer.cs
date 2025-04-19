namespace _04_sql_to_combo
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
            cbData = new ComboBox();
            btnLoadCombo = new Button();
            btnUnloadCombo = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbData
            // 
            cbData.BackColor = Color.FromArgb(18, 18, 20);
            tableLayoutPanel1.SetColumnSpan(cbData, 2);
            cbData.Dock = DockStyle.Fill;
            cbData.DropDownStyle = ComboBoxStyle.DropDownList;
            cbData.FlatStyle = FlatStyle.Popup;
            cbData.ForeColor = Color.White;
            cbData.FormattingEnabled = true;
            cbData.Location = new Point(3, 43);
            cbData.Name = "cbData";
            cbData.Size = new Size(734, 23);
            cbData.TabIndex = 0;
            // 
            // btnLoadCombo
            // 
            btnLoadCombo.BackColor = Color.FromArgb(18, 18, 20);
            btnLoadCombo.Dock = DockStyle.Fill;
            btnLoadCombo.FlatStyle = FlatStyle.Popup;
            btnLoadCombo.ForeColor = Color.White;
            btnLoadCombo.Location = new Point(3, 3);
            btnLoadCombo.Name = "btnLoadCombo";
            btnLoadCombo.Size = new Size(364, 34);
            btnLoadCombo.TabIndex = 1;
            btnLoadCombo.Text = "Cargar ComboBox";
            btnLoadCombo.UseVisualStyleBackColor = false;
            btnLoadCombo.Click += btnLoadComboClick;
            btnLoadCombo.MouseEnter += btnHover;
            btnLoadCombo.MouseLeave += btnHoverLeave;
            // 
            // btnUnloadCombo
            // 
            btnUnloadCombo.BackColor = Color.FromArgb(18, 18, 20);
            btnUnloadCombo.Dock = DockStyle.Fill;
            btnUnloadCombo.FlatStyle = FlatStyle.Popup;
            btnUnloadCombo.ForeColor = Color.White;
            btnUnloadCombo.Location = new Point(373, 3);
            btnUnloadCombo.Name = "btnUnloadCombo";
            btnUnloadCombo.Size = new Size(364, 34);
            btnUnloadCombo.TabIndex = 2;
            btnUnloadCombo.Text = "Vaciar ComboBox";
            btnUnloadCombo.UseVisualStyleBackColor = false;
            btnUnloadCombo.Click += btnUnloadComboClick;
            btnUnloadCombo.MouseEnter += btnHover;
            btnUnloadCombo.MouseLeave += btnHoverLeave;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnLoadCombo, 0, 0);
            tableLayoutPanel1.Controls.Add(cbData, 0, 1);
            tableLayoutPanel1.Controls.Add(btnUnloadCombo, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(740, 131);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 30);
            ClientSize = new Size(740, 131);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(756, 170);
            Name = "Form1";
            Text = "ComboBox + SQL";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbData;
        private Button btnLoadCombo;
        private Button btnUnloadCombo;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
