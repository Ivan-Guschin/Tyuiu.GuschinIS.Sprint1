using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Важно! Следует к библиотеке классов подключить файл tyuiu.cources.programming.interfaces.dll
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GuschinIS.Sprint1.Task0.V12.Lib
{
    public class DataService : ISprint1Task0V12
    {
        public double Calculate()
        {
            return (5 * 2 - 2) / 4 * 3;
        }
    }
}
