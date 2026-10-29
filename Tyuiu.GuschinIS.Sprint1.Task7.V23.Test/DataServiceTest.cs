using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GuschinIS.Sprint1.Task7.V23.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();                     // создаём объект

            double x = 2;                                           // первое число
            double y = 3;                                           // второе число
            double wait = -2.243;                                   // ожидаемый ответ

            var res = ds.Calculate(x, y);                           // вызываем метод
            Assert.AreEqual(wait, res);                             // сверяем
        }
    }
}

