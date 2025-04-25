namespace _05_clases_abstractas_herencia_polimorfismo_override
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
            lblGreetings = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbGreetingsType = new ComboBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblGreetings
            // 
            lblGreetings.AutoSize = true;
            lblGreetings.Dock = DockStyle.Fill;
            lblGreetings.Font = new Font("CaskaydiaCove NF", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGreetings.Location = new Point(3, 0);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(794, 338);
            lblGreetings.TabIndex = 0;
            lblGreetings.Text = "Esto debe ser reemplazado por saludo en el load";
            lblGreetings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblGreetings, 0, 0);
            tableLayoutPanel1.Controls.Add(cbGreetingsType, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.77778F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // cbGreetingsType
            // 
            cbGreetingsType.BackColor = Color.White;
            cbGreetingsType.Dock = DockStyle.Fill;
            cbGreetingsType.FlatStyle = FlatStyle.Flat;
            cbGreetingsType.FormattingEnabled = true;
            cbGreetingsType.Location = new Point(3, 356);
            cbGreetingsType.Name = "cbGreetingsType";
            cbGreetingsType.Size = new Size(794, 23);
            cbGreetingsType.TabIndex = 1;
            cbGreetingsType.SelectedIndexChanged += cbGreetingsType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 338);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione el tipo de saludo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblGreetings;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cbGreetingsType;
        private Label label1;
    }
}
