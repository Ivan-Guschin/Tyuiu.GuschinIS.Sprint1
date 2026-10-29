using Tyuiu.GuschinIS.Sprint1.Task4.V14.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();                     // создаём объект

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;                                            // две дробных переменных

            Console.WriteLine("Введите значение x:");               // просим x
            x = Convert.ToDouble(Console.ReadLine());               // читаем и превращаем в число

            Console.WriteLine("Введите значение y:");               // просим y
            y = Convert.ToDouble(Console.ReadLine());               // читаем и превращаем в число

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Печатаем формулу и ответ, который вернул метод Calculate
            Console.WriteLine("√(7 + |x - y|) / (3 * x * y^2) = " + ds.Calculate(x, y));

            Console.ReadLine();                                     // ждём Enter, чтобы окно не закрылось
        }
    }
}

