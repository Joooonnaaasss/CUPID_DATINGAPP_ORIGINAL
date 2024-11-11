using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CUPID_DATINGAPP
{
    public partial class Log : UserControl
    {
        public Log()
        {
            InitializeComponent();
        }

        // Beschreibung von Login wird entfernt nach Userclick
        private void UserTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UserTextBox.Text == "Benutzername")
            {
                UserTextBox.Text = "";
                UserTextBox.Foreground = new SolidColorBrush(Colors.Black); // Setze die Schriftfarbe auf schwarz
            }
        }

        private void UserTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserTextBox.Text))
            {
                UserTextBox.Text = "Benutzername";
                UserTextBox.Foreground = new SolidColorBrush(Color.FromRgb(153, 153, 153)); // Setze die Schriftfarbe zurück
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
                PasswordBox.Foreground = new SolidColorBrush(Colors.Black); // Setze die Schriftfarbe auf schwarz
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                PasswordBox.Text = "Password";
                PasswordBox.Foreground = new SolidColorBrush(Color.FromRgb(153, 153, 153)); // Setze die Schriftfarbe zurück
            }
        }
        //---------------------------------------------------------------
        private void AnmeldenButton_Click(object sender, RoutedEventArgs e)
        {
            


            // Hier kannst du die Login-Logik hinzufügen
            string username = UserTextBox.Text;
            string password = PasswordBox.Text;

            // Beispielhafte Überprüfung der Anmeldedaten
            if (ValidateLogin(username, password))
            {
                // Wenn die Anmeldedaten korrekt sind, navigiere zum Hauptmenü
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.ShowFrame(mainWindow.MenuFrame); // Navigiere zum Menü und zur Hauptseite
            }
            else
            {
                // Zeige eine Fehlermeldung, wenn die Anmeldedaten falsch sind
                MessageBox.Show("Benutzername oder Passwort ist falsch. Bitte versuchen Sie es erneut.", "Login Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Hier wird die Registrierung angezeigt
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowFrame(mainWindow.RegistrierFrame); // Zeigt den UserDataFrame oder eine Registrierungs-Seite an
        }

        private void PasswordForget(object sender, MouseButtonEventArgs e)
        {
            // Hier kannst du die Logik zum Zurücksetzen des Passworts hinzufügen
            MessageBox.Show("Bitte kontaktieren Sie den Support, um Ihr Passwort zurückzusetzen.", "Passwort vergessen", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private bool ValidateLogin(string username, string password)
        {
            // Beispielhafte Logik zur Validierung des Logins
            return username == "admin" && password == "password"; // Ersetze dies durch echte Logik
        }
    }
}