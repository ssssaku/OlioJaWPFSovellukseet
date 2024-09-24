using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus16KT
{
    public partial class MainWindow : Window
    {
        private float lämpötila = 0;
        private bool keittiöValot;
        private bool olohuoneenValot;
        private bool oviLukossa;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OviLukossaNappi_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void OlohuoneenValotNappi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void KeittiövaloNappi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LämpöLaskuNappi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LämpöNostoNappi_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}