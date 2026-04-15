namespace _06_get_set
{
    partial class FormGetSet
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
            tbRaw = new TextBox();
            btnTransfer = new Button();
            tbGreeting = new TextBox();
            tbValue1 = new TextBox();
            btnSend = new Button();
            tbValue2 = new TextBox();
            SuspendLayout();
            // 
            // tbRaw
            // 
            tbRaw.Anchor = AnchorStyles.Left;
            tbRaw.Location = new Point(6, 114);
            tbRaw.Name = "tbRaw";
            tbRaw.PlaceholderText = "Texto sin procesar";
            tbRaw.Size = new Size(164, 23);
            tbRaw.TabIndex = 7;
            // 
            // btnTransfer
            // 
            btnTransfer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTransfer.Location = new Point(176, 114);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(123, 23);
            btnTransfer.TabIndex = 6;
            btnTransfer.Text = "Pasar";
            btnTransfer.UseVisualStyleBackColor = true;
            // 
            // tbPretty
            // 
            tbGreeting.Anchor = AnchorStyles.Right;
            tbGreeting.Location = new Point(305, 114);
            tbGreeting.Name = "tbPretty";
            tbGreeting.PlaceholderText = "Texto procesado";
            tbGreeting.Size = new Size(202, 23);
            tbGreeting.TabIndex = 8;
            // 
            // tbValue1
            // 
            tbValue1.Anchor = AnchorStyles.Left;
            tbValue1.Location = new Point(5, 274);
            tbValue1.Name = "tbValue1";
            tbValue1.PlaceholderText = "Dato 1";
            tbValue1.Size = new Size(165, 23);
            tbValue1.TabIndex = 10;
            tbValue1.TextChanged += tbValues_TextChanged;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSend.Location = new Point(346, 272);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(161, 23);
            btnSend.TabIndex = 11;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbValue2
            // 
            tbValue2.Anchor = AnchorStyles.Left;
            tbValue2.Location = new Point(176, 273);
            tbValue2.MaximumSize = new Size(164, 23);
            tbValue2.Name = "tbValue2";
            tbValue2.PlaceholderText = "Dato 2";
            tbValue2.Size = new Size(164, 23);
            tbValue2.TabIndex = 9;
            tbValue2.TextChanged += tbValues_TextChanged;
            // 
            // FormGetSet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(tbRaw);
            Controls.Add(btnTransfer);
            Controls.Add(tbGreeting);
            Controls.Add(tbValue1);
            Controls.Add(btnSend);
            Controls.Add(tbValue2);
            MinimumSize = new Size(529, 489);
            Name = "FormGetSet";
            Text = "FormGetSet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbRaw;
        private Button btnTransfer;
        private TextBox tbGreeting;
        private TextBox tbValue1;
        private Button btnSend;
        private TextBox tbValue2;
    }
}