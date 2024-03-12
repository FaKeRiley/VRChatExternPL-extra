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

namespace meineForm
{

    public partial class easy_menu : UserControl
    {
        private meineForm.VRChatMenuForm form2; // Deklaration der Form2-Variable außerhalb der Methoden
        private bool isForm2Open = false; // Variable, um den Status von Form2 zu verfolgen
        private meineForm.WorldIndicator form3; // Deklaration der Form2-Variable außerhalb der Methoden
        private bool isForm3Open = false; // Variable, um den Status von Form3 zu verfolgen
        private Process fortniteProcess; // Variable auf Klassenebene deklarieren
        private static Random random = new Random();
        // Declare the EmailTextBox control
        private TextBox EmailTextBox;
        // Declare the EmailTextBox control
        private TextBox PasswordTextBox;

        public easy_menu()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "Dies ist Seite 6";
            Controls.Add(label);
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

        private void button11_Click(object sender, EventArgs e)
        {
            string fileName = "config.txt";
            string fileContent = "schreibe hier den pfad von VRChat rein\n" +
                "gehe auf Steam\n" +
                "dann in deine Bibliothek\n" +
                "dann auf VRChat\n" +
                "dann auf das Einstellungssymbol rechts in der Mitte\n" +
                "dann auf verwalten und als letztes auf lokale dateien durchsuchen\n" +
                "nun steht oben der Pfad mit dem du den Text hier ersetzt";


            try
            {
                // Den Inhalt in die Datei schreiben
                File.WriteAllText(fileName, fileContent);
                MessageBox.Show("Die Konfigurationsdatei wurde erfolgreich erstellt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Die erstellte Datei öffnen
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "notepad.exe",
                    Arguments = fileName
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Erstellen der Konfigurationsdatei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = "configPL.txt";
            string fileContent = "schreibe da wo name steht den nutzernamen des PCs hin \n" +
                "C:\\Users\\Name\\AppData\\LocalLow\\VRChat\\VRChat \n" +
                "dann als letztes löschst du den Text und läst nur den Pfad da stehen";

            try
            {
                // Den Inhalt in die Datei schreiben
                File.WriteAllText(fileName, fileContent);
                MessageBox.Show("Die Konfigurationsdatei wurde erfolgreich erstellt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Die erstellte Datei öffnen
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "notepad.exe",
                    Arguments = fileName
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Erstellen der Konfigurationsdatei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void easy_menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = GenerateUsername();
            string domain = "@outlook.com";
            string password = GeneratePassword();

            string email = username + domain;

            // Überprüfen, ob EmailTextBox nicht null ist, bevor Sie darauf zugreifen
            if (EmailTextBox != null)
                EmailTextBox.Text = email;
            // Ansonsten können Sie eine Fehlerbehandlung hinzufügen, wenn das Textfeld nicht gefunden wird

            // Ebenso überprüfen, ob PasswordTextBox nicht null ist, bevor Sie darauf zugreifen
            if (PasswordTextBox != null)
                PasswordTextBox.Text = password;
            // Ansonsten können Sie eine Fehlerbehandlung hinzufügen, wenn das Textfeld nicht gefunden wird

            // Daten in Textdatei im gleichen Ordner wie das Programm speichern
            SaveDataToFile(username, email, password);
        }

        // Methode zum Speichern von Daten in einer Textdatei
        private void SaveDataToFile(string username, string email, string password)
        {
            // Pfad zur Textdatei im gleichen Ordner wie das Programm
            string fileName = "Anmeldedaten.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            // Mit StreamWriter können Sie Text in eine Datei schreiben
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Benutzername: " + username);
                writer.WriteLine("E-Mail: " + email);
                writer.WriteLine("Passwort: " + password);
            }
        }
        private static string GenerateUsername()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string GeneratePassword()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    
    }
}
