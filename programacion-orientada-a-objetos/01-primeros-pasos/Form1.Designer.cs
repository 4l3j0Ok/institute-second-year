namespace _1_primeros_pasos
{
    partial class FrmPrincipal
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
            tbCalc = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRem = new Button();
            btnClearAll = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDivision = new Button();
            btnMultiplcation = new Button();
            btnMinus = new Button();
            btnEqual = new Button();
            btnPlus = new Button();
            btnDot = new Button();
            btn0 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbCalc
            // 
            tbCalc.BackColor = SystemColors.Window;
            tbCalc.BorderStyle = BorderStyle.FixedSingle;
            tbCalc.Dock = DockStyle.Fill;
            tbCalc.Font = new Font("Segoe UI", 40F);
            tbCalc.Location = new Point(3, 3);
            tbCalc.Name = "tbCalc";
            tbCalc.ReadOnly = true;
            tbCalc.Size = new Size(402, 78);
            tbCalc.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnRem, 0, 4);
            tableLayoutPanel1.Controls.Add(btnClearAll, 0, 0);
            tableLayoutPanel1.Controls.Add(btn7, 0, 1);
            tableLayoutPanel1.Controls.Add(btn8, 1, 1);
            tableLayoutPanel1.Controls.Add(btn9, 2, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 2);
            tableLayoutPanel1.Controls.Add(btn5, 1, 2);
            tableLayoutPanel1.Controls.Add(btn6, 2, 2);
            tableLayoutPanel1.Controls.Add(btn1, 0, 3);
            tableLayoutPanel1.Controls.Add(btn2, 1, 3);
            tableLayoutPanel1.Controls.Add(btn3, 2, 3);
            tableLayoutPanel1.Controls.Add(btnDivision, 1, 0);
            tableLayoutPanel1.Controls.Add(btnMultiplcation, 2, 0);
            tableLayoutPanel1.Controls.Add(btnMinus, 3, 0);
            tableLayoutPanel1.Controls.Add(btnEqual, 3, 3);
            tableLayoutPanel1.Controls.Add(btnPlus, 3, 1);
            tableLayoutPanel1.Controls.Add(btnDot, 2, 4);
            tableLayoutPanel1.Controls.Add(btn0, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 87);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(402, 331);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // btnRem
            // 
            btnRem.AutoSize = true;
            btnRem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRem.BackColor = Color.Orange;
            btnRem.Dock = DockStyle.Fill;
            btnRem.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnRem.ForeColor = Color.White;
            btnRem.Location = new Point(0, 264);
            btnRem.Margin = new Padding(0);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(100, 67);
            btnRem.TabIndex = 20;
            btnRem.Text = "⬅";
            btnRem.UseVisualStyleBackColor = false;
            btnRem.Click += onBtnClick;
            // 
            // btnClearAll
            // 
            btnClearAll.AutoSize = true;
            btnClearAll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClearAll.BackColor = Color.DarkRed;
            btnClearAll.Dock = DockStyle.Fill;
            btnClearAll.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClearAll.ForeColor = Color.White;
            btnClearAll.Location = new Point(0, 0);
            btnClearAll.Margin = new Padding(0);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(100, 66);
            btnClearAll.TabIndex = 0;
            btnClearAll.Text = "AC";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += onBtnClick;
            // 
            // btn7
            // 
            btn7.AutoSize = true;
            btn7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 14F);
            btn7.Location = new Point(3, 69);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 60);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += onBtnClick;
            // 
            // btn8
            // 
            btn8.AutoSize = true;
            btn8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 14F);
            btn8.Location = new Point(103, 69);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 60);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += onBtnClick;
            // 
            // btn9
            // 
            btn9.AutoSize = true;
            btn9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 14F);
            btn9.Location = new Point(203, 69);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 60);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += onBtnClick;
            // 
            // btn4
            // 
            btn4.AutoSize = true;
            btn4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 14F);
            btn4.Location = new Point(3, 135);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 60);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += onBtnClick;
            // 
            // btn5
            // 
            btn5.AutoSize = true;
            btn5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 14F);
            btn5.Location = new Point(103, 135);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 60);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += onBtnClick;
            // 
            // btn6
            // 
            btn6.AutoSize = true;
            btn6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 14F);
            btn6.Location = new Point(203, 135);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 60);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += onBtnClick;
            // 
            // btn1
            // 
            btn1.AutoSize = true;
            btn1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 14F);
            btn1.Location = new Point(3, 201);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 60);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += onBtnClick;
            // 
            // btn2
            // 
            btn2.AutoSize = true;
            btn2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 14F);
            btn2.Location = new Point(103, 201);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 60);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += onBtnClick;
            // 
            // btn3
            // 
            btn3.AutoSize = true;
            btn3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 14F);
            btn3.Location = new Point(203, 201);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 60);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += onBtnClick;
            // 
            // btnDivision
            // 
            btnDivision.AutoSize = true;
            btnDivision.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDivision.BackColor = Color.RoyalBlue;
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDivision.ForeColor = Color.White;
            btnDivision.Location = new Point(103, 3);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(94, 60);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += onBtnClick;
            // 
            // btnMultiplcation
            // 
            btnMultiplcation.AutoSize = true;
            btnMultiplcation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMultiplcation.BackColor = Color.RoyalBlue;
            btnMultiplcation.Dock = DockStyle.Fill;
            btnMultiplcation.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMultiplcation.ForeColor = Color.White;
            btnMultiplcation.Location = new Point(203, 3);
            btnMultiplcation.Name = "btnMultiplcation";
            btnMultiplcation.Size = new Size(94, 60);
            btnMultiplcation.TabIndex = 7;
            btnMultiplcation.Text = "*";
            btnMultiplcation.UseVisualStyleBackColor = false;
            btnMultiplcation.Click += onBtnClick;
            // 
            // btnMinus
            // 
            btnMinus.AutoSize = true;
            btnMinus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMinus.BackColor = Color.RoyalBlue;
            btnMinus.Dock = DockStyle.Fill;
            btnMinus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(303, 3);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(96, 60);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += onBtnClick;
            // 
            // btnEqual
            // 
            btnEqual.AutoSize = true;
            btnEqual.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEqual.BackColor = Color.RoyalBlue;
            btnEqual.Dock = DockStyle.Fill;
            btnEqual.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEqual.ForeColor = Color.White;
            btnEqual.Location = new Point(303, 201);
            btnEqual.Name = "btnEqual";
            tableLayoutPanel1.SetRowSpan(btnEqual, 2);
            btnEqual.Size = new Size(96, 127);
            btnEqual.TabIndex = 19;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += onBtnClick;
            // 
            // btnPlus
            // 
            btnPlus.AutoSize = true;
            btnPlus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPlus.BackColor = Color.RoyalBlue;
            btnPlus.Dock = DockStyle.Fill;
            btnPlus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(303, 69);
            btnPlus.Name = "btnPlus";
            tableLayoutPanel1.SetRowSpan(btnPlus, 2);
            btnPlus.Size = new Size(96, 126);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += onBtnClick;
            // 
            // btnDot
            // 
            btnDot.AutoSize = true;
            btnDot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDot.Dock = DockStyle.Fill;
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnDot.Location = new Point(203, 267);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(94, 61);
            btnDot.TabIndex = 16;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += onBtnClick;
            // 
            // btn0
            // 
            btn0.AutoSize = true;
            btn0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 14F);
            btn0.Location = new Point(103, 267);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 61);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += onBtnClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(tbCalc, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(404, 421);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 421);
            Controls.Add(tableLayoutPanel2);
            MinimumSize = new Size(420, 460);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbCalc;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClearAll;
        private Button btnDivision;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplcation;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btnDot;
        private Button btn0;
        private Button btnEqual;
        private Button btnRem;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
