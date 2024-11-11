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
    /// <summary>
    /// Interaction logic for UserSettings.xaml
    /// </summary>
    public partial class UserSettings : UserControl
    {
        public UserSettings()
        {
            InitializeComponent();
        }

        // Event-Handler für den Abmelde-Button
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowFrame(mainWindow.LogFrame); // Zur Login-Seite wechseln
            MessageBox.Show("Sie wurden erfolgreich abgemeldet.", "Abmeldung", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Event-Handler für den Account löschen Button
        private void DeleteAccountButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Möchten Sie Ihren Account wirklich löschen?", "Account löschen", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                // Logik zum Löschen des Accounts
                MessageBox.Show("Ihr Account wurde gelöscht.", "Account gelöscht", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                mainWindow.ShowFrame(mainWindow.LogFrame); // Zur Login-Seite wechseln
            }
        }

        // Event-Handler für den Passwort wiederherstellen Button
        private void ResetPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            // Logik für die Passwortwiederherstellung
            MessageBox.Show("Anweisungen zur Passwortwiederherstellung wurden an Ihre E-Mail-Adresse gesendet.", "Passwort wiederherstellen", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
