using System.Windows;
using System.Windows.Controls;

namespace CUPID_DATINGAPP
{
    public partial class Reg : UserControl
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void VornameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Logik für Textänderungen (optional)
        }

        private void NachnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Logik für Textänderungen (optional)
        }

        private void MailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Logik für Textänderungen (optional)
        }

        // Klick-Event für den "Weiter"-Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Wechsel zu Reg2
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.RegistrierFrame.Content = new Reg2(); // Setzt Reg2 als neue Seite
        }

        // Klick-Event für den "Zurück zum Login"-Button
        private void BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.ShowFrame(mainWindow.LogFrame); // Gehe zurück zum Login-Frame
        }
    }
}
