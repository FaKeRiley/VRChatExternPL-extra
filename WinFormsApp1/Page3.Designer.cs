namespace VRChat_Extern
{
    partial class Page3
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            button11 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 0, 40);
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(341, 378);
            button3.Name = "button3";
            button3.Size = new Size(200, 92);
            button3.TabIndex = 11;
            button3.Text = "config löschen";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(20, 0, 40);
            button11.FlatStyle = FlatStyle.Popup;
            button11.ForeColor = Color.WhiteSmoke;
            button11.Location = new Point(341, 239);
            button11.Name = "button11";
            button11.Size = new Size(200, 92);
            button11.TabIndex = 10;
            button11.Text = "config create";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 0, 40);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(657, 239);
            button1.Name = "button1";
            button1.Size = new Size(197, 92);
            button1.TabIndex = 12;
            button1.Text = "configPL create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(20, 0, 40);
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(348, 155);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 13;
            label1.Text = "VRChat starten";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(20, 0, 40);
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(691, 155);
            label2.Name = "label2";
            label2.Size = new Size(123, 37);
            label2.TabIndex = 14;
            label2.Text = "Playerlist";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 0, 40);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(657, 378);
            button2.Name = "button2";
            button2.Size = new Size(199, 92);
            button2.TabIndex = 15;
            button2.Text = "Config löschen";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Page3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 0, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button11);
            Name = "Page3";
            Size = new Size(1176, 646);
            Load += Page3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button11;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}
