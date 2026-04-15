namespace _06_get_set
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
            pForms = new Panel();
            groupBox1 = new GroupBox();
            btnCheckBox = new Button();
            btnGetSet = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            tbValue2 = new TextBox();
            label2 = new Label();
            tbValue1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pForms
            // 
            pForms.Dock = DockStyle.Right;
            pForms.Location = new Point(264, 0);
            pForms.Name = "pForms";
            pForms.Size = new Size(594, 450);
            pForms.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCheckBox);
            groupBox1.Controls.Add(btnGetSet);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.MaximumSize = new Size(264, 200000);
            groupBox1.MinimumSize = new Size(264, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 250);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnCheckBox
            // 
            btnCheckBox.Dock = DockStyle.Top;
            btnCheckBox.Location = new Point(3, 42);
            btnCheckBox.Name = "btnCheckBox";
            btnCheckBox.Size = new Size(258, 23);
            btnCheckBox.TabIndex = 1;
            btnCheckBox.Text = "Check Box";
            btnCheckBox.UseVisualStyleBackColor = true;
            btnCheckBox.Click += btnCheckBox_Click;
            // 
            // btnGetSet
            // 
            btnGetSet.Dock = DockStyle.Top;
            btnGetSet.Location = new Point(3, 19);
            btnGetSet.Name = "btnGetSet";
            btnGetSet.Size = new Size(258, 23);
            btnGetSet.TabIndex = 0;
            btnGetSet.Text = "GET - SET";
            btnGetSet.UseVisualStyleBackColor = true;
            btnGetSet.Click += btnGetSet_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbValue2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbValue1);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 250);
            groupBox2.MinimumSize = new Size(264, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 250);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos recibidos";
            // 
            // tbValue2
            // 
            tbValue2.Dock = DockStyle.Top;
            tbValue2.Location = new Point(3, 72);
            tbValue2.Name = "tbValue2";
            tbValue2.Size = new Size(258, 23);
            tbValue2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Dato 2";
            // 
            // tbValue1
            // 
            tbValue1.Dock = DockStyle.Top;
            tbValue1.Location = new Point(3, 34);
            tbValue1.Name = "tbValue1";
            tbValue1.Size = new Size(258, 23);
            tbValue1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Dato 1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pForms);
            Name = "FormPrincipal";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pForms;
        private GroupBox groupBox1;
        private Button btnCheckBox;
        private Button btnGetSet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        public TextBox tbValue2;
        public TextBox tbValue1;
    }
}
