namespace meineForm
{
    partial class login
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
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(358, 136);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 1;
            label1.Text = "Your Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(649, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 154);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 0, 40);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(614, 121);
            button1.Name = "button1";
            button1.Size = new Size(96, 34);
            button1.TabIndex = 3;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 0, 40);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(758, 121);
            button2.Name = "button2";
            button2.Size = new Size(92, 34);
            button2.TabIndex = 4;
            button2.Text = "brows";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(684, 173);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 5;
            label2.Text = "Picture perview";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 0, 10);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "login";
            Size = new Size(1176, 646);
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1; 
        private Button button1;
        private Button button2;
        private Label label2;
    }
}
