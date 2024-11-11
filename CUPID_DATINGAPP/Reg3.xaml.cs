using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace CUPID_DATINGAPP
{
    /// <summary>
    /// Interaktionslogik für Reg3.xaml
    /// </summary>
    public partial class Reg3 : UserControl
    {

        public Reg3()
        {
            InitializeComponent();
        }


        // Klick-Event für den "Fertigstellen"-Button
        private void FinishRegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            // Abrufen des MainWindow, um auf die Frames zuzugreifen
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            // RegistrierFrame ausblenden
            mainWindow.RegistrierFrame.Visibility = Visibility.Collapsed;

            // Seitenmenü anzeigen
            mainWindow.MenuFrame.Visibility = Visibility.Visible;

            // Optional: Hier könnten weitere Einstellungen vorgenommen werden,
            // falls der Benutzer z.B. zur Startseite oder zu einem anderen Bereich
            // navigiert werden soll.
        }

        // Klick-Event für den "Zurück"-Button
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Zurück zum vorherigen Frame (Reg2)
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowFrame(mainWindow.UserDataFrame); // Zeige das UserDataFrame an (Reg2)
        }
    }
}
