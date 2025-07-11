namespace _07_tp_analisis_matematico
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            hopeFormPrincipal = new ReaLTaiizor.Forms.HopeForm();
            plotView = new OxyPlot.WindowsForms.PlotView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDerivar = new ReaLTaiizor.Controls.HopeButton();
            panel1 = new Panel();
            tbCoeficientes = new ReaLTaiizor.Controls.BigTextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // hopeFormPrincipal
            // 
            hopeFormPrincipal.ControlBoxColorH = Color.FromArgb(228, 231, 237);
            hopeFormPrincipal.ControlBoxColorHC = Color.FromArgb(245, 108, 108);
            hopeFormPrincipal.ControlBoxColorN = Color.White;
            hopeFormPrincipal.Dock = DockStyle.Top;
            hopeFormPrincipal.Font = new Font("Segoe UI", 12F);
            hopeFormPrincipal.ForeColor = Color.FromArgb(242, 246, 252);
            hopeFormPrincipal.Image = (Image)resources.GetObject("hopeFormPrincipal.Image");
            hopeFormPrincipal.Location = new Point(0, 0);
            hopeFormPrincipal.Name = "hopeFormPrincipal";
            hopeFormPrincipal.Size = new Size(700, 40);
            hopeFormPrincipal.TabIndex = 0;
            hopeFormPrincipal.Text = "PoliFórmico";
            hopeFormPrincipal.ThemeColor = Color.FromArgb(64, 0, 64);
            // 
            // plotView
            // 
            plotView.Dock = DockStyle.Fill;
            plotView.Location = new Point(3, 3);
            plotView.Name = "plotView";
            plotView.PanCursor = Cursors.Hand;
            plotView.Size = new Size(694, 384);
            plotView.TabIndex = 1;
            plotView.Text = "plotView1";
            plotView.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(plotView, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(700, 460);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnDerivar, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 393);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(694, 64);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnDerivar
            // 
            btnDerivar.BorderColor = Color.FromArgb(220, 223, 230);
            btnDerivar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDerivar.DangerColor = Color.FromArgb(245, 108, 108);
            btnDerivar.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDerivar.Dock = DockStyle.Fill;
            btnDerivar.Font = new Font("Segoe UI", 12F);
            btnDerivar.HoverTextColor = Color.White;
            btnDerivar.InfoColor = Color.FromArgb(144, 147, 153);
            btnDerivar.Location = new Point(558, 20);
            btnDerivar.Margin = new Padding(3, 20, 3, 3);
            btnDerivar.Name = "btnDerivar";
            btnDerivar.PrimaryColor = Color.FromArgb(64, 0, 64);
            btnDerivar.Size = new Size(133, 41);
            btnDerivar.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDerivar.TabIndex = 6;
            btnDerivar.Text = "Derivar";
            btnDerivar.TextColor = Color.White;
            btnDerivar.WarningColor = Color.FromArgb(230, 162, 60);
            btnDerivar.Click += btnDerivar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbCoeficientes);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 58);
            panel1.TabIndex = 7;
            // 
            // tbCoeficientes
            // 
            tbCoeficientes.BackColor = Color.Transparent;
            tbCoeficientes.Dock = DockStyle.Top;
            tbCoeficientes.Font = new Font("Tahoma", 11F);
            tbCoeficientes.ForeColor = Color.DimGray;
            tbCoeficientes.Image = null;
            tbCoeficientes.Location = new Point(0, 15);
            tbCoeficientes.MaxLength = 32767;
            tbCoeficientes.Multiline = false;
            tbCoeficientes.Name = "tbCoeficientes";
            tbCoeficientes.ReadOnly = false;
            tbCoeficientes.Size = new Size(549, 41);
            tbCoeficientes.TabIndex = 6;
            tbCoeficientes.TextAlignment = HorizontalAlignment.Center;
            tbCoeficientes.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 7;
            label1.Text = "Coeficientes";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(700, 500);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(hopeFormPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "FormPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeFormPrincipal";
            Load += FormPrincipal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeFormPrincipal;
        private OxyPlot.WindowsForms.PlotView plotView;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.HopeButton btnDerivar;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigTextBox tbCoeficientes;
        private Label label1;
    }
}
