using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace meineForm
{
    public class RoundPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                this.Region = new Region(path);
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new Pen(this.BackColor, 2), 0, 0, this.Width - 1, this.Height - 1);
            }
            base.OnPaint(pe);
        }
    }

    public class Home : Form
    {
        private RoundPictureBox roundPictureBox1;

        public Home()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.roundPictureBox1 = new RoundPictureBox();
            this.SuspendLayout();
            // Set the location and size of the round picture box
            this.roundPictureBox1.Location = new Point(50, 50);
            this.roundPictureBox1.Size = new Size(200, 200);

            // Load an image into the round picture box
            this.roundPictureBox1.Image = Image.FromFile("path_to_your_image.jpg");
            this.roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Add the round picture box to the form
            this.Controls.Add(this.roundPictureBox1);

            this.ClientSize = new Size(300, 300);
            this.ResumeLayout(false);
        }
    }

    class Program
    {
        [STAThread]
        static void Home()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}