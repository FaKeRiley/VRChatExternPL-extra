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
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;


namespace VRChat_Extern
{
    public partial class Page3 : UserControl
    {

        public Page3()
        {
            InitializeComponent();
            // Hier kannst du die Inhalte der ersten Seite definieren
            Label label = new Label();
            label.Text = "Dies ist Seite 3";
            Controls.Add(label);

        }


        private void button11_Click_1(object sender, EventArgs e)
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

        private void Page3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Passe den Dateipfad entsprechend deinem Bedarf an
            string filePath = "config.txt";

            try
            {
                // Prüfe, ob die Datei existiert
                if (File.Exists(filePath))
                {
                    // Datei löschen
                    File.Delete(filePath);
                    MessageBox.Show("Die Datei wurde erfolgreich gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Die Datei existiert nicht.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Löschen der Datei: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
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


        private void button2_Click(object sender, EventArgs e)
        {
            // Passe den Dateipfad entsprechend deinem Bedarf an
            string filePath = "configPL.txt";

            try
            {
                // Prüfe, ob die Datei existiert
                if (File.Exists(filePath))
                {
                    // Datei löschen
                    File.Delete(filePath);
                    MessageBox.Show("Die Datei wurde erfolgreich gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Die Datei existiert nicht.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Löschen der Datei: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

