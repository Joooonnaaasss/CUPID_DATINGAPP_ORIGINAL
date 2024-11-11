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
    /// Interaktionslogik für MainMenü.xaml
    /// </summary>
    public partial class MainMenü : UserControl
    {
        public MainMenü()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            // Erhalte eine Instanz des Hauptfensters
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            // Navigiere zum SearchFrame und zeige die UserSearch-Seite
            mainWindow.ShowFramesWithoutHidingMenu(mainWindow.HomeFrame); // Zeigt das HomeFrame an

        }


        private void User_Click(object sender, RoutedEventArgs e)
        {

            // Hole das Hauptfenster
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            // Zeige den UserDataFrame und setze UserData1 als Inhalt
            mainWindow.ShowFramesWithoutHidingMenu(mainWindow.UserDataFrame);
            mainWindow.UserDataFrame.Content = new UserData1();
        }


        private void Public_Click(object sender, RoutedEventArgs e)
        {
            // Erhalte eine Instanz des Hauptfensters
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            // Navigiere zum SearchFrame und zeige die UserSearch-Seite
            mainWindow.ShowFramesWithoutHidingMenu(mainWindow.SearchFramePublic); // Zeigt das SearchFrame an
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Erhalte eine Instanz des Hauptfensters
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            // Navigiere zum SearchFrame und zeige die UserSearch-Seite
            mainWindow.ShowFramesWithoutHidingMenu(mainWindow.SearchFrameAdd); // Zeigt das SearchFrame an
        }


        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            // Navigiere zum SearchFrame und zeige die UserSearch-Seite
            mainWindow.ShowFramesWithoutHidingMenu(mainWindow.SettingsFrame); // Zeigt das SearchFrame an
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

}
