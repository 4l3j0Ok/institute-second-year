﻿namespace _1_primeros_pasos
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
            btnClearAll = new Button();
            btnClearCurrent = new Button();
            btnPercent = new Button();
            btnDivision = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplcation = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btnComma = new Button();
            btn0 = new Button();
            btnRem = new Button();
            btnEqual = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbCalc
            // 
            tbCalc.BackColor = SystemColors.Window;
            tbCalc.Dock = DockStyle.Top;
            tbCalc.Font = new Font("Segoe UI", 40F);
            tbCalc.Location = new Point(3, 24);
            tbCalc.Name = "tbCalc";
            tbCalc.ReadOnly = true;
            tbCalc.Size = new Size(724, 78);
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
            tableLayoutPanel1.Controls.Add(btnClearAll, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClearCurrent, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPercent, 2, 0);
            tableLayoutPanel1.Controls.Add(btnDivision, 3, 0);
            tableLayoutPanel1.Controls.Add(btn7, 0, 1);
            tableLayoutPanel1.Controls.Add(btn8, 1, 1);
            tableLayoutPanel1.Controls.Add(btn9, 2, 1);
            tableLayoutPanel1.Controls.Add(btnMultiplcation, 3, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 2);
            tableLayoutPanel1.Controls.Add(btn5, 1, 2);
            tableLayoutPanel1.Controls.Add(btn6, 2, 2);
            tableLayoutPanel1.Controls.Add(btnMinus, 3, 2);
            tableLayoutPanel1.Controls.Add(btn1, 0, 3);
            tableLayoutPanel1.Controls.Add(btn2, 1, 3);
            tableLayoutPanel1.Controls.Add(btn3, 2, 3);
            tableLayoutPanel1.Controls.Add(btnPlus, 3, 3);
            tableLayoutPanel1.Controls.Add(btnComma, 0, 4);
            tableLayoutPanel1.Controls.Add(btn0, 1, 4);
            tableLayoutPanel1.Controls.Add(btnRem, 2, 4);
            tableLayoutPanel1.Controls.Add(btnEqual, 3, 4);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 112);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(724, 615);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.DarkRed;
            btnClearAll.Dock = DockStyle.Fill;
            btnClearAll.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClearAll.ForeColor = Color.White;
            btnClearAll.Location = new Point(3, 3);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(175, 117);
            btnClearAll.TabIndex = 0;
            btnClearAll.Text = "AC";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += onBtnClick;
            // 
            // btnClearCurrent
            // 
            btnClearCurrent.BackColor = Color.Orange;
            btnClearCurrent.Dock = DockStyle.Fill;
            btnClearCurrent.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClearCurrent.ForeColor = Color.White;
            btnClearCurrent.Location = new Point(184, 3);
            btnClearCurrent.Name = "btnClearCurrent";
            btnClearCurrent.Size = new Size(175, 117);
            btnClearCurrent.TabIndex = 1;
            btnClearCurrent.Text = "C";
            btnClearCurrent.UseVisualStyleBackColor = false;
            btnClearCurrent.Click += onBtnClick;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.RoyalBlue;
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPercent.ForeColor = Color.White;
            btnPercent.Location = new Point(365, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(175, 117);
            btnPercent.TabIndex = 2;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += onBtnClick;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.RoyalBlue;
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDivision.ForeColor = Color.White;
            btnDivision.Location = new Point(546, 3);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(175, 117);
            btnDivision.TabIndex = 3;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += onBtnClick;
            // 
            // btn7
            // 
            btn7.AutoSize = true;
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 14F);
            btn7.Location = new Point(3, 126);
            btn7.Name = "btn7";
            btn7.Size = new Size(175, 117);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += onBtnClick;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 14F);
            btn8.Location = new Point(184, 126);
            btn8.Name = "btn8";
            btn8.Size = new Size(175, 117);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += onBtnClick;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 14F);
            btn9.Location = new Point(365, 126);
            btn9.Name = "btn9";
            btn9.Size = new Size(175, 117);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += onBtnClick;
            // 
            // btnMultiplcation
            // 
            btnMultiplcation.BackColor = Color.RoyalBlue;
            btnMultiplcation.Dock = DockStyle.Fill;
            btnMultiplcation.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMultiplcation.ForeColor = Color.White;
            btnMultiplcation.Location = new Point(546, 126);
            btnMultiplcation.Name = "btnMultiplcation";
            btnMultiplcation.Size = new Size(175, 117);
            btnMultiplcation.TabIndex = 7;
            btnMultiplcation.Text = "*";
            btnMultiplcation.UseVisualStyleBackColor = false;
            btnMultiplcation.Click += onBtnClick;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 14F);
            btn4.Location = new Point(3, 249);
            btn4.Name = "btn4";
            btn4.Size = new Size(175, 117);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += onBtnClick;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 14F);
            btn5.Location = new Point(184, 249);
            btn5.Name = "btn5";
            btn5.Size = new Size(175, 117);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += onBtnClick;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 14F);
            btn6.Location = new Point(365, 249);
            btn6.Name = "btn6";
            btn6.Size = new Size(175, 117);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += onBtnClick;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.RoyalBlue;
            btnMinus.Dock = DockStyle.Fill;
            btnMinus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(546, 249);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(175, 117);
            btnMinus.TabIndex = 11;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += onBtnClick;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 14F);
            btn1.Location = new Point(3, 372);
            btn1.Name = "btn1";
            btn1.Size = new Size(175, 117);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += onBtnClick;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 14F);
            btn2.Location = new Point(184, 372);
            btn2.Name = "btn2";
            btn2.Size = new Size(175, 117);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += onBtnClick;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 14F);
            btn3.Location = new Point(365, 372);
            btn3.Name = "btn3";
            btn3.Size = new Size(175, 117);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += onBtnClick;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.RoyalBlue;
            btnPlus.Dock = DockStyle.Fill;
            btnPlus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(546, 372);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(175, 117);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += onBtnClick;
            // 
            // btnComma
            // 
            btnComma.Dock = DockStyle.Fill;
            btnComma.Font = new Font("Segoe UI", 14F);
            btnComma.Location = new Point(3, 495);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(175, 117);
            btnComma.TabIndex = 16;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += onBtnClick;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 14F);
            btn0.Location = new Point(184, 495);
            btn0.Name = "btn0";
            btn0.Size = new Size(175, 117);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += onBtnClick;
            // 
            // btnRem
            // 
            btnRem.BackColor = Color.Orange;
            btnRem.Dock = DockStyle.Fill;
            btnRem.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRem.ForeColor = Color.White;
            btnRem.Location = new Point(365, 495);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(175, 117);
            btnRem.TabIndex = 18;
            btnRem.Text = "<-";
            btnRem.UseVisualStyleBackColor = false;
            btnRem.Click += onBtnClick;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.RoyalBlue;
            btnEqual.Dock = DockStyle.Fill;
            btnEqual.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEqual.ForeColor = Color.White;
            btnEqual.Location = new Point(546, 495);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(175, 117);
            btnEqual.TabIndex = 19;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += onBtnClick;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 730);
            Controls.Add(tbCalc);
            Controls.Add(tableLayoutPanel1);
            FormStyle = FormStyles.ActionBar_None;
            MinimumSize = new Size(540, 730);
            Name = "FrmPrincipal";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbCalc;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClearAll;
        private Button btnClearCurrent;
        private Button btnPercent;
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
        private Button btnComma;
        private Button btn0;
        private Button btnRem;
        private Button btnEqual;
    }
}
