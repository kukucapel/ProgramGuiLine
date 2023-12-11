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
using LbOne;

namespace ProgramGuiLine
{
    
    public partial class MainWindow : Window
    {
        private DataBase db = new DataBase();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Input(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            InputMenu.Visibility = Visibility.Visible;
        }
        private void InputText(object sender, RoutedEventArgs e)
        {
            if ((Convert.ToDouble(a.Text) == 0) && (Convert.ToDouble(b.Text) == 0) && (Convert.ToDouble(c.Text) == 0))
            {
                MessageBox.Show("Введите хотя бы одно значение отличное от 0");
            }
            else
            {
                try
                {
                    if (db.Checker(Convert.ToDouble(a.Text), Convert.ToDouble(b.Text), Convert.ToDouble(c.Text), db))
                    {
                        db.NewLine(Convert.ToDouble(a.Text), Convert.ToDouble(b.Text), Convert.ToDouble(c.Text));
                        //MessageBox.Show("Значения введены");
                        a.Text = String.Empty;
                        b.Text = String.Empty;
                        c.Text = String.Empty;
                        ArrayLines.Items.Add(db.Lines[db.Count - 1].PrintAll());
                        ArrayDo.Items.Add(db.Lines[db.Count - 1].PrintAll());
                        ArrayYX.Items.Add(db.Lines[db.Count - 1].PrintAll());
                    }
                    else
                    {
                        MessageBox.Show("Такая линия уже существует");
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
            
        }
        private void Show(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            ShowAll.Visibility = Visibility.Visible;
        }
        private void Do(object sender, RoutedEventArgs e)
        {
            if (db.Count < 2)
            {
                MessageBox.Show("У вас меньше двух линий");
            }
            else
            {
                DoMain.Visibility = Visibility.Visible;
                MainMenu.Visibility = Visibility.Hidden;
                MenuDo.Visibility = Visibility.Visible;
            }
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
        private void CornerMenu(object sender, RoutedEventArgs e)
        {
            MenuDo.Visibility = Visibility.Hidden;
            ShowAllDo.Visibility = Visibility.Visible;
            CornerInput.Visibility = Visibility.Visible;
        }
        private void PerOne(object sender, RoutedEventArgs e)
        {
            db.Index = ArrayDo.SelectedIndex;
            perbut.Visibility = Visibility.Visible;
        }
        private void PerTwo(object sender, RoutedEventArgs e)
        {
            if (ArrayDo.SelectedIndex == db.Index)
            {
                MessageBox.Show("Выберете разные линии");
            }
            else
            {
                if (db.Lines[db.Index].CheckPer(db.Lines[db.Index], db.Lines[ArrayDo.SelectedIndex]))
                {
                    MessageBox.Show("Прямые перпендикулярны");
                }
                else
                {
                    MessageBox.Show("Прямые не перпендикулярны");
                }
            }
            perbut.Visibility = Visibility.Hidden;
            ArrayDo.SelectedIndex = -1;
        }
        private void ParOne(object sender, RoutedEventArgs e)
        {
            db.Index = ArrayDo.SelectedIndex;
            parbut.Visibility = Visibility.Visible;
        }
        private void ParTwo(object sender, RoutedEventArgs e)
        {
            if (ArrayDo.SelectedIndex == db.Index)
            {
                MessageBox.Show("Выберете разные линии");
            }
            else
            {
                if (db.Lines[db.Index].CheckPar(db.Lines[db.Index], db.Lines[ArrayDo.SelectedIndex]))
                {
                    MessageBox.Show("Прямые параллельны");
                }
                else
                {
                    MessageBox.Show("Прямые не параллельны");
                }
            }
            parbut.Visibility = Visibility.Hidden;
            ArrayDo.SelectedIndex = -1;
        }
        private void CornerOne(object sender, RoutedEventArgs e)
        {
            db.Index = ArrayDo.SelectedIndex;
            cornerbut.Visibility = Visibility.Visible;
        }
        private void CornerTwo(object sender, RoutedEventArgs e)
        {
            if (ArrayDo.SelectedIndex == db.Index)
            {
                MessageBox.Show("Выберете разные линии");
            }
            else
            {
                MessageBox.Show(Convert.ToString(db.Lines[db.Index].PrintCorner(db.Lines[db.Index], db.Lines[ArrayDo.SelectedIndex])));
            }
            cornerbut.Visibility = Visibility.Hidden;
            ArrayDo.SelectedIndex = -1;
        }
        private void Corner(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Угол");
        }
        private void BackDo(object sender, RoutedEventArgs e)
        {
            MenuDo.Visibility = Visibility.Visible;
            ParInput.Visibility = Visibility.Hidden;
            PerInput.Visibility = Visibility.Hidden;
            ShowAllDo.Visibility = Visibility.Hidden;
            CornerInput.Visibility = Visibility.Hidden;
            perbut.Visibility = Visibility.Hidden;
            parbut.Visibility = Visibility.Hidden;
            cornerbut.Visibility = Visibility.Hidden;
        }
        private void OxOyInput(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            OxOyMenu.Visibility = Visibility.Visible;
        }
        private void OxOy(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(db.Lines[ArrayYX.SelectedIndex].PrintXY());
            ArrayYX.SelectedIndex = -1;
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Visible;
            InputMenu.Visibility = Visibility.Hidden;
            ShowAll.Visibility = Visibility.Hidden;
            DoMain.Visibility = Visibility.Hidden;
            ShowAllDo.Visibility = Visibility.Hidden;
            OxOyMenu.Visibility = Visibility.Hidden;
        }
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
