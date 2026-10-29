using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GuschinIS.Sprint1.Task7.V23.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();                     // создаём объект

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Формула для наглядности
            Console.WriteLine("Формула:");
            Console.WriteLine("z = x - 10^sin(x) + (20x^2)/(3x^3) + cos(x^2 - y)");
            Console.WriteLine();

            double x, y;                                            // две переменные

            Console.WriteLine("Введите значение X:");               // просим x
            x = Convert.ToDouble(Console.ReadLine());               // читаем число

            Console.WriteLine("Введите значение Y:");               // просим y
            y = Convert.ToDouble(Console.ReadLine());               // читаем число

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызываем метод и печатаем результат
            Console.WriteLine("z = " + ds.Calculate(x, y));

            Console.ReadLine();                                     // ждём Enter
        }
    }
}
