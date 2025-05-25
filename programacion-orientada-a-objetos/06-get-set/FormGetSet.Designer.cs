namespace _06_get_set
{
    partial class FormGetSet
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
            btnTransfer = new Button();
            tbRaw = new TextBox();
            tbPretty = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            tbValue1 = new TextBox();
            label1 = new Label();
            btnSend = new Button();
            tbValue2 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTransfer
            // 
            btnTransfer.Dock = DockStyle.Fill;
            btnTransfer.Location = new Point(269, 114);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(260, 23);
            btnTransfer.TabIndex = 0;
            btnTransfer.Text = "Pasar";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_click;
            // 
            // tbRaw
            // 
            tbRaw.Dock = DockStyle.Fill;
            tbRaw.Location = new Point(3, 114);
            tbRaw.Name = "tbRaw";
            tbRaw.Size = new Size(260, 23);
            tbRaw.TabIndex = 1;
            // 
            // tbPretty
            // 
            tbPretty.Dock = DockStyle.Fill;
            tbPretty.Location = new Point(535, 114);
            tbPretty.Name = "tbPretty";
            tbPretty.Size = new Size(262, 23);
            tbPretty.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(tbRaw, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTransfer, 1, 1);
            tableLayoutPanel1.Controls.Add(tbPretty, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(tbValue1, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSend, 2, 3);
            tableLayoutPanel1.Controls.Add(tbValue2, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.40888F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.76552F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8256F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Location = new Point(269, 254);
            label3.Name = "label3";
            label3.Size = new Size(260, 15);
            label3.TabIndex = 8;
            label3.Text = "Dato 2";
            // 
            // tbValue1
            // 
            tbValue1.Dock = DockStyle.Top;
            tbValue1.Location = new Point(3, 272);
            tbValue1.Name = "tbValue1";
            tbValue1.Size = new Size(260, 23);
            tbValue1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(3, 254);
            label1.Name = "label1";
            label1.Size = new Size(260, 15);
            label1.TabIndex = 6;
            label1.Text = "Dato 1";
            // 
            // btnSend
            // 
            btnSend.Dock = DockStyle.Top;
            btnSend.Location = new Point(535, 272);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(262, 23);
            btnSend.TabIndex = 5;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbValue2
            // 
            tbValue2.Dock = DockStyle.Top;
            tbValue2.Location = new Point(269, 272);
            tbValue2.Name = "tbValue2";
            tbValue2.Size = new Size(260, 23);
            tbValue2.TabIndex = 3;
            // 
            // FormGetSet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormGetSet";
            Text = "FormGetSet";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTransfer;
        private TextBox tbRaw;
        private TextBox tbPretty;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbValue2;
        private TextBox tbValue1;
        private Button btnSend;
        private Label label1;
        private Label label3;
    }
}