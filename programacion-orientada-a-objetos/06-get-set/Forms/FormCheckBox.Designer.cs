namespace _06_get_set
{
    partial class FormCheckBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel7 = new Panel();
            rbMany3 = new RadioButton();
            rbMany2 = new RadioButton();
            rbMany1 = new RadioButton();
            panel8 = new Panel();
            tbRbManyChecked = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel5 = new Panel();
            cbMany3 = new CheckBox();
            cbMany2 = new CheckBox();
            cbMany1 = new CheckBox();
            panel6 = new Panel();
            tbCbManyChecked = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            rbOnlyOne3 = new RadioButton();
            rbOnlyOne2 = new RadioButton();
            rbOnlyOne1 = new RadioButton();
            panel4 = new Panel();
            tbRbOnlyOneChecked = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            cbOnlyOne3 = new CheckBox();
            cbOnlyOne2 = new CheckBox();
            cbOnlyOne1 = new CheckBox();
            panel2 = new Panel();
            tbCbOnlyOneChecked = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel5);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(403, 228);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(394, 219);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "RadioButton mas de uno tildado";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel7, 0, 0);
            tableLayoutPanel5.Controls.Add(panel8, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(388, 197);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Controls.Add(rbMany3);
            panel7.Controls.Add(rbMany2);
            panel7.Controls.Add(rbMany1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(9);
            panel7.Size = new Size(188, 191);
            panel7.TabIndex = 5;
            // 
            // rbMany3
            // 
            rbMany3.AutoSize = true;
            rbMany3.Dock = DockStyle.Top;
            rbMany3.Location = new Point(9, 47);
            rbMany3.Name = "rbMany3";
            rbMany3.Size = new Size(170, 19);
            rbMany3.TabIndex = 8;
            rbMany3.TabStop = true;
            rbMany3.Text = "radioButton4";
            rbMany3.UseVisualStyleBackColor = true;
            rbMany3.CheckedChanged += RadioButtonCheckedChanged;
            // 
            // rbMany2
            // 
            rbMany2.AutoSize = true;
            rbMany2.Dock = DockStyle.Top;
            rbMany2.Location = new Point(9, 28);
            rbMany2.Name = "rbMany2";
            rbMany2.Size = new Size(170, 19);
            rbMany2.TabIndex = 7;
            rbMany2.TabStop = true;
            rbMany2.Text = "radioButton5";
            rbMany2.UseVisualStyleBackColor = true;
            rbMany2.CheckedChanged += RadioButtonCheckedChanged;
            // 
            // rbMany1
            // 
            rbMany1.AutoSize = true;
            rbMany1.Dock = DockStyle.Top;
            rbMany1.Location = new Point(9, 9);
            rbMany1.Name = "rbMany1";
            rbMany1.Size = new Size(170, 19);
            rbMany1.TabIndex = 6;
            rbMany1.TabStop = true;
            rbMany1.Text = "radioButton6";
            rbMany1.UseVisualStyleBackColor = true;
            rbMany1.CheckedChanged += RadioButtonCheckedChanged;
            // 
            // panel8
            // 
            panel8.Controls.Add(tbRbManyChecked);
            panel8.Controls.Add(label4);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(197, 3);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(9);
            panel8.Size = new Size(188, 191);
            panel8.TabIndex = 6;
            // 
            // tbRbManyChecked
            // 
            tbRbManyChecked.Dock = DockStyle.Top;
            tbRbManyChecked.Location = new Point(9, 24);
            tbRbManyChecked.Name = "tbRbManyChecked";
            tbRbManyChecked.Size = new Size(170, 23);
            tbRbManyChecked.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(9, 9);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Tildados";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel4);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 228);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(394, 219);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "CheckBox mas de uno tildado";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel5, 0, 0);
            tableLayoutPanel4.Controls.Add(panel6, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(388, 197);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Controls.Add(cbMany3);
            panel5.Controls.Add(cbMany2);
            panel5.Controls.Add(cbMany1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(9);
            panel5.Size = new Size(188, 191);
            panel5.TabIndex = 5;
            // 
            // cbMany3
            // 
            cbMany3.AutoSize = true;
            cbMany3.Dock = DockStyle.Top;
            cbMany3.Location = new Point(9, 47);
            cbMany3.Name = "cbMany3";
            cbMany3.Size = new Size(170, 19);
            cbMany3.TabIndex = 2;
            cbMany3.Text = "checkBox7";
            cbMany3.UseVisualStyleBackColor = true;
            cbMany3.CheckedChanged += CheckBoxCheckedChanged;
            // 
            // cbMany2
            // 
            cbMany2.AutoSize = true;
            cbMany2.Dock = DockStyle.Top;
            cbMany2.Location = new Point(9, 28);
            cbMany2.Name = "cbMany2";
            cbMany2.Size = new Size(170, 19);
            cbMany2.TabIndex = 1;
            cbMany2.Text = "checkBox8";
            cbMany2.UseVisualStyleBackColor = true;
            cbMany2.CheckedChanged += CheckBoxCheckedChanged;
            // 
            // cbMany1
            // 
            cbMany1.AutoSize = true;
            cbMany1.Dock = DockStyle.Top;
            cbMany1.Location = new Point(9, 9);
            cbMany1.Name = "cbMany1";
            cbMany1.Size = new Size(170, 19);
            cbMany1.TabIndex = 0;
            cbMany1.Text = "checkBox9";
            cbMany1.UseVisualStyleBackColor = true;
            cbMany1.CheckedChanged += CheckBoxCheckedChanged;
            // 
            // panel6
            // 
            panel6.Controls.Add(tbCbManyChecked);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(197, 3);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(9);
            panel6.Size = new Size(188, 191);
            panel6.TabIndex = 6;
            // 
            // tbCbManyChecked
            // 
            tbCbManyChecked.Dock = DockStyle.Top;
            tbCbManyChecked.Location = new Point(9, 24);
            tbCbManyChecked.Name = "tbCbManyChecked";
            tbCbManyChecked.Size = new Size(170, 23);
            tbCbManyChecked.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(9, 9);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Tildados";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(403, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 219);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "RadioButton solo uno tildado";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Controls.Add(panel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(388, 197);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbOnlyOne3);
            panel3.Controls.Add(rbOnlyOne2);
            panel3.Controls.Add(rbOnlyOne1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(9);
            panel3.Size = new Size(188, 191);
            panel3.TabIndex = 5;
            // 
            // rbOnlyOne3
            // 
            rbOnlyOne3.AutoSize = true;
            rbOnlyOne3.Dock = DockStyle.Top;
            rbOnlyOne3.Location = new Point(9, 47);
            rbOnlyOne3.Name = "rbOnlyOne3";
            rbOnlyOne3.Size = new Size(170, 19);
            rbOnlyOne3.TabIndex = 5;
            rbOnlyOne3.TabStop = true;
            rbOnlyOne3.Text = "radioButton3";
            rbOnlyOne3.UseVisualStyleBackColor = true;
            rbOnlyOne3.CheckedChanged += RadioButtonCheckedChanged;
            // 
            // rbOnlyOne2
            // 
            rbOnlyOne2.AutoSize = true;
            rbOnlyOne2.Dock = DockStyle.Top;
            rbOnlyOne2.Location = new Point(9, 28);
            rbOnlyOne2.Name = "rbOnlyOne2";
            rbOnlyOne2.Size = new Size(170, 19);
            rbOnlyOne2.TabIndex = 4;
            rbOnlyOne2.TabStop = true;
            rbOnlyOne2.Text = "radioButton2";
            rbOnlyOne2.UseVisualStyleBackColor = true;
            rbOnlyOne2.CheckedChanged += RadioButtonCheckedChanged;
            // 
            // rbOnlyOne1
            // 
            rbOnlyOne1.AutoSize = true;
            rbOnlyOne1.Dock = DockStyle.Top;
            rbOnlyOne1.Location = new Point(9, 9);
            rbOnlyOne1.Name = "rbOnlyOne1";
            rbOnlyOne1.Size = new Size(170, 19);
            rbOnlyOne1.TabIndex = 3;
            rbOnlyOne1.TabStop = true;
            rbOnlyOne1.Text = "radioButton1";
            rbOnlyOne1.UseVisualStyleBackColor = true;
            rbOnlyOne1.CheckedChanged += RadioButtonCheckedChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbRbOnlyOneChecked);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(197, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(9);
            panel4.Size = new Size(188, 191);
            panel4.TabIndex = 6;
            // 
            // tbRbOnlyOneChecked
            // 
            tbRbOnlyOneChecked.Dock = DockStyle.Top;
            tbRbOnlyOneChecked.Location = new Point(9, 24);
            tbRbOnlyOneChecked.Name = "tbRbOnlyOneChecked";
            tbRbOnlyOneChecked.Size = new Size(170, 23);
            tbRbOnlyOneChecked.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(9, 9);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Tildados";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CheckBox solo uno tildado";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(388, 197);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbOnlyOne3);
            panel1.Controls.Add(cbOnlyOne2);
            panel1.Controls.Add(cbOnlyOne1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9);
            panel1.Size = new Size(188, 191);
            panel1.TabIndex = 5;
            // 
            // cbOnlyOne3
            // 
            cbOnlyOne3.AutoSize = true;
            cbOnlyOne3.Dock = DockStyle.Top;
            cbOnlyOne3.Location = new Point(9, 47);
            cbOnlyOne3.Name = "cbOnlyOne3";
            cbOnlyOne3.Size = new Size(170, 19);
            cbOnlyOne3.TabIndex = 2;
            cbOnlyOne3.Text = "checkBox3";
            cbOnlyOne3.UseVisualStyleBackColor = true;
            cbOnlyOne3.CheckedChanged += CheckBoxCheckedChanged;
            // 
            // cbOnlyOne2
            // 
            cbOnlyOne2.AutoSize = true;
            cbOnlyOne2.Dock = DockStyle.Top;
            cbOnlyOne2.Location = new Point(9, 28);
            cbOnlyOne2.Name = "cbOnlyOne2";
            cbOnlyOne2.Size = new Size(170, 19);
            cbOnlyOne2.TabIndex = 1;
            cbOnlyOne2.Text = "checkBox2";
            cbOnlyOne2.UseVisualStyleBackColor = true;
            cbOnlyOne2.CheckedChanged += CheckBoxCheckedChanged;
            // 
            // cbOnlyOne1
            // 
            cbOnlyOne1.AutoSize = true;
            cbOnlyOne1.Dock = DockStyle.Top;
            cbOnlyOne1.Location = new Point(9, 9);
            cbOnlyOne1.Name = "cbOnlyOne1";
            cbOnlyOne1.Size = new Size(170, 19);
            cbOnlyOne1.TabIndex = 0;
            cbOnlyOne1.Text = "checkBox1";
            cbOnlyOne1.UseVisualStyleBackColor = true;
            cbOnlyOne1.CheckedChanged += CheckBoxCheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tbCbOnlyOneChecked);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(197, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9);
            panel2.Size = new Size(188, 191);
            panel2.TabIndex = 6;
            // 
            // tbCbOnlyOneChecked
            // 
            tbCbOnlyOneChecked.Dock = DockStyle.Top;
            tbCbOnlyOneChecked.Location = new Point(9, 24);
            tbCbOnlyOneChecked.Name = "tbCbOnlyOneChecked";
            tbCbOnlyOneChecked.Size = new Size(170, 23);
            tbCbOnlyOneChecked.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "Tildados";
            // 
            // FormCheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormCheckBox";
            Text = "FormCheckBox";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Panel panel1;
        private CheckBox cbOnlyOne3;
        private CheckBox cbOnlyOne2;
        private CheckBox cbOnlyOne1;
        private Label label1;
        private TextBox tbCbOnlyOneChecked;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel7;
        private RadioButton rbMany3;
        private RadioButton rbMany2;
        private RadioButton rbMany1;
        private Panel panel8;
        private TextBox tbRbManyChecked;
        private Label label4;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel5;
        private CheckBox cbMany3;
        private CheckBox cbMany2;
        private CheckBox cbMany1;
        private Panel panel6;
        private TextBox tbCbManyChecked;
        private Label label3;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private RadioButton rbOnlyOne3;
        private RadioButton rbOnlyOne2;
        private RadioButton rbOnlyOne1;
        private Panel panel4;
        private TextBox tbRbOnlyOneChecked;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
    }
}