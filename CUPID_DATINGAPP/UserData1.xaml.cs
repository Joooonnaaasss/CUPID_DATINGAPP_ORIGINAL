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
    public partial class UserData1 : UserControl
    {
        public UserData1()
        {
            InitializeComponent();
            this.DataContext = new UserDataModel
            {
                Vorname = "Max",
                Nachname = "Mustermann",
                Email = "max.mustermann@example.com",
                Geburtsdatum = "01.01.1990",
                Geschlecht = "Männlich"
            };
        }

        private void SaveUserDataButton_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle the save button click goes here
        }

        private void CancelUserDataButton_Click(object sender, RoutedEventArgs e)
        {
            // Code to handle the cancel button click goes here
        }

        public class UserDataModel
        {
            public string Vorname { get; set; }
            public string Nachname { get; set; }
            public string Email { get; set; }
            public string Geburtsdatum { get; set; }
            public string Geschlecht { get; set; }
        }

    }
}