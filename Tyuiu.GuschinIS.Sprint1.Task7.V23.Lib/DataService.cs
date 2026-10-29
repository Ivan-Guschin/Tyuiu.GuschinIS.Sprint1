using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GuschinIS.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            // Формула:
            // z = x − 10^sin(x) + (20x²)/(3x³) + cos(x² − y)
            //
            // Разбор по частям:
            // Math.Sin(x)           sin(x)
            // Math.Pow(10, ...)     10 в степени sin(x)
            // Math.Pow(x, 2)        x в квадрате
            // Math.Pow(x, 3)        x в кубе
            // Math.Cos(x*x - y)     косинус от (x² - y)
            double z = x
                     - Math.Pow(10, Math.Sin(x))                             // 10 в степени sin(x)
                     + (20 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3))           // дробь
                     + Math.Cos(x * x - y);                                  // косинус

            // Округляем до 3 знаков и возвращаем
            return Math.Round(z, 3);
        }
    }
}