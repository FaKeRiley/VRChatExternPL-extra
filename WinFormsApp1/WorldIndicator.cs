using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection;

namespace meineForm
{

    public partial class WorldIndicator : Form
    {

        public string EventType { get; set; }
        public string PlayerName { get; set; }



        private System.Timers.Timer cursorTimer;
        private Color[] blinkColors = { Color.Purple, Color.DarkViolet, }; // Füge die Farben hinzu, die du verwenden möchtest
        private int colorIndex = 0;

        private Point mousePosition = Point.Empty;

        private int hoverRadius = 50; // Der Radius, bei dem der Punkt unsichtbar wird



        private bool hoverEffect = false;


        private int playerCounter = 0;

        private Point dragOffset;

        private List<string> uniqueTexts = new List<string>(); // Liste für einzigartige Texte
        private HashSet<string> playerNames = new HashSet<string>(); // HashSet für Spieler-Namenn
        private System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Label labelPlayerEvents; // Verwenden Sie die vollständige Qualifikation

        
        private HashSet<string> bannedNames = new HashSet<string>();

        private Random random = new Random();
        private Point[] starPositions;
        private int numberOfStars = 50; // Change this value based on your requirements

        private int mouseX, mouseY;
        private bool isDragging = false;

        private System.Timers.Timer starMovementTimer = new System.Timers.Timer();
        private int[] alphaValues;
        private Color pointColor;
        private Point[] points;
        private Dictionary<Point, Point> connections;
        private System.Timers.Timer timer;
        private Point[] targetPositions;
        // Importieren der Windows API-Funktion SetWindowPos
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        // Konstanten für SetWindowPos
        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOMOVE = 0x0002;
        const int HWND_TOPMOST = -1;

        private string currentWorld = "";





        public WorldIndicator()
        {

            cursorTimer = new System.Timers.Timer();
            cursorTimer.Interval = 1000; // Intervall in Millisekunden (z.B., 500 ms für halbes Sekunden)

            // Starte den Timer
            cursorTimer.Start();
            InitializeComponent();
            DoubleBuffered = true;

            InitializePoints();
            // Setze den benutzerdefinierten Cursor für das Formular
            timer = new System.Timers.Timer();
            // Setze den benutzerdefinierten Cursor für das Formular
            // Abonnieren Sie die Mausereignisse für das Formular
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;
            label1.Size = new Size(10, 10);
            // Setze eine kleinere Schriftgröße         
            updateTimer.Interval = 4000; // Aktualisiere alle 2 Sekunden
            updateTimer.Tick += VRChatMenuForm_Load;
            updateTimer.Start(); // Starte den Timer
            updateTimer.Interval = 200; // Aktualisiere alle 2 Sekunden
            timer1.Tick += Timer_Tick;
            timer1.Start();

            



        }
      
        private void InitializePoints()
        {
            int numberOfPoints = 50;
            points = new Point[numberOfPoints];
            targetPositions = new Point[numberOfPoints];
            alphaValues = new int[numberOfPoints];

            Random random = new Random();

            // Initialisiere die Punkte mit zufälligen Positionen und Transparenzwerten
            for (int i = 0; i < numberOfPoints; i++)
            {
                points[i] = new Point(random.Next(Width), random.Next(Height));
                targetPositions[i] = new Point(random.Next(Width), random.Next(Height));
                alphaValues[i] = 1; // Vollständig sichtbar
            }
            pointColor = Color.FromArgb(128, 0, 128);
        }


















