using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRChat_Extern;

namespace meineForm
{
    public partial class login : UserControl
    {
        private const string profilesFolder = "profiles";
        private const string profileFileName = "profile.txt";
        private string profileFilePath;
      
        public login()
        {
            InitializeComponent();
            profileFilePath = Path.Combine(Application.StartupPath, profilesFolder, profileFileName);

            // Überprüfe, ob der Profile-Ordner vorhanden ist, wenn nicht, erstelle ihn
            if (!Directory.Exists(Path.Combine(Application.StartupPath, profilesFolder)))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, profilesFolder));
            }

            // Lade die vorhandenen Profile, falls vorhanden
            LoadProfiles();
            // Setze die PictureBox-Eigenschaften
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
           

        }
        private void LoadProfiles()
        {
            if (File.Exists(profileFilePath))
            {
                string[] profiles = File.ReadAllLines(profileFilePath);
                foreach (string profile in profiles)
                {
                    textBox1.Text += profile + Environment.NewLine;
                }
            }
        }
        private void SaveProfiles()
        {
            File.WriteAllText(profileFilePath, textBox1.Text.Trim());
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SaveProfiles();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProfiles();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob ein Bild ausgewählt wurde
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Bitte wählen Sie ein Bild aus, das gespeichert werden soll.");
                return;
            }

            // Pfad zum Ordner "profiles" im gleichen Verzeichnis wie das Programm
            string profilesFolder = Path.Combine(Application.StartupPath, "profiles");

            // Überprüfen, ob der Ordner "profiles" existiert, und ihn ggf. erstellen
            if (!Directory.Exists(profilesFolder))
            {
                Directory.CreateDirectory(profilesFolder);
            }

            try
            {
                // Alle Bilddateien im Ordner "profiles" löschen
                string[] imageFiles = Directory.GetFiles(profilesFolder, "*.jpg");
                foreach (string file in imageFiles)
                {
                    File.Delete(file);
                    MessageBox.Show("Altes Bild erfolgreich gelöscht: " + file);
                }

                // Generieren eines eindeutigen Dateinamens für das Bild
                string fileName = $"profile_{DateTime.Now:yyyyMMddHHmmss}.jpg";
                string imagePath = Path.Combine(profilesFolder, fileName);

                // Speichern des Bildes
                pictureBox1.Image.Save(imagePath);

                MessageBox.Show("Bild erfolgreich gespeichert: " + imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beim Speichern des Bildes ist ein Fehler aufgetreten: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Bild auswählen und in PictureBox anzeigen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bilder|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
            }
        }  
        
    }
}

