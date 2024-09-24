using System;
using System.Windows;

namespace Harjoitus18KT
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool TryParseNumbers(out double num1, out double num2)
        {
            bool isNum1Valid = double.TryParse(txtNumber1.Text, out num1);
            bool isNum2Valid = double.TryParse(txtNumber2.Text, out num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                MessageBox.Show("Anna kelvolliset numerot.", "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void BtnSumma_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseNumbers(out double num1, out double num2))
            {
                double result = Laskuri.summa(num1, num2);
                txtResult.Text = "Summa: " + result.ToString();
            }
        }

        private void BtnErotus_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseNumbers(out double num1, out double num2))
            {
                double result = Laskuri.erotus(num1, num2);
                txtResult.Text = "Erotus: " + result.ToString();
            }
        }

        private void BtnKertolasku_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseNumbers(out double num1, out double num2))
            {
                double result = Laskuri.kerto(num1, num2);
                txtResult.Text = "Kertolasku: " + result.ToString();
            }
        }

        private void BtnJakolasku_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseNumbers(out double num1, out double num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Nollalla ei voi jakaa.", "Virhe", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    double result = Laskuri.jako(num1, num2);
                    txtResult.Text = "Jakolasku: " + result.ToString();
                }
            }
        }
    }
}
