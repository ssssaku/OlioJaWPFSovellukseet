using System.Diagnostics;
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

namespace Harjoitus15KT
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int HenkiloAuto = 0;
        private int KuormaAuto = 0;

        private void HenkiloAutoButton_Click(object sender, RoutedEventArgs e)
        {
            HenkiloAuto++;
            HenkiloAuto_Teksti.Text = HenkiloAuto.ToString();
        }

        private void KuormaAutoButton_Click(object sender, RoutedEventArgs e)
        {
            KuormaAuto++;
            KuormaAuto_Teksti.Text = KuormaAuto.ToString();
        }
    }
}