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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mepPersonalData = new MaterialSkin.Controls.MaterialExpansionPanel();
            mepMovieAndRoom = new MaterialSkin.Controls.MaterialExpansionPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            panel18 = new Panel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox2 = new PictureBox();
            panel19 = new Panel();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox3 = new PictureBox();
            panel20 = new Panel();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox4 = new PictureBox();
            panel21 = new Panel();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox5 = new PictureBox();
            panel22 = new Panel();
            materialButton6 = new MaterialSkin.Controls.MaterialButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox6 = new PictureBox();
            panel23 = new Panel();
            materialButton7 = new MaterialSkin.Controls.MaterialButton();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox7 = new PictureBox();
            panel24 = new Panel();
            materialButton8 = new MaterialSkin.Controls.MaterialButton();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox8 = new PictureBox();
            panel25 = new Panel();
            materialButton9 = new MaterialSkin.Controls.MaterialButton();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox9 = new PictureBox();
            panel26 = new Panel();
            materialButton10 = new MaterialSkin.Controls.MaterialButton();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox10 = new PictureBox();
            panel27 = new Panel();
            materialButton11 = new MaterialSkin.Controls.MaterialButton();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox11 = new PictureBox();
            panel28 = new Panel();
            materialButton12 = new MaterialSkin.Controls.MaterialButton();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox12 = new PictureBox();
            groupBox4 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel29 = new Panel();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            panel30 = new Panel();
            comboBox2 = new ComboBox();
            label6 = new Label();
            panel31 = new Panel();
            comboBox3 = new ComboBox();
            label7 = new Label();
            panel32 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            MainPanel = new Panel();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            panel4 = new Panel();
            materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            panel5 = new Panel();
            materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            panel6 = new Panel();
            materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            panel7 = new Panel();
            materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            panel8 = new Panel();
            materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            mepPersonalData.SuspendLayout();
            mepMovieAndRoom.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            groupBox4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel30.SuspendLayout();
            panel31.SuspendLayout();
            panel32.SuspendLayout();
            MainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // mepPersonalData
            // 
            mepPersonalData.BackColor = Color.FromArgb(255, 255, 255);
            mepPersonalData.Controls.Add(tableLayoutPanel1);
            mepPersonalData.Depth = 0;
            mepPersonalData.Description = "Para que podamos hacer tu reserva";
            mepPersonalData.Dock = DockStyle.Top;
            mepPersonalData.ExpandHeight = 780;
            mepPersonalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepPersonalData.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepPersonalData.Location = new Point(0, 780);
            mepPersonalData.Margin = new Padding(16);
            mepPersonalData.MouseState = MaterialSkin.MouseState.HOVER;
            mepPersonalData.Name = "mepPersonalData";
            mepPersonalData.Padding = new Padding(24, 64, 24, 16);
            mepPersonalData.ShowValidationButtons = false;
            mepPersonalData.Size = new Size(1095, 780);
            mepPersonalData.TabIndex = 0;
            mepPersonalData.Title = "Datos personales";
            // 
            // mepMovieAndRoom
            // 
            mepMovieAndRoom.BackColor = Color.FromArgb(255, 255, 255);
            mepMovieAndRoom.Controls.Add(tableLayoutPanel3);
            mepMovieAndRoom.Depth = 0;
            mepMovieAndRoom.Description = "Mirá el catálogo y elegí en donde y cuando vas a ver la película";
            mepMovieAndRoom.Dock = DockStyle.Top;
            mepMovieAndRoom.ExpandHeight = 780;
            mepMovieAndRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mepMovieAndRoom.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mepMovieAndRoom.Location = new Point(0, 0);
            mepMovieAndRoom.Margin = new Padding(16);
            mepMovieAndRoom.MouseState = MaterialSkin.MouseState.HOVER;
            mepMovieAndRoom.Name = "mepMovieAndRoom";
            mepMovieAndRoom.Padding = new Padding(24, 64, 24, 16);
            mepMovieAndRoom.ShowValidationButtons = false;
            mepMovieAndRoom.Size = new Size(1095, 780);
            mepMovieAndRoom.TabIndex = 1;
            mepMovieAndRoom.Title = "Película y sala";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(24, 64);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel3.Size = new Size(1047, 700);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1041, 494);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Seleccioná la película que vas a ver";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel18);
            flowLayoutPanel2.Controls.Add(panel19);
            flowLayoutPanel2.Controls.Add(panel20);
            flowLayoutPanel2.Controls.Add(panel21);
            flowLayoutPanel2.Controls.Add(panel22);
            flowLayoutPanel2.Controls.Add(panel23);
            flowLayoutPanel2.Controls.Add(panel24);
            flowLayoutPanel2.Controls.Add(panel25);
            flowLayoutPanel2.Controls.Add(panel26);
            flowLayoutPanel2.Controls.Add(panel27);
            flowLayoutPanel2.Controls.Add(panel28);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 19);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1035, 472);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(materialButton1);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.MinimumSize = new Size(164, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 209);
            panel1.TabIndex = 0;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Fill;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(0, 190);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(164, 19);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "Seleccionar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Dock = DockStyle.Top;
            materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel1.Location = new Point(0, 171);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(164, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "28 Días Después";
            materialLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MinimumSize = new Size(160, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel18
            // 
            panel18.Controls.Add(materialButton2);
            panel18.Controls.Add(materialLabel2);
            panel18.Controls.Add(pictureBox2);
            panel18.Location = new Point(173, 3);
            panel18.MinimumSize = new Size(164, 209);
            panel18.Name = "panel18";
            panel18.Size = new Size(164, 209);
            panel18.TabIndex = 1;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Dock = DockStyle.Fill;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(0, 190);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(164, 19);
            materialButton2.TabIndex = 4;
            materialButton2.Text = "Seleccionar";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Top;
            materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel2.Location = new Point(0, 171);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(164, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "28 Días Después";
            materialLabel2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.MinimumSize = new Size(160, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel19
            // 
            panel19.Controls.Add(materialButton3);
            panel19.Controls.Add(materialLabel3);
            panel19.Controls.Add(pictureBox3);
            panel19.Location = new Point(343, 3);
            panel19.MinimumSize = new Size(164, 209);
            panel19.Name = "panel19";
            panel19.Size = new Size(164, 209);
            panel19.TabIndex = 10;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.Dock = DockStyle.Fill;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(0, 190);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(164, 19);
            materialButton3.TabIndex = 4;
            materialButton3.Text = "Seleccionar";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Top;
            materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel3.Location = new Point(0, 171);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(164, 19);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "28 Días Después";
            materialLabel3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.MinimumSize = new Size(160, 170);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(164, 171);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel20
            // 
            panel20.Controls.Add(materialButton4);
            panel20.Controls.Add(materialLabel4);
            panel20.Controls.Add(pictureBox4);
            panel20.Location = new Point(513, 3);
            panel20.MinimumSize = new Size(164, 209);
            panel20.Name = "panel20";
            panel20.Size = new Size(164, 209);
            panel20.TabIndex = 9;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.Dock = DockStyle.Fill;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(0, 190);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(164, 19);
            materialButton4.TabIndex = 4;
            materialButton4.Text = "Seleccionar";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            materialLabel4.Depth = 0;
            materialLabel4.Dock = DockStyle.Top;
            materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel4.Location = new Point(0, 171);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(164, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "28 Días Después";
            materialLabel4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Top;
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.MinimumSize = new Size(160, 170);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(164, 171);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel21
            // 
            panel21.Controls.Add(materialButton5);
            panel21.Controls.Add(materialLabel5);
            panel21.Controls.Add(pictureBox5);
            panel21.Location = new Point(683, 3);
            panel21.MinimumSize = new Size(164, 209);
            panel21.Name = "panel21";
            panel21.Size = new Size(164, 209);
            panel21.TabIndex = 2;
            // 
            // materialButton5
            // 
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.Dock = DockStyle.Fill;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(0, 190);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(164, 19);
            materialButton5.TabIndex = 4;
            materialButton5.Text = "Seleccionar";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Dock = DockStyle.Top;
            materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel5.Location = new Point(0, 171);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(164, 19);
            materialLabel5.TabIndex = 5;
            materialLabel5.Text = "28 Días Después";
            materialLabel5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Top;
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.MinimumSize = new Size(160, 170);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(164, 171);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel22
            // 
            panel22.Controls.Add(materialButton6);
            panel22.Controls.Add(materialLabel6);
            panel22.Controls.Add(pictureBox6);
            panel22.Location = new Point(853, 3);
            panel22.MinimumSize = new Size(164, 209);
            panel22.Name = "panel22";
            panel22.Size = new Size(164, 209);
            panel22.TabIndex = 3;
            // 
            // materialButton6
            // 
            materialButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton6.Depth = 0;
            materialButton6.Dock = DockStyle.Fill;
            materialButton6.HighEmphasis = true;
            materialButton6.Icon = null;
            materialButton6.Location = new Point(0, 190);
            materialButton6.Margin = new Padding(4, 6, 4, 6);
            materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton6.Name = "materialButton6";
            materialButton6.NoAccentTextColor = Color.Empty;
            materialButton6.Size = new Size(164, 19);
            materialButton6.TabIndex = 4;
            materialButton6.Text = "Seleccionar";
            materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton6.UseAccentColor = false;
            materialButton6.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            materialLabel6.Depth = 0;
            materialLabel6.Dock = DockStyle.Top;
            materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel6.Location = new Point(0, 171);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(164, 19);
            materialLabel6.TabIndex = 5;
            materialLabel6.Text = "28 Días Después";
            materialLabel6.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Top;
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.MinimumSize = new Size(160, 170);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(164, 171);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel23
            // 
            panel23.Controls.Add(materialButton7);
            panel23.Controls.Add(materialLabel7);
            panel23.Controls.Add(pictureBox7);
            panel23.Location = new Point(3, 218);
            panel23.MinimumSize = new Size(164, 209);
            panel23.Name = "panel23";
            panel23.Size = new Size(164, 209);
            panel23.TabIndex = 4;
            // 
            // materialButton7
            // 
            materialButton7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton7.Depth = 0;
            materialButton7.Dock = DockStyle.Fill;
            materialButton7.HighEmphasis = true;
            materialButton7.Icon = null;
            materialButton7.Location = new Point(0, 190);
            materialButton7.Margin = new Padding(4, 6, 4, 6);
            materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton7.Name = "materialButton7";
            materialButton7.NoAccentTextColor = Color.Empty;
            materialButton7.Size = new Size(164, 19);
            materialButton7.TabIndex = 4;
            materialButton7.Text = "Seleccionar";
            materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton7.UseAccentColor = false;
            materialButton7.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            materialLabel7.Depth = 0;
            materialLabel7.Dock = DockStyle.Top;
            materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel7.Location = new Point(0, 171);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(164, 19);
            materialLabel7.TabIndex = 5;
            materialLabel7.Text = "28 Días Después";
            materialLabel7.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Top;
            pictureBox7.Image = (System.Drawing.Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.MinimumSize = new Size(160, 170);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(164, 171);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // panel24
            // 
            panel24.Controls.Add(materialButton8);
            panel24.Controls.Add(materialLabel8);
            panel24.Controls.Add(pictureBox8);
            panel24.Location = new Point(173, 218);
            panel24.MinimumSize = new Size(164, 209);
            panel24.Name = "panel24";
            panel24.Size = new Size(164, 209);
            panel24.TabIndex = 3;
            // 
            // materialButton8
            // 
            materialButton8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton8.Depth = 0;
            materialButton8.Dock = DockStyle.Fill;
            materialButton8.HighEmphasis = true;
            materialButton8.Icon = null;
            materialButton8.Location = new Point(0, 190);
            materialButton8.Margin = new Padding(4, 6, 4, 6);
            materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton8.Name = "materialButton8";
            materialButton8.NoAccentTextColor = Color.Empty;
            materialButton8.Size = new Size(164, 19);
            materialButton8.TabIndex = 4;
            materialButton8.Text = "Seleccionar";
            materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton8.UseAccentColor = false;
            materialButton8.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            materialLabel8.Depth = 0;
            materialLabel8.Dock = DockStyle.Top;
            materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel8.Location = new Point(0, 171);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(164, 19);
            materialLabel8.TabIndex = 5;
            materialLabel8.Text = "28 Días Después";
            materialLabel8.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Top;
            pictureBox8.Image = (System.Drawing.Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 0);
            pictureBox8.MinimumSize = new Size(160, 170);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(164, 171);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // panel25
            // 
            panel25.Controls.Add(materialButton9);
            panel25.Controls.Add(materialLabel9);
            panel25.Controls.Add(pictureBox9);
            panel25.Location = new Point(343, 218);
            panel25.MinimumSize = new Size(164, 209);
            panel25.Name = "panel25";
            panel25.Size = new Size(164, 209);
            panel25.TabIndex = 5;
            // 
            // materialButton9
            // 
            materialButton9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton9.Depth = 0;
            materialButton9.Dock = DockStyle.Fill;
            materialButton9.HighEmphasis = true;
            materialButton9.Icon = null;
            materialButton9.Location = new Point(0, 190);
            materialButton9.Margin = new Padding(4, 6, 4, 6);
            materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton9.Name = "materialButton9";
            materialButton9.NoAccentTextColor = Color.Empty;
            materialButton9.Size = new Size(164, 19);
            materialButton9.TabIndex = 4;
            materialButton9.Text = "Seleccionar";
            materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton9.UseAccentColor = false;
            materialButton9.UseVisualStyleBackColor = true;
            // 
            // materialLabel9
            // 
            materialLabel9.Depth = 0;
            materialLabel9.Dock = DockStyle.Top;
            materialLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel9.Location = new Point(0, 171);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(164, 19);
            materialLabel9.TabIndex = 5;
            materialLabel9.Text = "28 Días Después";
            materialLabel9.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox9
            // 
            pictureBox9.Dock = DockStyle.Top;
            pictureBox9.Image = (System.Drawing.Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(0, 0);
            pictureBox9.MinimumSize = new Size(160, 170);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(164, 171);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 0;
            pictureBox9.TabStop = false;
            // 
            // panel26
            // 
            panel26.Controls.Add(materialButton10);
            panel26.Controls.Add(materialLabel10);
            panel26.Controls.Add(pictureBox10);
            panel26.Location = new Point(513, 218);
            panel26.MinimumSize = new Size(164, 209);
            panel26.Name = "panel26";
            panel26.Size = new Size(164, 209);
            panel26.TabIndex = 6;
            // 
            // materialButton10
            // 
            materialButton10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton10.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton10.Depth = 0;
            materialButton10.Dock = DockStyle.Fill;
            materialButton10.HighEmphasis = true;
            materialButton10.Icon = null;
            materialButton10.Location = new Point(0, 190);
            materialButton10.Margin = new Padding(4, 6, 4, 6);
            materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton10.Name = "materialButton10";
            materialButton10.NoAccentTextColor = Color.Empty;
            materialButton10.Size = new Size(164, 19);
            materialButton10.TabIndex = 4;
            materialButton10.Text = "Seleccionar";
            materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton10.UseAccentColor = false;
            materialButton10.UseVisualStyleBackColor = true;
            // 
            // materialLabel10
            // 
            materialLabel10.Depth = 0;
            materialLabel10.Dock = DockStyle.Top;
            materialLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel10.Location = new Point(0, 171);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(164, 19);
            materialLabel10.TabIndex = 5;
            materialLabel10.Text = "28 Días Después";
            materialLabel10.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox10
            // 
            pictureBox10.Dock = DockStyle.Top;
            pictureBox10.Image = (System.Drawing.Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(0, 0);
            pictureBox10.MinimumSize = new Size(160, 170);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(164, 171);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // panel27
            // 
            panel27.Controls.Add(materialButton11);
            panel27.Controls.Add(materialLabel11);
            panel27.Controls.Add(pictureBox11);
            panel27.Location = new Point(683, 218);
            panel27.MinimumSize = new Size(164, 209);
            panel27.Name = "panel27";
            panel27.Size = new Size(164, 209);
            panel27.TabIndex = 7;
            // 
            // materialButton11
            // 
            materialButton11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton11.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton11.Depth = 0;
            materialButton11.Dock = DockStyle.Fill;
            materialButton11.HighEmphasis = true;
            materialButton11.Icon = null;
            materialButton11.Location = new Point(0, 190);
            materialButton11.Margin = new Padding(4, 6, 4, 6);
            materialButton11.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton11.Name = "materialButton11";
            materialButton11.NoAccentTextColor = Color.Empty;
            materialButton11.Size = new Size(164, 19);
            materialButton11.TabIndex = 4;
            materialButton11.Text = "Seleccionar";
            materialButton11.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton11.UseAccentColor = false;
            materialButton11.UseVisualStyleBackColor = true;
            // 
            // materialLabel11
            // 
            materialLabel11.Depth = 0;
            materialLabel11.Dock = DockStyle.Top;
            materialLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel11.Location = new Point(0, 171);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(164, 19);
            materialLabel11.TabIndex = 5;
            materialLabel11.Text = "28 Días Después";
            materialLabel11.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox11
            // 
            pictureBox11.Dock = DockStyle.Top;
            pictureBox11.Image = (System.Drawing.Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(0, 0);
            pictureBox11.MinimumSize = new Size(160, 170);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(164, 171);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 0;
            pictureBox11.TabStop = false;
            // 
            // panel28
            // 
            panel28.Controls.Add(materialButton12);
            panel28.Controls.Add(materialLabel12);
            panel28.Controls.Add(pictureBox12);
            panel28.Location = new Point(853, 218);
            panel28.MinimumSize = new Size(164, 209);
            panel28.Name = "panel28";
            panel28.Size = new Size(164, 209);
            panel28.TabIndex = 8;
            // 
            // materialButton12
            // 
            materialButton12.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton12.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton12.Depth = 0;
            materialButton12.Dock = DockStyle.Fill;
            materialButton12.HighEmphasis = true;
            materialButton12.Icon = null;
            materialButton12.Location = new Point(0, 190);
            materialButton12.Margin = new Padding(4, 6, 4, 6);
            materialButton12.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton12.Name = "materialButton12";
            materialButton12.NoAccentTextColor = Color.Empty;
            materialButton12.Size = new Size(164, 19);
            materialButton12.TabIndex = 4;
            materialButton12.Text = "Seleccionar";
            materialButton12.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton12.UseAccentColor = false;
            materialButton12.UseVisualStyleBackColor = true;
            // 
            // materialLabel12
            // 
            materialLabel12.Depth = 0;
            materialLabel12.Dock = DockStyle.Top;
            materialLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            materialLabel12.Location = new Point(0, 171);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(164, 19);
            materialLabel12.TabIndex = 5;
            materialLabel12.Text = "28 Días Después";
            materialLabel12.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox12
            // 
            pictureBox12.Dock = DockStyle.Top;
            pictureBox12.Image = (System.Drawing.Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(0, 0);
            pictureBox12.MinimumSize = new Size(160, 170);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(164, 171);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 0;
            pictureBox12.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 503);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1041, 194);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Personalizá tu salida";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(panel29, 3, 0);
            tableLayoutPanel4.Controls.Add(panel30, 1, 0);
            tableLayoutPanel4.Controls.Add(panel31, 2, 0);
            tableLayoutPanel4.Controls.Add(panel32, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 19);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1035, 172);
            tableLayoutPanel4.TabIndex = 9;
            // 
            // panel29
            // 
            panel29.Controls.Add(numericUpDown2);
            panel29.Controls.Add(label5);
            panel29.Dock = DockStyle.Fill;
            panel29.Location = new Point(777, 3);
            panel29.Name = "panel29";
            panel29.Padding = new Padding(5);
            panel29.Size = new Size(255, 166);
            panel29.TabIndex = 13;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Dock = DockStyle.Top;
            numericUpDown2.Location = new Point(5, 22);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(245, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(5, 5);
            label5.Name = "label5";
            label5.Size = new Size(141, 17);
            label5.TabIndex = 6;
            label5.Text = "Cantidad de asientos";
            // 
            // panel30
            // 
            panel30.Controls.Add(comboBox2);
            panel30.Controls.Add(label6);
            panel30.Dock = DockStyle.Fill;
            panel30.Location = new Point(261, 3);
            panel30.Name = "panel30";
            panel30.Padding = new Padding(5);
            panel30.Size = new Size(252, 166);
            panel30.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Top;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(5, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 25);
            comboBox2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(5, 5);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 8;
            label6.Text = "Horario";
            // 
            // panel31
            // 
            panel31.Controls.Add(comboBox3);
            panel31.Controls.Add(label7);
            panel31.Dock = DockStyle.Fill;
            panel31.Location = new Point(519, 3);
            panel31.Name = "panel31";
            panel31.Padding = new Padding(5);
            panel31.Size = new Size(252, 166);
            panel31.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Top;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "2D", "3D", "4D" });
            comboBox3.Location = new Point(5, 22);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(242, 25);
            comboBox3.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Location = new Point(5, 5);
            label7.Name = "label7";
            label7.Size = new Size(86, 17);
            label7.TabIndex = 1;
            label7.Text = "Tipo de sala";
            // 
            // panel32
            // 
            panel32.Controls.Add(dateTimePicker2);
            panel32.Controls.Add(label8);
            panel32.Dock = DockStyle.Fill;
            panel32.Location = new Point(3, 3);
            panel32.Name = "panel32";
            panel32.Padding = new Padding(5);
            panel32.Size = new Size(252, 166);
            panel32.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Top;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(5, 22);
            dateTimePicker2.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(242, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Location = new Point(5, 5);
            label8.Name = "label8";
            label8.Size = new Size(47, 17);
            label8.TabIndex = 4;
            label8.Text = "Fecha";
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.Controls.Add(mepPersonalData);
            MainPanel.Controls.Add(mepMovieAndRoom);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 64);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1112, 780);
            MainPanel.TabIndex = 3;
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Dock = DockStyle.Top;
            materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(0, 0);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(57, 19);
            materialLabel13.TabIndex = 2;
            materialLabel13.Text = "Nombre";
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Dock = DockStyle.Top;
            materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(0, 19);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(517, 50);
            materialTextBox1.TabIndex = 3;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel8, 0, 3);
            tableLayoutPanel1.Controls.Add(panel7, 1, 2);
            tableLayoutPanel1.Controls.Add(panel6, 0, 2);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(24, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1047, 700);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(materialTextBox1);
            panel2.Controls.Add(materialLabel13);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 100);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(materialTextBox2);
            panel3.Controls.Add(materialLabel14);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(526, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(518, 100);
            panel3.TabIndex = 6;
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Dock = DockStyle.Top;
            materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(0, 19);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(518, 50);
            materialTextBox2.TabIndex = 3;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Dock = DockStyle.Top;
            materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(0, 0);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(58, 19);
            materialLabel14.TabIndex = 2;
            materialLabel14.Text = "Apellido";
            // 
            // panel4
            // 
            panel4.Controls.Add(materialTextBox3);
            panel4.Controls.Add(materialLabel15);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 109);
            panel4.Name = "panel4";
            panel4.Size = new Size(517, 100);
            panel4.TabIndex = 7;
            // 
            // materialTextBox3
            // 
            materialTextBox3.AnimateReadOnly = false;
            materialTextBox3.BorderStyle = BorderStyle.None;
            materialTextBox3.Depth = 0;
            materialTextBox3.Dock = DockStyle.Top;
            materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox3.LeadingIcon = null;
            materialTextBox3.Location = new Point(0, 19);
            materialTextBox3.MaxLength = 50;
            materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox3.Multiline = false;
            materialTextBox3.Name = "materialTextBox3";
            materialTextBox3.Size = new Size(517, 50);
            materialTextBox3.TabIndex = 3;
            materialTextBox3.Text = "";
            materialTextBox3.TrailingIcon = null;
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Dock = DockStyle.Top;
            materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(0, 0);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(41, 19);
            materialLabel15.TabIndex = 2;
            materialLabel15.Text = "Email";
            // 
            // panel5
            // 
            panel5.Controls.Add(materialTextBox4);
            panel5.Controls.Add(materialLabel16);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(526, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(518, 100);
            panel5.TabIndex = 8;
            // 
            // materialTextBox4
            // 
            materialTextBox4.AnimateReadOnly = false;
            materialTextBox4.BorderStyle = BorderStyle.None;
            materialTextBox4.Depth = 0;
            materialTextBox4.Dock = DockStyle.Top;
            materialTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox4.LeadingIcon = null;
            materialTextBox4.Location = new Point(0, 19);
            materialTextBox4.MaxLength = 50;
            materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox4.Multiline = false;
            materialTextBox4.Name = "materialTextBox4";
            materialTextBox4.Size = new Size(518, 50);
            materialTextBox4.TabIndex = 3;
            materialTextBox4.Text = "";
            materialTextBox4.TrailingIcon = null;
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Dock = DockStyle.Top;
            materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(0, 0);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(64, 19);
            materialLabel16.TabIndex = 2;
            materialLabel16.Text = "Teléfono";
            // 
            // panel6
            // 
            panel6.Controls.Add(materialTextBox5);
            panel6.Controls.Add(materialLabel17);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 215);
            panel6.Name = "panel6";
            panel6.Size = new Size(517, 100);
            panel6.TabIndex = 9;
            // 
            // materialTextBox5
            // 
            materialTextBox5.AnimateReadOnly = false;
            materialTextBox5.BorderStyle = BorderStyle.None;
            materialTextBox5.Depth = 0;
            materialTextBox5.Dock = DockStyle.Top;
            materialTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox5.LeadingIcon = null;
            materialTextBox5.Location = new Point(0, 19);
            materialTextBox5.MaxLength = 50;
            materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox5.Multiline = false;
            materialTextBox5.Name = "materialTextBox5";
            materialTextBox5.Size = new Size(517, 50);
            materialTextBox5.TabIndex = 3;
            materialTextBox5.Text = "";
            materialTextBox5.TrailingIcon = null;
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Dock = DockStyle.Top;
            materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel17.Location = new Point(0, 0);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(94, 19);
            materialLabel17.TabIndex = 2;
            materialLabel17.Text = "Calle y Altura";
            // 
            // panel7
            // 
            panel7.Controls.Add(materialTextBox6);
            panel7.Controls.Add(materialLabel18);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(526, 215);
            panel7.Name = "panel7";
            panel7.Size = new Size(518, 100);
            panel7.TabIndex = 10;
            // 
            // materialTextBox6
            // 
            materialTextBox6.AnimateReadOnly = false;
            materialTextBox6.BorderStyle = BorderStyle.None;
            materialTextBox6.Depth = 0;
            materialTextBox6.Dock = DockStyle.Top;
            materialTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox6.LeadingIcon = null;
            materialTextBox6.Location = new Point(0, 19);
            materialTextBox6.MaxLength = 50;
            materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox6.Multiline = false;
            materialTextBox6.Name = "materialTextBox6";
            materialTextBox6.Size = new Size(518, 50);
            materialTextBox6.TabIndex = 3;
            materialTextBox6.Text = "";
            materialTextBox6.TrailingIcon = null;
            // 
            // materialLabel18
            // 
            materialLabel18.AutoSize = true;
            materialLabel18.Depth = 0;
            materialLabel18.Dock = DockStyle.Top;
            materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel18.Location = new Point(0, 0);
            materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(51, 19);
            materialLabel18.TabIndex = 2;
            materialLabel18.Text = "Ciudad";
            // 
            // panel8
            // 
            panel8.Controls.Add(materialTextBox7);
            panel8.Controls.Add(materialLabel19);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 321);
            panel8.Name = "panel8";
            panel8.Size = new Size(517, 100);
            panel8.TabIndex = 11;
            // 
            // materialTextBox7
            // 
            materialTextBox7.AnimateReadOnly = false;
            materialTextBox7.BorderStyle = BorderStyle.None;
            materialTextBox7.Depth = 0;
            materialTextBox7.Dock = DockStyle.Top;
            materialTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox7.LeadingIcon = null;
            materialTextBox7.Location = new Point(0, 19);
            materialTextBox7.MaxLength = 50;
            materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox7.Multiline = false;
            materialTextBox7.Name = "materialTextBox7";
            materialTextBox7.Size = new Size(517, 50);
            materialTextBox7.TabIndex = 3;
            materialTextBox7.Text = "";
            materialTextBox7.TrailingIcon = null;
            // 
            // materialLabel19
            // 
            materialLabel19.AutoSize = true;
            materialLabel19.Depth = 0;
            materialLabel19.Dock = DockStyle.Top;
            materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel19.Location = new Point(0, 0);
            materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel19.Name = "materialLabel19";
            materialLabel19.Size = new Size(51, 19);
            materialLabel19.TabIndex = 2;
            materialLabel19.Text = "Ciudad";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 847);
            Controls.Add(MainPanel);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            MinimumSize = new Size(549, 762);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A.S Cinema";
            Load += Form1_Load;
            mepPersonalData.ResumeLayout(false);
            mepPersonalData.PerformLayout();
            mepMovieAndRoom.ResumeLayout(false);
            mepMovieAndRoom.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            groupBox4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel29.ResumeLayout(false);
            panel29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel30.ResumeLayout(false);
            panel30.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            MainPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialExpansionPanel mepPersonalData;
        private MaterialSkin.Controls.MaterialExpansionPanel mepMovieAndRoom;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox pictureBox1;
        private Panel panel18;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private PictureBox pictureBox2;
        private Panel panel19;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private PictureBox pictureBox3;
        private Panel panel20;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private PictureBox pictureBox4;
        private Panel panel21;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private PictureBox pictureBox5;
        private Panel panel22;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private PictureBox pictureBox6;
        private Panel panel23;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private PictureBox pictureBox7;
        private Panel panel24;
        private MaterialSkin.Controls.MaterialButton materialButton8;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private PictureBox pictureBox8;
        private Panel panel25;
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private PictureBox pictureBox9;
        private Panel panel26;
        private MaterialSkin.Controls.MaterialButton materialButton10;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private PictureBox pictureBox10;
        private Panel panel27;
        private MaterialSkin.Controls.MaterialButton materialButton11;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private PictureBox pictureBox11;
        private Panel panel28;
        private MaterialSkin.Controls.MaterialButton materialButton12;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private PictureBox pictureBox12;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel29;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Panel panel30;
        private ComboBox comboBox2;
        private Label label6;
        private Panel panel31;
        private ComboBox comboBox3;
        private Label label7;
        private Panel panel32;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private Panel MainPanel;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private Panel panel7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private Panel panel6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private Panel panel5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private Panel panel2;
    }
}
