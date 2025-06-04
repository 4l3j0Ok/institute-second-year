namespace _05_cine
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            btnViewBillboard = new ReaLTaiizor.Controls.MaterialButton();
            materialLabel13 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnViewBillboard, 0, 2);
            tableLayoutPanel1.Controls.Add(materialLabel13, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(873, 593);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(867, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnViewBillboard
            // 
            btnViewBillboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewBillboard.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnViewBillboard.Depth = 0;
            btnViewBillboard.Dock = DockStyle.Fill;
            btnViewBillboard.HighEmphasis = true;
            btnViewBillboard.Icon = null;
            btnViewBillboard.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnViewBillboard.Location = new Point(4, 551);
            btnViewBillboard.Margin = new Padding(4, 6, 4, 6);
            btnViewBillboard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnViewBillboard.Name = "btnViewBillboard";
            btnViewBillboard.NoAccentTextColor = Color.Empty;
            btnViewBillboard.Size = new Size(865, 36);
            btnViewBillboard.TabIndex = 1;
            btnViewBillboard.Text = "Ver cartelera";
            btnViewBillboard.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnViewBillboard.UseAccentColor = false;
            btnViewBillboard.UseVisualStyleBackColor = true;
            btnViewBillboard.Click += btnViewBillboard_Click;
            // 
            // materialLabel13
            // 
            materialLabel13.Depth = 0;
            materialLabel13.Dock = DockStyle.Fill;
            materialLabel13.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel13.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel13.Location = new Point(3, 515);
            materialLabel13.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(867, 30);
            materialLabel13.TabIndex = 2;
            materialLabel13.Text = "Pochoclos, experiencias y buen cine";
            materialLabel13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 596);
            Controls.Add(tableLayoutPanel1);
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            Name = "Landing";
            Padding = new Padding(3, 0, 3, 3);
            Text = "Landing";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialButton btnViewBillboard;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel13;
    }
}