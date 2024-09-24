using System.Windows;
using System.Windows.Controls;

namespace Harjoitus21KT
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProductCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.IsChecked == true)
            {
                var productText = checkBox.Content.ToString();
                var textBlock = new TextBlock { Text = productText, Margin = new Thickness(0, 5, 0, 0) };
                cartItems.Items.Add(textBlock);
            }
        }

        private void ProductCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.IsChecked == false)
            {
                var productText = checkBox.Content.ToString();
                for (int i = cartItems.Items.Count - 1; i >= 0; i--)
                {
                    if (((TextBlock)cartItems.Items[i]).Text == productText)
                    {
                        cartItems.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            cartItems.Items.Clear();
            product1CheckBox.IsChecked = false;
            product2CheckBox.IsChecked = false;
            product3CheckBox.IsChecked = false;
        }
    }
}
