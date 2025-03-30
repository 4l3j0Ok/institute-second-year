namespace _2_disenio_en_base_a_codigo_pre_hecho
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            Delete = new Button();
            button5 = new Button();
            button6 = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(3, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(272, 146);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.Dock = DockStyle.Fill;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(3, 19);
            listBox2.MinimumSize = new Size(240, 149);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(240, 235);
            listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.Dock = DockStyle.Fill;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(3, 19);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(182, 235);
            listBox3.TabIndex = 3;
            // 
            // listBox4
            // 
            listBox4.Dock = DockStyle.Fill;
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(3, 19);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(240, 169);
            listBox4.TabIndex = 4;
            // 
            // Delete
            // 
            Delete.Dock = DockStyle.Bottom;
            Delete.Location = new Point(3, 221);
            Delete.Name = "Delete";
            Delete.Size = new Size(272, 33);
            Delete.TabIndex = 5;
            Delete.Text = "Borrar";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Bottom;
            button5.Location = new Point(3, 188);
            button5.Name = "button5";
            button5.Size = new Size(240, 33);
            button5.TabIndex = 6;
            button5.Text = "Seleccionar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Bottom;
            button6.Location = new Point(3, 221);
            button6.Name = "button6";
            button6.Size = new Size(240, 33);
            button6.TabIndex = 7;
            button6.Text = "Seleccionar Varios";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.Location = new Point(3, 188);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(272, 33);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Add_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(Delete);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 257);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox4);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(278, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(246, 257);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Carrera";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox2);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(524, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 257);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Registrados";
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.Controls.Add(linkLabel1);
            groupBox4.Controls.Add(listBox3);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(770, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(188, 257);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nunca sabras para que es esto";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = DockStyle.Bottom;
            linkLabel1.Location = new Point(3, 239);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "No toques esto";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(958, 257);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MinimumSize = new Size(974, 296);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button Delete;
        private Button button5;
        private Button button6;
        private Button btnAdd;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private LinkLabel linkLabel1;
    }
}
