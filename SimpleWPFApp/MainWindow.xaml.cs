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

namespace SimpleWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultTextBlock.Text = "...";
        }

        private void HelloButton_Click(object sender, RoutedEventArgs e)
        {
            if (!resultTextBlock.Text.Equals("Hello, World"))
            {
                resultTextBlock.Text = "Hello, world";
            }
            else
            {
                resultTextBlock.Text = "Hai, this is WPF";
            }

            MessageBox.Show("hello, world. Ini WPF saya.", "Ini program WPF pertama", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            string caption = "Halo gesss";
            MessageBoxButton btnOK = MessageBoxButton.OK;
            MessageBoxImage imgInfo = MessageBoxImage.Information;

            string message = $"hello, world {Environment.NewLine}Hello gess";
            MessageBox.Show(message, caption, btnOK, imgInfo);
        }
    }
}
