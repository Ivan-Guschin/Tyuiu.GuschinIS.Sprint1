using Tyuiu.GuschinIS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();                     // создаём объект

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите температуру в Фаренгейтах:");
            double temp = Convert.ToDouble(Console.ReadLine());     // читаем число

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Метод уже возвращает int, ничего дополнительно превращать не надо
            int res = ds.FahrenheitToСelsius(temp);

            Console.WriteLine("Температура в Цельсиях: " + res);

            Console.ReadLine();
        }
    }
}
