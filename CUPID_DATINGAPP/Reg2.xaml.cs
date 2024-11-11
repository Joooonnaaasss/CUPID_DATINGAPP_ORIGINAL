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
    /// Interaktionslogik für Reg2.xaml
    /// </summary>
    public partial class Reg2 : UserControl
    {
        public Reg2()
        {
            InitializeComponent();
        }

        // Event-Handler für den "Weiter"-Button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Wechsel zu Reg1
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.RegistrierFrame.Content = new Reg3(); // Setzt Reg1 als neue Seite
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Wechsel zu Reg3
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.RegistrierFrame.Content = new Reg(); // Setzt Reg3 als neue Seite
        }
        // Weitere Event-Handler für andere Buttons können hier hinzugefügt werden.
    }
}