namespace _01_explorando_properties
{
    partial class CalculateRest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateRest));
            tbFirstValue = new TextBox();
            tbSecondValue = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label9 = new Label();
            tbRest = new TextBox();
            label8 = new Label();
            tbRest2000 = new TextBox();
            label2 = new Label();
            tbRest1000 = new TextBox();
            label7 = new Label();
            tbRest500 = new TextBox();
            label4 = new Label();
            tbRest200 = new TextBox();
            label6 = new Label();
            tbRest100 = new TextBox();
            label5 = new Label();
            tbRest50 = new TextBox();
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
            tbFirstValue.BorderStyle = BorderStyle.FixedSingle;
            tbFirstValue.Dock = DockStyle.Fill;
            tbFirstValue.Font = new Font("Segoe UI", 12F);
            tbFirstValue.ForeColor = Color.Gainsboro;
            tbFirstValue.Location = new Point(3, 24);
            tbFirstValue.Name = "tbFirstValue";
            tbFirstValue.Size = new Size(581, 29);
            tbFirstValue.TabIndex = 1;
            tbFirstValue.TextChanged += Calculate;
            tbFirstValue.KeyPress += TextboxHandler;
            // 
            // tbSecondValue
            // 
            tbSecondValue.BackColor = Color.FromArgb(18, 18, 20);
            tbSecondValue.BorderStyle = BorderStyle.FixedSingle;
            tbSecondValue.Dock = DockStyle.Fill;
            tbSecondValue.Font = new Font("Segoe UI", 12F);
            tbSecondValue.ForeColor = Color.Gainsboro;
            tbSecondValue.Location = new Point(3, 24);
            tbSecondValue.Name = "tbSecondValue";
            tbSecondValue.Size = new Size(581, 29);
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
            label1.Size = new Size(587, 21);
            label1.TabIndex = 0;
            label1.Text = "Monto ingresado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(587, 21);
            label3.TabIndex = 1;
            label3.Text = "Valor del producto";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(8, 8);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 56);
            panel1.TabIndex = 0;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.9644928F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.0355072F));
            tableLayoutPanel1.Size = new Size(587, 56);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(8, 120);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(587, 211);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(tbRest, 1, 0);
            tableLayoutPanel3.Controls.Add(label8, 0, 6);
            tableLayoutPanel3.Controls.Add(tbRest2000, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(tbRest1000, 1, 2);
            tableLayoutPanel3.Controls.Add(label7, 0, 5);
            tableLayoutPanel3.Controls.Add(tbRest500, 1, 3);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(tbRest200, 1, 4);
            tableLayoutPanel3.Controls.Add(label6, 0, 4);
            tableLayoutPanel3.Controls.Add(tbRest100, 1, 5);
            tableLayoutPanel3.Controls.Add(label5, 0, 3);
            tableLayoutPanel3.Controls.Add(tbRest50, 1, 6);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(587, 211);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 3);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Padding = new Padding(4);
            label9.Size = new Size(287, 23);
            label9.TabIndex = 6;
            label9.Text = "El vuelto es:";
            // 
            // tbRest
            // 
            tbRest.BackColor = Color.FromArgb(18, 18, 20);
            tbRest.BorderStyle = BorderStyle.FixedSingle;
            tbRest.Dock = DockStyle.Fill;
            tbRest.ForeColor = Color.White;
            tbRest.Location = new Point(296, 3);
            tbRest.Name = "tbRest";
            tbRest.ReadOnly = true;
            tbRest.Size = new Size(288, 23);
            tbRest.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(0, 174);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Padding = new Padding(4);
            label8.Size = new Size(293, 37);
            label8.TabIndex = 0;
            label8.Text = "La cantidad de billetes de 50 es: ";
            // 
            // tbRest2000
            // 
            tbRest2000.BackColor = Color.FromArgb(18, 18, 20);
            tbRest2000.BorderStyle = BorderStyle.FixedSingle;
            tbRest2000.Dock = DockStyle.Fill;
            tbRest2000.ForeColor = Color.White;
            tbRest2000.Location = new Point(296, 32);
            tbRest2000.Name = "tbRest2000";
            tbRest2000.ReadOnly = true;
            tbRest2000.Size = new Size(288, 23);
            tbRest2000.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 32);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Padding = new Padding(4);
            label2.Size = new Size(287, 23);
            label2.TabIndex = 5;
            label2.Text = "La cantidad de billetes de 2000 es: ";
            // 
            // tbRest1000
            // 
            tbRest1000.BackColor = Color.FromArgb(18, 18, 20);
            tbRest1000.BorderStyle = BorderStyle.FixedSingle;
            tbRest1000.Dock = DockStyle.Fill;
            tbRest1000.ForeColor = Color.White;
            tbRest1000.Location = new Point(296, 61);
            tbRest1000.Name = "tbRest1000";
            tbRest1000.ReadOnly = true;
            tbRest1000.Size = new Size(288, 23);
            tbRest1000.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(0, 145);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Padding = new Padding(4);
            label7.Size = new Size(293, 29);
            label7.TabIndex = 1;
            label7.Text = "La cantidad de billetes de 100 es: ";
            // 
            // tbRest500
            // 
            tbRest500.BackColor = Color.FromArgb(18, 18, 20);
            tbRest500.BorderStyle = BorderStyle.FixedSingle;
            tbRest500.Dock = DockStyle.Fill;
            tbRest500.ForeColor = Color.White;
            tbRest500.Location = new Point(296, 90);
            tbRest500.Name = "tbRest500";
            tbRest500.ReadOnly = true;
            tbRest500.Size = new Size(288, 23);
            tbRest500.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 61);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Padding = new Padding(4);
            label4.Size = new Size(287, 23);
            label4.TabIndex = 4;
            label4.Text = "La cantidad de billetes de 1000 es: ";
            // 
            // tbRest200
            // 
            tbRest200.BackColor = Color.FromArgb(18, 18, 20);
            tbRest200.BorderStyle = BorderStyle.FixedSingle;
            tbRest200.Dock = DockStyle.Fill;
            tbRest200.ForeColor = Color.White;
            tbRest200.Location = new Point(296, 119);
            tbRest200.Name = "tbRest200";
            tbRest200.ReadOnly = true;
            tbRest200.Size = new Size(288, 23);
            tbRest200.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(0, 116);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Padding = new Padding(4);
            label6.Size = new Size(293, 29);
            label6.TabIndex = 2;
            label6.Text = "La cantidad de billetes de 200 es: ";
            // 
            // tbRest100
            // 
            tbRest100.BackColor = Color.FromArgb(18, 18, 20);
            tbRest100.BorderStyle = BorderStyle.FixedSingle;
            tbRest100.Dock = DockStyle.Fill;
            tbRest100.ForeColor = Color.White;
            tbRest100.Location = new Point(296, 148);
            tbRest100.Name = "tbRest100";
            tbRest100.ReadOnly = true;
            tbRest100.Size = new Size(288, 23);
            tbRest100.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(0, 87);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Padding = new Padding(4);
            label5.Size = new Size(293, 29);
            label5.TabIndex = 3;
            label5.Text = "La cantidad de billetes de 500 es: ";
            // 
            // tbRest50
            // 
            tbRest50.BackColor = Color.FromArgb(18, 18, 20);
            tbRest50.BorderStyle = BorderStyle.FixedSingle;
            tbRest50.Dock = DockStyle.Fill;
            tbRest50.ForeColor = Color.White;
            tbRest50.Location = new Point(296, 177);
            tbRest50.Name = "tbRest50";
            tbRest50.ReadOnly = true;
            tbRest50.Size = new Size(288, 23);
            tbRest50.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(8, 64);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(587, 56);
            panel3.TabIndex = 1;
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel2.Size = new Size(587, 56);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // CalculateRest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 30);
            ClientSize = new Size(603, 339);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(116, 116, 123);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(619, 378);
            Name = "CalculateRest";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de vuelto";
            Load += CalculateRest_Load;
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
        private TextBox tbSecondValue;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label8;
        private Label label7;
        private TextBox tbRest100;
        private TextBox tbRest200;
        private TextBox tbRest500;
        private TextBox tbRest1000;
        private TextBox tbRest2000;
        private TextBox tbRest;
        private Label label9;
        private TextBox tbRest50;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
