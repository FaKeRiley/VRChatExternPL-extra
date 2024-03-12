namespace meineForm
{
    partial class easy_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(easy_menu));
            button4 = new Button();
            button9 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button11 = new Button();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(20, 0, 40);
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(330, 329);
            button4.Name = "button4";
            button4.Size = new Size(106, 43);
            button4.TabIndex = 20;
            button4.Text = "open und close Worldname";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(20, 0, 40);
            button9.FlatStyle = FlatStyle.Popup;
            button9.ForeColor = Color.WhiteSmoke;
            button9.Location = new Point(330, 267);
            button9.Name = "button9";
            button9.Size = new Size(106, 43);
            button9.TabIndex = 19;
            button9.Text = "open und close Playerlist";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 0, 40);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(767, 206);
            button2.Name = "button2";
            button2.Size = new Size(106, 43);
            button2.TabIndex = 18;
            button2.Text = "VRC close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 0, 40);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(330, 206);
            button1.Name = "button1";
            button1.Size = new Size(106, 43);
            button1.TabIndex = 17;
            button1.Text = "VRC start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 0, 40);
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(767, 329);
            button3.Name = "button3";
            button3.Size = new Size(106, 43);
            button3.TabIndex = 24;
            button3.Text = "configPL create";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(20, 0, 40);
            button11.FlatStyle = FlatStyle.Popup;
            button11.ForeColor = Color.WhiteSmoke;
            button11.Location = new Point(767, 267);
            button11.Name = "button11";
            button11.Size = new Size(106, 43);
            button11.TabIndex = 23;
            button11.Text = "config create";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(20, 0, 40);
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(495, 461);
            button5.Name = "button5";
            button5.Size = new Size(199, 109);
            button5.TabIndex = 25;
            button5.Text = "Gen";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(451, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 300);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // easy_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 0, 10);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button11);
            Controls.Add(button4);
            Controls.Add(button9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Name = "easy_menu";
            Size = new Size(1176, 646);
            Load += easy_menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button9;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button11;
        private Button button5;
        private PictureBox pictureBox2;
    }
}
