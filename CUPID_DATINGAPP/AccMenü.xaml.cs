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
    public partial class AccMenü : UserControl
    {
        public AccMenü()
        {
            InitializeComponent();
        }

        private void ShowEditUserData(object sender, RoutedEventArgs e)
        {
            // Greife auf das Hauptfenster zu und setze den Inhalt auf UserData1
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.UserDataFrame.Visibility = Visibility.Visible;
            mainWindow.UserDataFrame.Content = new UserData1();
        }

        private void ShowUserData2(object sender, RoutedEventArgs e)
        {
            // Greife auf das Hauptfenster zu und setze den Inhalt auf UserData2
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.UserDataFrame.Visibility = Visibility.Visible;
            mainWindow.UserDataFrame.Content = new UserData2();
        }

        private void ShowUserData3(object sender, RoutedEventArgs e)
        {
            // Greife auf das Hauptfenster zu und setze den Inhalt auf UserData3
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.UserDataFrame.Visibility = Visibility.Visible;
            mainWindow.UserDataFrame.Content = new UserData3();
        }
    }
}