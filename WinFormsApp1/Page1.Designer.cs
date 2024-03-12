namespace VRChat_Extern
{
    partial class Page1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            button9 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(20, 0, 40);
            button9.FlatStyle = FlatStyle.Popup;
            button9.ForeColor = Color.WhiteSmoke;
            button9.Location = new Point(622, 394);
            button9.Name = "button9";
            button9.Size = new Size(153, 72);
            button9.TabIndex = 14;
            button9.Text = "open und close Playerlist";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 0, 40);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(416, 394);
            button2.Name = "button2";
            button2.Size = new Size(171, 72);
            button2.TabIndex = 13;
            button2.Text = "VRC close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 0, 40);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(202, 394);
            button1.Name = "button1";
            button1.Size = new Size(175, 72);
            button1.TabIndex = 12;
            button1.Text = "VRC start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(341, 163);
            button3.Name = "button3";
            button3.Size = new Size(510, 180);
            button3.TabIndex = 15;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(20, 0, 40);
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(806, 394);
            button4.Name = "button4";
            button4.Size = new Size(153, 72);
            button4.TabIndex = 16;
            button4.Text = "open und close Worldname";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(20, 0, 40);
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(516, 497);
            button5.Name = "button5";
            button5.Size = new Size(171, 72);
            button5.TabIndex = 17;
            button5.Text = "OSC";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Page1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 0, 10);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button9);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Page1";
            Size = new Size(1176, 646);
            Load += Page1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button9;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
