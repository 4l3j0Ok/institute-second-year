namespace _01_explorando_properties
{
    partial class CalcularVuelto
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
            tbFirstValue = new TextBox();
            tbResult = new TextBox();
            tbSecondValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbFirstValue
            // 
            tbFirstValue.BackColor = Color.FromArgb(18, 18, 20);
            tbFirstValue.BorderStyle = BorderStyle.None;
            tbFirstValue.Dock = DockStyle.Fill;
            tbFirstValue.Font = new Font("Segoe UI", 12F);
            tbFirstValue.ForeColor = Color.Gainsboro;
            tbFirstValue.Location = new Point(3, 21);
            tbFirstValue.Name = "tbFirstValue";
            tbFirstValue.Size = new Size(453, 22);
            tbFirstValue.TabIndex = 1;
            tbFirstValue.TextChanged += x;
            tbFirstValue.KeyPress += TextboxHandler;
            // 
            // tbResult
            // 
            tbResult.BackColor = Color.FromArgb(18, 18, 20);
            tbResult.BorderStyle = BorderStyle.None;
            tbResult.Dock = DockStyle.Fill;
            tbResult.Font = new Font("Segoe UI", 12F);
            tbResult.ForeColor = Color.Gainsboro;
            tbResult.Location = new Point(3, 21);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(453, 22);
            tbResult.TabIndex = 3;
            // 
            // tbSecondValue
            // 
            tbSecondValue.BackColor = Color.FromArgb(18, 18, 20);
            tbSecondValue.BorderStyle = BorderStyle.None;
            tbSecondValue.Dock = DockStyle.Fill;
            tbSecondValue.Font = new Font("Segoe UI", 12F);
            tbSecondValue.ForeColor = Color.Gainsboro;
            tbSecondValue.Location = new Point(3, 21);
            tbSecondValue.Name = "tbSecondValue";
            tbSecondValue.Size = new Size(453, 22);
            tbSecondValue.TabIndex = 2;
            tbSecondValue.TextChanged += Calculate;
            tbSecondValue.KeyPress += TextboxHandler;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(459, 18);
            label1.TabIndex = 3;
            label1.Text = "Primer valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(459, 18);
            label2.TabIndex = 4;
            label2.Text = "Vuelto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(459, 18);
            label3.TabIndex = 5;
            label3.Text = "Segundo valor";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(8, 8);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 56);
            panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbFirstValue, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.Size = new Size(459, 56);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(8, 120);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 56);
            panel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(tbResult, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel3.Size = new Size(459, 56);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(8, 64);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 56);
            panel3.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tbSecondValue, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel2.Size = new Size(459, 56);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // CalcularVuelto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 30);
            ClientSize = new Size(475, 304);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(116, 116, 123);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CalcularVuelto";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcular vuelto";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbFirstValue;
        private TextBox tbResult;
        private TextBox tbSecondValue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
