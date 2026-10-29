using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GuschinIS.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2                                      // Проверяем: есть ли в строке слово "Hello"
                                                                                    // true — есть, false — нет
    {
        public bool CheckHello(string value)
        {
            // Contains — проверяет, есть ли подстрока "Hello" внутри строки
            return value.Contains("Hello");
        }
    }
}
