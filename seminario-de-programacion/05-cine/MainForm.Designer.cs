using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _05_cine
{
    partial class MainForm
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
            MainPanel = new ReaLTaiizor.Controls.Panel();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.BackColor = SystemColors.Control;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.EdgeColor = Color.Transparent;
            MainPanel.Location = new Point(3, 64);
            MainPanel.Margin = new Padding(2);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(4);
            MainPanel.Size = new Size(487, 433);
            MainPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            MainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(492, 499);
            Controls.Add(MainPanel);
            Margin = new Padding(2);
            MaximumSize = new Size(9999, 9999);
            MinimumSize = new Size(419, 412);
            Name = "MainForm";
            Padding = new Padding(3, 64, 2, 2);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A.S Cinema";
            TransparencyKey = Color.Fuchsia;
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        public ReaLTaiizor.Controls.Panel MainPanel;
    }
}
