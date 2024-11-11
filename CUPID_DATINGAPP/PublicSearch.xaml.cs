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
    /// Interaction logic for PublicSearch.xaml
    /// </summary>
    public partial class PublicSearch : UserControl
    {
        public PublicSearch()
        {
            InitializeComponent();
        }
        // Event-Handler für das TextChanged-Ereignis der SearchTextBox
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Beispiel-Code, um mit dem geänderten Text zu arbeiten
            string searchText = SearchTextBox.Text;

            // Füge hier die Logik hinzu, um die Suchergebnisse zu filtern
            // oder eine andere Aktion auszuführen
        }
    }
}
