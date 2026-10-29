using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GuschinIS.Sprint1.Task6.V2.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();                     // создаём объект

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст:");                       // просим строку
            string str = Console.ReadLine();                        // читаем строку

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызываем метод и печатаем true или false
            Console.WriteLine("Есть ли в тексте слово Hello? " + ds.CheckHello(str));

            Console.ReadLine();                                     // ждём Enter, чтобы окно не закрылось
        }
    }
}
