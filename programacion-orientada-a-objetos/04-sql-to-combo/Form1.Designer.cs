namespace _04_sql_to_combo
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
            comboBox1 = new ComboBox();
            btnLoadCombo = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(258, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 23);
            comboBox1.TabIndex = 0;
            // 
            // btnLoadCombo
            // 
            btnLoadCombo.Location = new Point(258, 112);
            btnLoadCombo.Name = "btnLoadCombo";
            btnLoadCombo.Size = new Size(116, 23);
            btnLoadCombo.TabIndex = 1;
            btnLoadCombo.Text = "Cargar ComboBox";
            btnLoadCombo.UseVisualStyleBackColor = true;
            btnLoadCombo.Click += btnLoadComboClick;
            // 
            // button2
            // 
            button2.Location = new Point(442, 112);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnLoadCombo);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button btnLoadCombo;
        private Button button2;
    }
}
