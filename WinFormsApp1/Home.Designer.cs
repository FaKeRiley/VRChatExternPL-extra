namespace WinFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            button7 = new Button();
            label3 = new Label();
            button8 = new Button();
            panel1 = new Panel();
            button9 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            roundPictureBox1 = new meineForm.RoundPictureBox();
            pictureBox1 = new PictureBox();
            button10 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(949, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 34);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(50, 0, 100);
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(1146, 3);
            button7.Name = "button7";
            button7.Size = new Size(32, 23);
            button7.TabIndex = 2;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Violet;
            label3.Location = new Point(233, 28);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 3;
            label3.Text = "Home";
            label3.Click += label3_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(50, 0, 100);
            button8.FlatStyle = FlatStyle.Popup;
            button8.ForeColor = SystemColors.ButtonFace;
            button8.Location = new Point(1110, 3);
            button8.Name = "button8";
            button8.Size = new Size(30, 22);
            button8.TabIndex = 2;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 0, 40);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 646);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Popup;
            button9.ForeColor = Color.WhiteSmoke;
            button9.Location = new Point(3, 312);
            button9.Name = "button9";
            button9.Size = new Size(170, 47);
            button9.TabIndex = 6;
            button9.Text = "Gen";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = Color.WhiteSmoke;
            button6.Location = new Point(3, 259);
            button6.Name = "button6";
            button6.Size = new Size(170, 47);
            button6.TabIndex = 5;
            button6.Text = "Personifizieren";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(0, 206);
            button4.Name = "button4";
            button4.Size = new Size(170, 47);
            button4.TabIndex = 3;
            button4.Text = "config";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 0, 40);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(0, 153);
            button2.Name = "button2";
            button2.Size = new Size(170, 47);
            button2.TabIndex = 1;
            button2.Text = "VRChat";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(20, 0, 40);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(0, 100);
            button1.Name = "button1";
            button1.Size = new Size(170, 47);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 0, 40);
            panel2.Controls.Add(roundPictureBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button10);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 85);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += Mousedown;
            panel2.MouseMove += Mousemove;
            panel2.MouseUp += Mouseup;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackColor = Color.White;
            roundPictureBox1.BackgroundImageLayout = ImageLayout.Center;
            roundPictureBox1.Location = new Point(872, 12);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(53, 50);
            roundPictureBox1.TabIndex = 7;
            roundPictureBox1.TabStop = false;
            roundPictureBox1.Click += roundPictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(178, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(20, 0, 40);
            button10.BackgroundImageLayout = ImageLayout.Center;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Location = new Point(167, 12);
            button10.Name = "button10";
            button10.Size = new Size(60, 60);
            button10.TabIndex = 6;
            button10.Text = "i";
            button10.TextImageRelation = TextImageRelation.ImageAboveText;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 0, 10);
            ClientSize = new Size(1176, 646);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Form1";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button6;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button7;
        private Label label3;
        private Button button8;
        private Panel panel2;
        private meineForm.RoundPictureBox roundPictureBox2;
        private meineForm.RoundPictureBox roundPictureBox1;
        private Button button9;
        private PictureBox pictureBox1;
        private Button button10;
    }
}
