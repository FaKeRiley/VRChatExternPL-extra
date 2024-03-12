namespace meineForm
{
    partial class Gen
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
            button12 = new Button();
            SuspendLayout();
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(20, 0, 40);
            button12.FlatStyle = FlatStyle.Popup;
            button12.ForeColor = Color.WhiteSmoke;
            button12.Location = new Point(276, 222);
            button12.Name = "button12";
            button12.Size = new Size(793, 281);
            button12.TabIndex = 15;
            button12.Text = "Gen";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // Gen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 0, 10);
            Controls.Add(button12);
            Name = "Gen";
            Size = new Size(1176, 646);
            Load += Gen_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button12;
    }
}
