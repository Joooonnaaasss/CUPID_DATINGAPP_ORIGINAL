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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace CUPID_DATINGAPP
{
    public partial class MainWindow : Window
    {
        public bool IsMenuCollapsed { get; private set; } = true; // Menüstatus öffentlich lesbar machen

        public MainWindow()
        {
            InitializeComponent();
            // Direkt beim Start den LogFrame anzeigen
            ShowFrame(LogFrame);
        }

        // Methode, um das Menü sichtbar zu machen
        public void ShowMenu()
        {
            MenuFrame.Visibility = Visibility.Visible;
        }

        // Hilfsmethode zum Umschalten der Sichtbarkeit von Frames
        public void ShowFrame(Frame frameToShow)
        {
            // Alle Frames ausblenden
            HomeFrame.Visibility = Visibility.Collapsed;
            LogFrame.Visibility = Visibility.Collapsed;
            UserDataFrame.Visibility = Visibility.Collapsed;
            SettingsFrame.Visibility = Visibility.Collapsed;
            SearchFrameAdd.Visibility = Visibility.Collapsed;
            SearchFramePublic.Visibility = Visibility.Collapsed;
            MenuFrame.Visibility = Visibility.Collapsed;

            // Den gewünschten Frame anzeigen
            frameToShow.Visibility = Visibility.Visible;

            // Speziell für RegistrierFrame: Sicherstellen, dass der Inhalt sichtbar ist
            if (frameToShow == RegistrierFrame)
            {
                Reg1.Visibility = Visibility.Visible; // Nur den ersten Registrierungsschritt anzeigen
                Reg2.Visibility = Visibility.Collapsed;
                Reg3.Visibility = Visibility.Collapsed;
            }
        }



        public void ShowFramesWithoutHidingMenu(Frame frameToShow)
        {
            // Setze nur die anderen Frames auf Collapsed, nicht aber den MenuFrame
            LogFrame.Visibility = Visibility.Collapsed;
            RegistrierFrame.Visibility = Visibility.Collapsed;
            UserDataFrame.Visibility = Visibility.Collapsed;
            SettingsFrame.Visibility = Visibility.Collapsed;
            SearchFrameAdd.Visibility = Visibility.Collapsed;
            SearchFramePublic.Visibility = Visibility.Collapsed;
            HomeFrame.Visibility = Visibility.Collapsed;

            // MenuFrame bleibt sichtbar
            MenuFrame.Visibility = Visibility.Visible;

            // Den gewünschten zweiten Frame sichtbar machen
            frameToShow.Visibility = Visibility.Visible;
        }
    }
}