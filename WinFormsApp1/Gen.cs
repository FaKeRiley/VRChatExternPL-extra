using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meineForm
{
    public partial class Gen : UserControl
    {
        private static Random random = new Random();
        // Declare the EmailTextBox control
        private TextBox EmailTextBox;
        // Declare the EmailTextBox control
        private TextBox PasswordTextBox;
        public Gen()
        {
            InitializeComponent();
         
        }


        private void button12_Click(object sender, EventArgs e)
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

        private void Gen_Load(object sender, EventArgs e)
        {

        }
    }
}
