using Tyuiu.GuschinIS.Sprint1.Task3.V19.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();   // создаём объект, чтобы вызвать метод

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1, y1, x2, y2;   // 4 координаты (x1,y1) и (x2,y2)

            Console.WriteLine("Введите координату x1 (от 1 до 8):");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату y1 (от 1 до 8):");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату x2 (от 1 до 8):");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату y2 (от 1 до 8):");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Слон с (" + x1 + "," + y1 + ") на (" + x2 + "," + y2 + ")");
            Console.WriteLine("Ответ: " + ds.ElephCanMove(x1, y1, x2, y2));   // вызываем метод

            Console.ReadLine();   // ждём Enter, чтобы окно не закрылось
        }
    }
}