        private Cursor CreateCursorWithColor(Bitmap bitmap, Color currentColor, Color nextColor, int newSize)
        {
            // Erstelle eine neue Bitmap mit der gewünschten Größe
            Bitmap resizedBitmap = new Bitmap(bitmap, new Size(newSize, newSize));

            // Iteriere über jedes Pixel in der neuen Bitmap
            for (int x = 0; x < resizedBitmap.Width; x++)
            {
                for (int y = 0; y < resizedBitmap.Height; y++)
                {
                    Color originalColor = resizedBitmap.GetPixel(x, y);

                    if (originalColor.A > 0) // Prüfe auf nicht transparente Pixel
                    {
                        // Interpoliere zwischen der aktuellen und der nächsten Farbe
                        float interpolationFactor = (float)x / resizedBitmap.Width;
                        Color interpolatedColor = InterpolateColor(currentColor, nextColor, interpolationFactor);

                        // Führe die Farbänderung durch
                        int blendedR = (int)(originalColor.R * (1 - interpolatedColor.A / 255.0) + interpolatedColor.R * (interpolatedColor.A / 255.0));
                        int blendedG = (int)(originalColor.G * (1 - interpolatedColor.A / 255.0) + interpolatedColor.G * (interpolatedColor.A / 255.0));
                        int blendedB = (int)(originalColor.B * (1 - interpolatedColor.A / 255.0) + interpolatedColor.B * (interpolatedColor.A / 255.0));

                        Color blendedColor = Color.FromArgb(originalColor.A, blendedR, blendedG, blendedB);
                        resizedBitmap.SetPixel(x, y, blendedColor);
                    }
                }
            }

            // Erstelle einen Cursor aus der modifizierten Bitmap
            return new Cursor(resizedBitmap.GetHicon());
        }

        private Color InterpolateColor(Color startColor, Color endColor, float factor)
        {
            int interpolatedR = (int)(startColor.R + (endColor.R - startColor.R) * factor);
            int interpolatedG = (int)(startColor.G + (endColor.G - startColor.G) * factor);
            int interpolatedB = (int)(startColor.B + (endColor.B - startColor.B) * factor);
            int interpolatedA = (int)(startColor.A + (endColor.A - startColor.A) * factor);

            return Color.FromArgb(interpolatedA, interpolatedR, interpolatedG, interpolatedB);
        }

        // Erstelle einen Cursor aus der modifizierten Bitmap

        private void VRChatMenuForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.label1.Paint += new PaintEventHandler(this.Label_Paint);
            this.KeyPreview = true;
            this.TransparencyKey = Color.Black;
            this.Opacity = 0.4;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(200, 40);
            this.TopMost = true;
            CenterLabel();
            // Einstellungen für das Label
            this.label1.BackColor = Color.Transparent;
            this.label1.ForeColor = Color.Purple;
            this.label1.Font = new Font(this.label1.Font.FontFamily, 9f);

            try
            {
                // Pfad zur Konfigurationsdatei
                string configFilePath = "configPL.txt";

                // Lese den Pfad aus der Konfigurationsdatei
                string logFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), File.ReadAllText(configFilePath).Trim());

                string latestLogFile = GetLatestLogFile(logFilePath);
                if (string.IsNullOrEmpty(latestLogFile))
                    return;

