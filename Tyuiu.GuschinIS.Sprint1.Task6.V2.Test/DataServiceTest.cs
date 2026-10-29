using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GuschinIS.Sprint1.Task6.V2.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет, Hello мир!";                  // строка, где ЕСТЬ Hello
            DataService ds = new DataService();                     // создаём объект

            bool res = ds.CheckHello(strTest);                      // вызываем метод
            bool wait = true;                                       // ожидаем true

            Assert.AreEqual(wait, res);                             // сверяем
        }
    }
}
