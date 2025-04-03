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
            tbSecondValue = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label9 = new Label();
            tbVuelto50 = new TextBox();
            tbVuelto100 = new TextBox();
            tbVuelto200 = new TextBox();
            tbVuelto500 = new TextBox();
            tbVuelto1000 = new TextBox();
            tbVuelto2000 = new TextBox();
            tbVuelto = new TextBox();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            tbFirstValue.Location = new Point(3, 21);
            tbFirstValue.Name = "tbFirstValue";
            tbFirstValue.Size = new Size(547, 29);
            tbFirstValue.TabIndex = 1;
            tbFirstValue.KeyPress += TextboxHandler;
            // 
            // tbSecondValue
            // 
            tbSecondValue.BackColor = Color.FromArgb(18, 18, 20);
            tbSecondValue.BorderStyle = BorderStyle.FixedSingle;
            tbSecondValue.Dock = DockStyle.Fill;
            tbSecondValue.Font = new Font("Segoe UI", 12F);
            tbSecondValue.ForeColor = Color.Gainsboro;
            tbSecondValue.Location = new Point(3, 21);
            tbSecondValue.Name = "tbSecondValue";
            tbSecondValue.Size = new Size(547, 29);
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
            label1.Size = new Size(553, 18);
            label1.TabIndex = 3;
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
            label3.Size = new Size(553, 18);
            label3.TabIndex = 5;
            label3.Text = "Valor del producto";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(8, 8);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 56);
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
            tableLayoutPanel1.Size = new Size(553, 56);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(8, 120);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(553, 176);
            panel2.TabIndex = 7;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label9);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tbVuelto50);
            splitContainer1.Panel2.Controls.Add(tbVuelto100);
            splitContainer1.Panel2.Controls.Add(tbVuelto200);
            splitContainer1.Panel2.Controls.Add(tbVuelto500);
            splitContainer1.Panel2.Controls.Add(tbVuelto1000);
            splitContainer1.Panel2.Controls.Add(tbVuelto2000);
            splitContainer1.Panel2.Controls.Add(tbVuelto);
            splitContainer1.Size = new Size(553, 176);
            splitContainer1.SplitterDistance = 184;
            splitContainer1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(0, 138);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Padding = new Padding(4);
            label8.Size = new Size(183, 23);
            label8.TabIndex = 5;
            label8.Text = "La cantidad de billetes de 50 es: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(0, 115);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Padding = new Padding(4);
            label7.Size = new Size(189, 23);
            label7.TabIndex = 4;
            label7.Text = "La cantidad de billetes de 100 es: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(0, 92);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Padding = new Padding(4);
            label6.Size = new Size(189, 23);
            label6.TabIndex = 3;
            label6.Text = "La cantidad de billetes de 200 es: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 69);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Padding = new Padding(4);
            label5.Size = new Size(189, 23);
            label5.TabIndex = 2;
            label5.Text = "La cantidad de billetes de 500 es: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 46);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Padding = new Padding(4);
            label4.Size = new Size(195, 23);
            label4.TabIndex = 1;
            label4.Text = "La cantidad de billetes de 1000 es: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 23);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Padding = new Padding(4);
            label2.Size = new Size(195, 23);
            label2.TabIndex = 0;
            label2.Text = "La cantidad de billetes de 2000 es: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Padding = new Padding(4);
            label9.Size = new Size(77, 23);
            label9.TabIndex = 6;
            label9.Text = "El vuelto es:";
            // 
            // tbVuelto50
            // 
            tbVuelto50.BackColor = Color.FromArgb(18, 18, 20);
            tbVuelto50.BorderStyle = BorderStyle.FixedSingle;
            tbVuelto50.Dock = DockStyle.Top;
            tbVuelto50.ForeColor = Color.White;
            tbVuelto50.Location = new Point(0, 138);
            tbVuelto50.Name = "tbVuelto50";
            tbVuelto50.ReadOnly = true;
            tbVuelto50.Size = new Size(365, 23);
            tbVuelto50.TabIndex = 6;
            // 
            // tbVuelto100
            // 
            tbVuelto100.BackColor = Color.FromArgb(18, 18, 20);
            tbVuelto100.BorderStyle = BorderStyle.FixedSingle;
            tbVuelto100.Dock = DockStyle.Top;
            tbVuelto100.ForeColor = Color.White;
            tbVuelto100.Location = new Point(0, 115);
            tbVuelto100.Name = "tbVuelto100";
            tbVuelto100.ReadOnly = true;
            tbVuelto100.Size = new Size(365, 23);
            tbVuelto100.TabIndex = 5;
            // 
            // tbVuelto200
            // 
            tbVuelto200.BackColor = Color.FromArgb(18, 18, 20);
            tbVuelto200.BorderStyle = BorderStyle.FixedSingle;
            tbVuelto200.Dock = DockStyle.Top;
            tbVuelto200.ForeColor = Color.White;
            tbVuelto200.Location = new Point(0, 92);
            tbVuelto200.Name = "tbVuelto200";
            tbVuelto200.ReadOnly = true;
            tbVuelto200.Size = new Size(365, 23);
            tbVuelto200.TabIndex = 4;
            // 
            // tbVuelto500
            // 
            tbVuelto500.BackColor = Color.FromArgb(18, 18, 20);
            tbVuelto500.BorderStyle = BorderStyle.FixedSingle;
            tbVuelto500.Dock = DockStyle.Top;
            tbVuelto500.ForeColor = Color.White;
            tbVuelto500.Location = new Point(0, 69);
            tbVuelto500.Name = "tbVuelto500";
            tbVuelto500.ReadOnly = true;
            tbVuelto500.Size = new Size(365, 23);
            tbVuelto500.TabIndex = 3;
            // 
            // tbVuelto1000
            // 
            tbVuelto1000.BackColor = Color.FromArgb(18, 18, 20);
            tbVuelto1000.BorderStyle = BorderStyle.FixedSingle;
            tbVuelto1000.Dock = DockStyle.Top;
            tbVuelto1000.ForeColor = Color.White;
            tbVuelto1000.Location = new Point(0, 46);
            tbVuelto1000.Name = "tbVuelto1000";
            tbVuelto1000.ReadOnly = true;
            tbVuelto1000.Size = new Size(365, 23);
            tbVuelto1000.TabIndex = 2;
            // 
            // tbVuelto2000
            // 
            tbVuelto2000.BackColor = Color.FromArgb(18, 18, 20);
            tbVuelto2000.BorderStyle = BorderStyle.FixedSingle;
            tbVuelto2000.Dock = DockStyle.Top;
            tbVuelto2000.ForeColor = Color.White;
            tbVuelto2000.Location = new Point(0, 23);
            tbVuelto2000.Name = "tbVuelto2000";
            tbVuelto2000.ReadOnly = true;
            tbVuelto2000.Size = new Size(365, 23);
            tbVuelto2000.TabIndex = 1;
            // 
            // tbVuelto
            // 
            tbVuelto.BackColor = Color.FromArgb(18, 18, 20);
            tbVuelto.BorderStyle = BorderStyle.FixedSingle;
            tbVuelto.Dock = DockStyle.Top;
            tbVuelto.ForeColor = Color.White;
            tbVuelto.Location = new Point(0, 0);
            tbVuelto.Name = "tbVuelto";
            tbVuelto.ReadOnly = true;
            tbVuelto.Size = new Size(365, 23);
            tbVuelto.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(8, 64);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(553, 56);
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
            tableLayoutPanel2.Size = new Size(553, 56);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // CalcularVuelto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 30);
            ClientSize = new Size(569, 307);
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private SplitContainer splitContainer1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label8;
        private Label label7;
        private TextBox tbVuelto100;
        private TextBox tbVuelto200;
        private TextBox tbVuelto500;
        private TextBox tbVuelto1000;
        private TextBox tbVuelto2000;
        private TextBox tbVuelto;
        private Label label9;
        private TextBox tbVuelto50;
    }
}
