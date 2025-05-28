using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _05_cine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new ReaLTaiizor.Controls.Panel();
            materialExpansionPanel2 = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            materialExpansionPanel3 = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            materialExpansionPanel1 = new ReaLTaiizor.Controls.MaterialExpansionPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new ReaLTaiizor.Controls.Panel();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            panel1.SuspendLayout();
            materialExpansionPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(238, 238, 238);
            panel1.Controls.Add(materialExpansionPanel3);
            panel1.Controls.Add(materialExpansionPanel2);
            panel1.Controls.Add(materialExpansionPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(1022, 656);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // materialExpansionPanel2
            // 
            materialExpansionPanel2.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel2.Depth = 0;
            materialExpansionPanel2.Dock = DockStyle.Top;
            materialExpansionPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel2.Location = new Point(5, 640);
            materialExpansionPanel2.Margin = new Padding(3, 16, 3, 16);
            materialExpansionPanel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialExpansionPanel2.Name = "materialExpansionPanel2";
            materialExpansionPanel2.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel2.Size = new Size(995, 240);
            materialExpansionPanel2.TabIndex = 1;
            // 
            // materialExpansionPanel3
            // 
            materialExpansionPanel3.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel3.Depth = 0;
            materialExpansionPanel3.Dock = DockStyle.Top;
            materialExpansionPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel3.Location = new Point(5, 880);
            materialExpansionPanel3.Margin = new Padding(3, 16, 3, 16);
            materialExpansionPanel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialExpansionPanel3.Name = "materialExpansionPanel3";
            materialExpansionPanel3.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel3.Size = new Size(995, 240);
            materialExpansionPanel3.TabIndex = 2;
            // 
            // materialExpansionPanel1
            // 
            materialExpansionPanel1.BackColor = Color.FromArgb(255, 255, 255);
            materialExpansionPanel1.Controls.Add(flowLayoutPanel1);
            materialExpansionPanel1.Depth = 0;
            materialExpansionPanel1.Dock = DockStyle.Top;
            materialExpansionPanel1.ExpandHeight = 635;
            materialExpansionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialExpansionPanel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialExpansionPanel1.Location = new Point(5, 5);
            materialExpansionPanel1.Margin = new Padding(3, 16, 3, 16);
            materialExpansionPanel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialExpansionPanel1.Name = "materialExpansionPanel1";
            materialExpansionPanel1.Padding = new Padding(24, 64, 24, 16);
            materialExpansionPanel1.ShowValidationButtons = false;
            materialExpansionPanel1.Size = new Size(995, 635);
            materialExpansionPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(24, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(947, 555);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(materialButton1);
            panel2.Controls.Add(materialLabel1);
            panel2.Controls.Add(hopePictureBox1);
            panel2.EdgeColor = Color.White;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(152, 263);
            panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel2.TabIndex = 0;
            panel2.Text = "panel2";
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Dock = DockStyle.Top;
            hopePictureBox1.Image = (System.Drawing.Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(5, 5);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(142, 203);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 0;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Top;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(5, 208);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(142, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "materialLabel1";
            materialLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Top;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(5, 227);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(142, 25);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(1028, 723);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(261, 61);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Papota";
            TransparencyKey = Color.MediumOrchid;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            materialExpansionPanel1.ResumeLayout(false);
            materialExpansionPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.MaterialExpansionPanel materialExpansionPanel3;
        private ReaLTaiizor.Controls.MaterialExpansionPanel materialExpansionPanel2;
        private ReaLTaiizor.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.Panel panel2;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    }
}
