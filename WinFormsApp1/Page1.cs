using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace VRChat_Extern
{
    public partial class Page1 : UserControl
    {
        private meineForm.VRChatMenuForm form2; // Deklaration der Form2-Variable außerhalb der Methoden
        private bool isForm2Open = false; // Variable, um den Status von Form2 zu verfolgen
        private meineForm.WorldIndicator form3; // Deklaration der Form2-Variable außerhalb der Methoden
        private bool isForm3Open = false; // Variable, um den Status von Form3 zu verfolgen
        public Page1()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "Dies ist Seite 1";
            Controls.Add(label);
        }

        private void Page1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string path = Path.Combine(Application.StartupPath, "config.txt");
                try
                {
                    if (File.Exists(path))
                    {
                        string str1 = File.ReadAllText(path).Trim();
                        if (Directory.Exists(str1))
                        {
                            string str2 = Path.Combine(str1, "start_protected_game.exe");
                            if (File.Exists(str2))
                            {
                                Process.Start(str2);
                            }
                            else
                            {
                                int num = (int)MessageBox.Show("Die Datei start_protected_game.exe wurde nicht gefunden.", "Fehler");
                            }
                        }
                        else
                        {
                            int num1 = (int)MessageBox.Show("Der in der Konfigurationsdatei angegebene Pfad ist ungültig.", "Fehler");
                        }
                    }
                    else
                    {
                        int num2 = (int)MessageBox.Show("Die Konfigurationsdatei (config.txt) wurde nicht gefunden. Erstellen Sie die Datei und geben Sie den Pfad für VRChat darin an.", "Fehler");
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcessesByName(Path.GetFileNameWithoutExtension("Vrchat.exe")))
            {
                process.CloseMainWindow();
                process.WaitForExit(5000);
                if (!process.HasExited)
                    process.Kill();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                string path = Path.Combine(Application.StartupPath, "config.txt");
                try
                {
                    if (File.Exists(path))
                    {
                        string str1 = File.ReadAllText(path).Trim();
                        if (Directory.Exists(str1))
                        {
                            string str2 = Path.Combine(str1, "start_protected_game.exe");
                            if (File.Exists(str2))
                            {
                                Process.Start(str2);
                            }
                            else
                            {
                                int num = (int)MessageBox.Show("Die Datei start_protected_game.exe wurde nicht gefunden.", "Fehler");
                            }
                        }
                        else
                        {
                            int num1 = (int)MessageBox.Show("Der in der Konfigurationsdatei angegebene Pfad ist ungültig.", "Fehler");
                        }
                    }
                    else
                    {
                        int num2 = (int)MessageBox.Show("Die Konfigurationsdatei (config.txt) wurde nicht gefunden. Erstellen Sie die Datei und geben Sie den Pfad für VRChat darin an.", "Fehler");
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message, "Fehler");
                }
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (!isForm2Open) // Überprüfen, ob Form2 nicht geöffnet ist
            {
                form2 = new meineForm.VRChatMenuForm(); // Erstelle eine neue Instanz von VRChatMenuForm
                form2.Show(); // Zeige VRChatMenuForm an
                isForm2Open = true; // Setze den Status von Form2 auf geöffnet
            }
            else
            {
                form2.Close(); // Schließe VRChatMenuForm, wenn sie bereits geöffnet ist
                isForm2Open = false; // Setze den Status von Form2 auf geschlossen
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcessesByName(Path.GetFileNameWithoutExtension("Vrchat.exe")))
            {
                process.CloseMainWindow();
                process.WaitForExit(5000);
                if (!process.HasExited)
                    process.Kill();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isForm3Open) // Überprüfen, ob Form2 nicht geöffnet ist
            {
                form3 = new meineForm.WorldIndicator(); // Erstelle eine neue Instanz von VRChatMenuForm
                form3.Show(); // Zeige VRChatMenuForm an
                isForm3Open = true; // Setze den Status von Form2 auf geöffnet
            }
            else
            {
                form3.Close(); // Schließe VRChatMenuForm, wenn sie bereits geöffnet ist
                isForm3Open = false; // Setze den Status von Form2 auf geschlossen
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Pfad zum Ordner mit der EXE-Datei erstellen
            string folderPath = Path.Combine(Directory.GetParent(Application.StartupPath).FullName, "Console");
            // Pfad zur EXE-Datei erstellen
            string exePath = Path.Combine(folderPath, "UnknownClient.exe");

            // Überprüfen, ob die EXE-Datei existiert
            if (File.Exists(exePath))
            {
                try
                {
                    // ProcessStartInfo konfigurieren
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = exePath;
                    // Arbeitsverzeichnis festlegen
                    startInfo.WorkingDirectory = folderPath;
                    // startInfo.Verb = "runas"; // Wenn nicht erforderlich, Administratorrechte entfernen
                    // EXE-Datei ausführen
                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Ausführen der EXE-Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Die EXE-Datei wurde nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
