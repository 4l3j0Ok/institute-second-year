namespace _03_cine
{
    partial class SuccessPurchase
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessPurchase));
            materialLabel13 = new ReaLTaiizor.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnGoBack = new ReaLTaiizor.Controls.MaterialButton();
            btnGetTickets = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel13
            // 
            materialLabel13.Depth = 0;
            materialLabel13.Dock = DockStyle.Fill;
            materialLabel13.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel13.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H5;
            materialLabel13.Location = new Point(3, 251);
            materialLabel13.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(724, 30);
            materialLabel13.TabIndex = 2;
            materialLabel13.Text = "¡Compra exitosa!";
            materialLabel13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(724, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(materialLabel1, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(materialLabel13, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(730, 458);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Fill;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(3, 281);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(724, 114);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Ya hicimos tu reserva. Descargá los tickets y traelos el día de la función. ¡Te esperamos!";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnGoBack, 1, 0);
            tableLayoutPanel2.Controls.Add(btnGetTickets, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 398);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(724, 57);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnGoBack
            // 
            btnGoBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGoBack.Cursor = Cursors.Hand;
            btnGoBack.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGoBack.Depth = 0;
            btnGoBack.Dock = DockStyle.Fill;
            btnGoBack.HighEmphasis = true;
            btnGoBack.Icon = null;
            btnGoBack.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnGoBack.Location = new Point(366, 6);
            btnGoBack.Margin = new Padding(4, 6, 4, 6);
            btnGoBack.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGoBack.Name = "btnGoBack";
            btnGoBack.NoAccentTextColor = Color.Empty;
            btnGoBack.Size = new Size(354, 45);
            btnGoBack.TabIndex = 3;
            btnGoBack.Text = "Volver a inicio";
            btnGoBack.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGoBack.UseAccentColor = false;
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnGetTickets
            // 
            btnGetTickets.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGetTickets.Cursor = Cursors.Hand;
            btnGetTickets.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGetTickets.Depth = 0;
            btnGetTickets.Dock = DockStyle.Fill;
            btnGetTickets.HighEmphasis = true;
            btnGetTickets.Icon = null;
            btnGetTickets.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnGetTickets.Location = new Point(4, 6);
            btnGetTickets.Margin = new Padding(4, 6, 4, 6);
            btnGetTickets.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnGetTickets.Name = "btnGetTickets";
            btnGetTickets.NoAccentTextColor = Color.Empty;
            btnGetTickets.Size = new Size(354, 45);
            btnGetTickets.TabIndex = 2;
            btnGetTickets.Text = "Imprimir tickets";
            btnGetTickets.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGetTickets.UseAccentColor = false;
            btnGetTickets.UseVisualStyleBackColor = true;
            btnGetTickets.Click += btnGetTickets_Click;
            // 
            // SuccessPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "SuccessPurchase";
            Size = new Size(730, 458);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel materialLabel13;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.MaterialButton btnGetTickets;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialButton btnGoBack;
    }
}
