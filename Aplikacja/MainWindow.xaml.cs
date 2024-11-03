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

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Tekst_powitalny.Visibility = Visibility.Collapsed;
            Main.Content = new Page1();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Tekst_powitalny.Visibility = Visibility.Collapsed;
            Main.Content = new Page2();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Tekst_powitalny.Visibility = Visibility.Collapsed;
            Main.Content = new Page3();
        }
    }
}
