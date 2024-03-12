using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using VRChat_Extern;
using meineForm;


namespace WinFormsApp1
{
    public partial class Home : Form
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        ///   private Page1 page1 = new Page1();
        private bool isDragging = false;
        private int xOffset;
        private int yOffset;
        private bool isMaximized = false;
        private PointF[] points;
        private PointF[] velocities;
        private System.Windows.Forms.Timer timer;
        private float maxDistanceForConnection = 0.15f;
        private string profilesFolderPath = Path.Combine(Application.StartupPath, "profiles");
        private FileSystemWatcher watcher;
        private ContextMenuStrip contextMenuStrip1;
        private Page1 page1 = new Page1();
        private Page3 page3 = new Page3();
        private Dashboard dashboard = new Dashboard();
        private login login = new login();
        private Gen gen = new Gen();
        private easy_menu ezmenu = new easy_menu();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
        public Home()
        {
            InitializeComponent();

            // Füge die Seiten zur Form hinzu, aber lasse nur die erste sichtbar
            Controls.Add(page1);
            Controls.Add(page3);
            Controls.Add(dashboard);
            Controls.Add(login);
            Controls.Add(gen);
            Controls.Add(ezmenu);
            page1.Visible = false;
            page3.Visible = false;
            dashboard.Visible = true;
            login.Visible = false;
            gen.Visible = false;
            ezmenu.Visible = false;
            // Stelle sicher, dass die Seiten die gesamte Form abdecken
            page1.Dock = DockStyle.Fill;
            page3.Dock = DockStyle.Fill;
            dashboard.Dock = DockStyle.Fill;
            login.Dock = DockStyle.Fill;
            gen.Dock = DockStyle.Fill;
            ezmenu.Dock = DockStyle.Fill;
            // Setze die PictureBox-Eigenschaften
            roundPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void InitializeComponents()
        {
            this.Text = "Background Image from Folder";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void InitializeDragEvents()
        {
            this.panel1.MouseDown += new MouseEventHandler(this.Mousedown);
            this.panel1.MouseUp += new MouseEventHandler(this.Mouseup);
            this.panel1.MouseMove += new MouseEventHandler(this.Mousemove);
        }
        private void ShowPage(UserControl pageToShow)
        {
            // Zeige die ausgewählte Seite und verstecke die anderen
            page1.Visible = (pageToShow == page1);
            page3.Visible = (pageToShow == page3);
            dashboard.Visible = (pageToShow == dashboard);
            login.Visible = (pageToShow == login);
            gen.Visible = (pageToShow == gen);
            ezmenu.Visible = (pageToShow == ezmenu);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Zeige die erste Seite und verstecke die anderen
            page1.Visible = false;
            page3.Visible = false;
            dashboard.Visible = true;
            login.Visible = false;
            gen.Visible = false;
            ezmenu.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Zeige die erste Seite und verstecke die anderen
            page1.Visible = true;
            page3.Visible = false;
            dashboard.Visible = false;
            login.Visible = false;
            gen.Visible = false;
            ezmenu.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Zeige die zweite Seite und verstecke die anderen
            page1.Visible = false;
            page3.Visible = false;
            dashboard.Visible = false;
            login.Visible = false;
            gen.Visible = false;
            ezmenu.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Zeige die dritte Seite und verstecke die anderen
            page1.Visible = false;
            page3.Visible = true;
            dashboard.Visible = false;
            login.Visible = false;
            gen.Visible = false;
            ezmenu.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            page1.Visible = false;
            page3.Visible = false;
            dashboard.Visible = false;
            login.Visible = false;
            gen.Visible = false;
            ezmenu.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Zeige die erste Seite und verstecke die anderen
            page1.Visible = false;
            page3.Visible = false;
            dashboard.Visible = false;
            login.Visible = true;
            gen.Visible = false;
            ezmenu.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
                return;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Schließe das Formular
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            UpdateProfileLabel();
            WatchFileSystem();
            InitializeWatcher();
            UpdateProfilePicture();

            // Einen Eventhandler hinzufügen, der jedes Mal aufgerufen wird, wenn das Bild in der PictureBox neu gezeichnet werden muss
            roundPictureBox1.Paint += roundPictureBox1_Paint;

            // PictureBox so konfigurieren, dass das Bild zentriert und skaliert wird
            roundPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            roundPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
        private void roundPictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Berechnen, wie viel Platz verfügbar ist
            float availableWidth = roundPictureBox1.ClientSize.Width;
            float availableHeight = roundPictureBox1.ClientSize.Height;

            // Das Bild aus der PictureBox holen
            Image image = roundPictureBox1.Image;
            if (image == null)
                return;

            // Das Bild skalieren, um es dem verfügbaren Platz anzupassen
            float imageWidth = image.Width;
            float imageHeight = image.Height;
            float scaleX = availableWidth / imageWidth;
            float scaleY = availableHeight / imageHeight;
            float scaleFactor = Math.Max(scaleX, scaleY);
            float scaledWidth = imageWidth * scaleFactor;
            float scaledHeight = imageHeight * scaleFactor;

            // Den Punkt berechnen, an dem das Bild gezeichnet werden soll, um es zentriert zu positionieren
            float x = (availableWidth - scaledWidth) / 2;
            float y = (availableHeight - scaledHeight) / 2;
            // Das Bild zeichnen
            e.Graphics.DrawImage(image, x, y, scaledWidth, scaledHeight);
        }
        private void InitializeWatcher()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = profilesFolderPath;
            watcher.Filter = "*.jpg";
            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
            watcher.Changed += Watcher_Changed;
            watcher.Deleted += Watcher_Changed;
            watcher.EnableRaisingEvents = true;
        }
        private void WatchFileSystem()
        {
            // Pfad zur Textdatei
            string profilesFolder = Path.Combine(Application.StartupPath, "profiles");
            string filePath = Path.Combine(profilesFolder, "profile.txt");

            // Überwachung der Dateiänderungen
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = profilesFolder;
            watcher.Filter = "profile.txt";
            watcher.NotifyFilter = NotifyFilters.LastWrite;

            // Ereignisbehandlung für Dateiänderungen
            watcher.Changed += (sender, e) =>
            {
                if (e.ChangeType == WatcherChangeTypes.Changed)
                {
                    // Aktualisieren des Labels bei Änderungen in der Datei
                    Invoke(new MethodInvoker(UpdateProfileLabel));
                }
            };

            // Start der Überwachung
            watcher.EnableRaisingEvents = true;
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            UpdateProfilePicture();
        }

        private void UpdateProfilePicture()
        {
            string[] profileImages = Directory.GetFiles(profilesFolderPath, "*.jpg");

            if (profileImages.Length > 0)
            {
                string firstProfileImage = profileImages.First();
                roundPictureBox1.ImageLocation = firstProfileImage;
            }
            else
            {
                roundPictureBox1.Image = null;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            watcher.Dispose();
        }

        private void UpdateProfileLabel()
        {
            // Pfad zur Textdatei
            string profilesFolder = Path.Combine(Application.StartupPath, "profiles");
            string filePath = Path.Combine(profilesFolder, "profile.txt");

            // Überprüfen, ob die Datei existiert
            if (File.Exists(filePath))
            {
                // Text aus der Datei lesen
                string profileText = File.ReadAllText(filePath);

                // Text im Label anzeigen
                label1.Text = profileText;
            }
            else
            {
                // Wenn die Datei nicht existiert, leeres Label anzeigen
                label1.Text = "";
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }



        private void roundPictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Mousedown(object sender, MouseEventArgs e)
        {
            this.isDragging = true;
            this.xOffset = e.X;
            this.yOffset = e.Y;
        }

        private void Mousemove(object sender, MouseEventArgs e)
        {
            if (!this.isDragging)
                return;
            this.SetDesktopLocation(Control.MousePosition.X - this.xOffset, Control.MousePosition.Y - this.yOffset);
        }

        private void Mouseup(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            // Zeige die erste Seite und verstecke die anderen
            page1.Visible = false;
            page3.Visible = false;
            dashboard.Visible = false;
            login.Visible = false;
            gen.Visible = true;
            ezmenu.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Zeige die erste Seite und verstecke die anderen
            page1.Visible = false;
            page3.Visible = false;
            dashboard.Visible = false;
            login.Visible = false;
            gen.Visible = false;
            ezmenu.Visible = true;
        }
    }
}

