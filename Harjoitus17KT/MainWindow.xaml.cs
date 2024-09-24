using System.Windows;
using System.Windows.Media;

namespace Harjoitus17KT
{
    public partial class MainWindow : Window
    {
        private float lampotila = 0;
        private bool keittiöValot = false;
        private bool olohuoneenValot = false;
        private bool oviLukossa = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OviLukossa_Click(object sender, RoutedEventArgs e)
        {
            if (oviLukossa)
            {
                LukkoTeksti.Text = "Ovi on nyt lukossa.";
                oviLukossa = false;
                LukkoTeksti.Foreground = Brushes.Red;
            }
            else
            {
                LukkoTeksti.Text = "Ovi on nyt auki.";
                oviLukossa = true;
                LukkoTeksti.Foreground = Brushes.Green;
            }
        }

        private void OlohuoneenValot_Click(object sender, RoutedEventArgs e)
        {
            if (olohuoneenValot)
            {
                OlohuoneenValoTeksti.Text = "Olohuoneen valo on nyt pois päältä";
                olohuoneenValot = false;
                OlohuoneenValoTeksti.Foreground = Brushes.Red;
            }
            else
            {
                OlohuoneenValoTeksti.Text = "Olohuoneen valo on nyt päällä";
                olohuoneenValot = true;
                OlohuoneenValoTeksti.Foreground = Brushes.Green;
            }
        }

        private void KeittiöValot_Click(object sender, RoutedEventArgs e)
        {
            if (keittiöValot)
            {
                KeittiöValoTeksti.Text = "Keittiönn valo on nyt pois päältä";
                keittiöValot = false;
                KeittiöValoTeksti.Foreground = Brushes.Red;
            }
            else
            {
                KeittiöValoTeksti.Text = "Keittiön valo on nyt päällä";
                keittiöValot = true;
                KeittiöValoTeksti.Foreground = Brushes.Green;
            }
        }

        private void LampotilaNosta_Click(object sender, RoutedEventArgs e)
        {
            lampotila++;
            LampotilaTeksti.Text = "Lämpötila on nyt " + lampotila + "°C"; ;
        }

        private void LampotilaLaske_Click(object sender, RoutedEventArgs e)
        {
            lampotila--;
            LampotilaTeksti.Text = "Lämpötila on nyt " + lampotila + "°C";
        }
    }
}