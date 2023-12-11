using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbOne
{
    public class Line
    {
        private double a;
        private double b;
        private double c;
        private double k;
        private double m;
        public Line(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.k = a / b;
            this.m = c / b;
        }
        public string PrintAll()
        {
            string temp = a + "x + " + b + "y + " + c + " = 0";
            return temp;
        }
        public double PrintX()
        {
            return -c / a;
        }
        public double PrintY()
        {
            return a;
        }
        public string PrintXY()
        {
            double x = -c / a;
            double y = a;
            Console.Write("---OX: {");
            Console.Write(x);
            Console.WriteLine(", 0}---");
            Console.Write("---OY: {0, ");
            Console.Write(y);
            Console.WriteLine("}---");
            string temp = "OX: {" + x + ", 0}  " + "OY: {0, " + y + "}";
            return temp;
        }
        public bool CheckPer(Line one, Line two)
        {
            if ((one.a * two.a + one.b * two.b) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckPar(Line one, Line two)
        {
            if ((one.a / two.a) == (one.b / two.b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double PrintCorner(Line one, Line two)
        {
            double m1 = one.a / one.b;
            double m2 = two.a / two.b;
            return Math.Atan(Math.Abs((m1 - m2) / (1 + m1 * m2))) * 180 / Math.PI;
        }
    }
    public class Interface
    {
        public char UserInput = '1';
        public void HelloWindow()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("---Это приложение позволяет работать с уравнениями прямых---");
            Console.WriteLine("------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
        }
        public void MainWindow()
        {
            Console.WriteLine("---------------------------Меню-----------------------------");
            Console.WriteLine("---1) Задать новую прямую-----------------------------------");
            Console.WriteLine("---2) Посмотреть все прямые (уравнения прямых)--------------");
            Console.WriteLine("---3) Действия с двумя прямыми------------------------------");
            Console.WriteLine("---4) Точки пересечения прямой с осями координат------------");
            Console.WriteLine("---e) Выход-------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("---: ");
        }
        public void NewLine(DataBase db)
        {
            double a;
            double b;
            double c;
            Console.Clear();
            Console.Write("---Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("---Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("---Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
            db.NewLine(a, b, c);
        }
        public void ShowAllLines(DataBase db)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------");
            for (int i = 0; i < db.Count; i++)
            {
                Console.Write("---");
                Console.Write(i + 1);
                Console.Write(") ");
                db.Lines[i].PrintAll();
            }

            Console.WriteLine("------------------------------------------------------------");
        }
        public void Check(DataBase db)
        {
            ShowAllLines(db);
            Console.WriteLine("---Выберете две линии:--------------------------------------");
            Console.Write("---Первая: ");
            int first = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("---Вторая: ");
            int second = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------");
            if (UserInput == '1')
            {
                if (db.Lines[first].CheckPer(db.Lines[first], db.Lines[second]))
                {
                    Console.WriteLine("---Прямые перпендикулярны-----------------------------------");
                }
                else
                {
                    Console.WriteLine("---Прямые не перпендикулярны--------------------------------");
                }
            }
            else if (UserInput == '2')
            {
                if (db.Lines[first].CheckPar(db.Lines[first], db.Lines[second]))
                {
                    Console.WriteLine("---Прямые параллельны---------------------------------------");
                }
                else
                {
                    Console.WriteLine("---Прямые не параллельны------------------------------------");
                }
            }
            else if (UserInput == '3')
            {
                Console.Write("---Угол между прямыми: ");
                Console.Write(db.Lines[first].PrintCorner(db.Lines[first], db.Lines[second]));
                Console.WriteLine(" градусов---");
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.ReadKey();
        }
        public void PerXY(DataBase db)
        {
            Console.Clear();
            ShowAllLines(db);
            Console.Write("---Выберете прямую: ");
            int a = Convert.ToInt32(Console.ReadLine()) - 1;
            db.Lines[a].PrintXY();
            Console.ReadKey();
        }
        public void MenuDoTwoLines(DataBase db)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("---1) Проверка на перпендикулярность двух прямых------------");
                Console.WriteLine("---2) Проверка на параллельность двух прямых----------------");
                Console.WriteLine("---3) Угол между двумя прямыми------------------------------");
                Console.WriteLine("---n) Назад-------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------");
                Console.Write("---: ");
                ConsoleKeyInfo name = Console.ReadKey();
                UserInput = name.KeyChar;
                Console.WriteLine();
                if (UserInput == '1')
                {
                    Check(db);
                }
                else if (UserInput == '2')
                {
                    Check(db);
                }
                else if (UserInput == '3')
                {
                    Check(db);
                }
                else if (UserInput == 'n')
                {
                    break;
                }
            }


        }
    }
    public class DataBase
    {
        public Line[] Lines = new Line[1];
        public int Count = 0;
        public int Index;
        public void NewLine(double a, double b, double c)
        {
            Count++;
            Array.Resize(ref Lines, Count);
            Lines[Count - 1] = new Line(a, b, c);
        }
    }
}
