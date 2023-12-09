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

namespace ProgramGuiLine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// маму трахал и в рот тоже 
    /// опа попа
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Input(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            InputMenu.Visibility = Visibility.Visible;
        }
        private void Show(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
        }
        private void Do(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            InputMenu.Visibility = Visibility.Hidden;
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