                string[] playerEventLines = FindPlayerEventLines(latestLogFile);
                ExtractWorldAndPlayer(playerEventLines[playerEventLines.Length - 1]); // Extrahiere die neueste Weltinformation

                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.BackColor = Color.Transparent;
                label1.ForeColor = Color.Purple;
                label1.Font = new Font(label1.Font.FontFamily, 9, FontStyle.Regular); // Wählen Sie eine passende Schriftgröße
                label1.BorderStyle = BorderStyle.FixedSingle; // Zeigt den Rahmen des Labels an
            }
            catch (Exception ex)
            {
                label1.Text = "Fehler: " + ex.Message;
            }
        }

            
        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            try
            {
                // Pfad zur Konfigurationsdatei
                string configFilePath = "configPL.txt";

                // Lese den Pfad aus der Konfigurationsdatei
                string logFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), File.ReadAllText(configFilePath).Trim());

                // Erhalte den neuesten Log-Dateipfad
                string latestLogFile = GetLatestLogFile(logFilePath);

                // Aktualisiere das Label mit den aktuellen Spielern
                string[] playerEventLines = FindPlayerEventLines(latestLogFile);
                ExtractWorldAndPlayer(playerEventLines[playerEventLines.Length - 1]); // Extrahiere die neueste Weltinformation

                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.ForeColor = Color.Black; // Wählen Sie eine passende Textfarbe
                label1.Font = new Font(label1.Font.FontFamily, 12f, FontStyle.Regular); // Wählen Sie eine passende Schriftgröße
                label1.BorderStyle = BorderStyle.FixedSingle; // Zeigt den Rahmen des Labels an
            }
            catch (Exception ex)
            {
                // Behandle Fehler und aktualisiere das Label entsprechend
                label1.Text = "Fehler: " + ex.Message;
                label1.ForeColor = Color.Black;
                label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size);
            }
        }

            private void AktualisiereSchriftgroesse() => this.label1.Font = new Font(this.label1.Font.FontFamily, this.label1.Font.Size / 1f, this.label1.Font.Style);

        private string[] FindPlayerEventLines(string filePath)
        {
            string[] array;
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader streamReader = new StreamReader((Stream)fileStream))
                    array = ((IEnumerable<string>)streamReader.ReadToEnd().Split('\n')).Where<string>((Func<string, bool>)(line => line.Contains("Room:") || line.Contains("OnPlayerLeft"))).ToArray<string>();
            }
            return array.Length != 0 ? array : throw new InvalidOperationException("Keine Zeilen mit 'Room:' wurden gefunden.");
        }

        private void ExtractWorldAndPlayer(string line)
        {
            if (line.Contains("Room:"))
            {
                string world = line.Substring(line.IndexOf("Room:") + "Room:".Length).Trim();
                label1.Text = $"(◣ _ ◢)𓆩𝚆𝙾𝚁𝙻𝙳🖤𓆪𓆩(◣ _ ◢)\n{world}";
                currentWorld = world;
            }
        }

        private DateTime ExtractTimeStamp(string line)
        {
            Match match = Regex.Match(line, "\\d{4}\\.\\d{2}\\.\\d{2} \\d{2}:\\d{2}:\\d{2}");
            DateTime result;
            return match.Success && DateTime.TryParse(match.Value, out result) ? result : DateTime.MinValue;
        }

        private string GetLatestLogFile(string directoryPath)
        {
            try
            {
                return (((IEnumerable<FileInfo>)new DirectoryInfo(directoryPath).GetFiles("output_log_*.txt")).OrderByDescending<FileInfo, DateTime>((Func<FileInfo, DateTime>)(file => file.LastWriteTime)).FirstOrDefault<FileInfo>() ?? throw new FileNotFoundException("Keine Log-Dateien im angegebenen Verzeichnis gefunden.")).FullName;
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Suchen der neuesten Log-Datei.", ex);
            }
        }
        private void CenterLabel()
        {
            // Berechne die Position für die Mitte des Formulars
            int centerX = (this.Width - this.label1.Width) / 2;
            int centerY = (this.Height - this.label1.Height) / 13;

            // Setze die Position des Labels
            this.label1.Location = new Point(centerX, centerY);

            // Überprüfe, ob das Label über den rechten Rand hinausgeht
            if (this.label1.Right > this.ClientSize.Width)
            {
                // Passe die Breite des Labels an, um innerhalb des Formulars zu bleiben
                this.label1.Width = this.ClientSize.Width - this.label1.Left;
            }
        }
        private void Label_Paint(object sender, PaintEventArgs e)
        {
            int x = this.label1.Location.X;
            int y = this.label1.Location.Y;
            int width = this.label1.Width - 1;
            int height = this.label1.Height - 1;





        }


        private void Timer_Tick(object sender, EventArgs e)
        {

            MovePoints();

            // Zeichne das Formular neu
            Invalidate();

        }


        private void MovePoints()
        {
            // Größere Schrittgröße für schnellere Bewegungen
            for (int i = 0; i < points.Length; i++)
            {
                alphaValues[i] = Math.Max(2, alphaValues[i] - 2); // Verringere um 5 (kann angepasst werden)
            }

            // Bewege jeden Punkt schrittweise in Richtung des Ziels
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(
                    MoveTowards(points[i].X, targetPositions[i].X, 2),
                    MoveTowards(points[i].Y, targetPositions[i].Y, 2)
                );
            }
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] == targetPositions[i])
                {
                    targetPositions[i] = new Point(new Random().Next(Width), new Random().Next(Height));
                    alphaValues[i] = 255; // Setze die Transparenz wieder auf vollständig sichtbar
                }
            }
        }

        private int MoveTowards(int current, int target, int maxStep)
        {
            if (current == target)
            {
                return current;
            }
            else
            {
                int direction = Math.Sign(target - current);
                int next = current + direction * Math.Min(maxStep, Math.Abs(target - current));
                return next;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Zeichne die Punkte mit Transparenz
            for (int i = 0; i < points.Length; i++)
            {
                using (Brush pointBrush = new SolidBrush(Color.FromArgb(alphaValues[1], pointColor)))
                {
                    e.Graphics.FillEllipse(pointBrush, points[i].X - 2, points[i].Y - 0, 0, 0);
                }
            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Verbinde nahe beieinander liegende Punkte mit Linien
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    // Berechne die Entfernung zwischen den Punkten
                    double distance = Math.Sqrt(Math.Pow(points[i].X - points[j].X, 2) + Math.Pow(points[i].Y - points[j].Y, 2));

                    // Setze eine Mindestentfernung, ab der eine Linie gezeichnet wird
                    if (distance < 15) // Du kannst den Schwellenwert anpassen
                    {
                        // Berechne die Alpha-Komponente basierend auf der Entfernung
                        int alpha = (int)(25 * (1 - distance / 35)); // Hier kannst du den Faktor anpassen

                        // Wähle die Linienfarbe basierend auf der Entfernung und der berechneten Alpha-Komponente
                        Color lineColor = Color.FromArgb(alpha, Color.Black);

                        using (Pen linePen = new Pen(lineColor))
                        {
                            e.Graphics.DrawLine(linePen, points[i], points[j]);
                        }

                    }
                }
            }
        }

        private void LoadBannedNames()
        {
            try
            {
                // Pfad zur Konfigurationsdatei
                string configFilePath = "configPL.txt";

                // Lese den Pfad aus der Konfigurationsdatei
                string nameFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), File.ReadAllText(configFilePath).Trim());

                // Lese die Namen aus der Datei und füge sie der HashSet hinzu
                string[] names = File.ReadAllLines(nameFilePath);
                bannedNames = new HashSet<string>(names, StringComparer.OrdinalIgnoreCase); // Case-insensitive Vergleich
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Laden der gebannten Namen: " + ex.Message);
            }

        }







        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            // Überprüfen Sie, ob die linke Maustaste gedrückt wurde
            if (e.Button == MouseButtons.Left)
            {
                // Speichern Sie den Verschiebungsversatz
                dragOffset = new Point(e.X, e.Y);
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            // Überprüfen Sie, ob die linke Maustaste gedrückt wird und die Verschiebung aktiv ist
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // Berechnen Sie die neue Position des Formulars basierend auf dem Verschiebungsversatz
                Point newLocation = new Point(this.Left + e.X - dragOffset.X, this.Top + e.Y - dragOffset.Y);

                // Setzen Sie die neue Position des Formulars
                this.Location = newLocation;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            // Überprüfen Sie, ob die linke Maustaste freigegeben wurde
            if (e.Button == MouseButtons.Left)
            {
                // Setzen Sie den Verschiebungsversatz zurück
                dragOffset = Point.Empty;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            isDragging = true;
            {
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            {

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }


        private void WorldIndicator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
