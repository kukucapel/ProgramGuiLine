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
            ShowAll.Visibility = Visibility.Visible;
        }
        private void Do(object sender, RoutedEventArgs e)
        {
            DoMain.Visibility = Visibility.Visible;
            MainMenu.Visibility = Visibility.Hidden;
            MenuDo.Visibility = Visibility.Visible;
        }
        
        private void ParMenu(object sender, RoutedEventArgs e)
        {
            MenuDo.Visibility = Visibility.Hidden;
            ShowAllDo.Visibility = Visibility.Visible;
            ParInput.Visibility = Visibility.Visible;
        }
        private void PerMenu(object sender, RoutedEventArgs e)
        {
            MenuDo.Visibility = Visibility.Hidden;
            ShowAllDo.Visibility = Visibility.Visible;
            PerInput.Visibility = Visibility.Visible;  
        }
        private void Per(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Per");
        }
        private void Par(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Par");
        }
        private void BackDo(object sender, RoutedEventArgs e)
        {
            MenuDo.Visibility = Visibility.Visible;
            ParInput.Visibility = Visibility.Hidden;
            PerInput.Visibility = Visibility.Hidden;
            ShowAllDo.Visibility = Visibility.Hidden;
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            InputMenu.Visibility = Visibility.Hidden;
            ShowAll.Visibility = Visibility.Hidden;
            DoMain.Visibility = Visibility.Hidden;
            ShowAllDo.Visibility = Visibility.Hidden;
        }
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
