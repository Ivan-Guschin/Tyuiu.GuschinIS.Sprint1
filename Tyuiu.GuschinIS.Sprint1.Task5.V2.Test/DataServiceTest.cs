using Tyuiu.GuschinIS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 50;                                       // 50 по Фаренгейту
            DataService ds = new DataService();                     // создаём объект

            int res = ds.FahrenheitToСelsius(temp);                 // вызываем  метод
            int wait = 10;                                          // ожидаем 10

            Assert.AreEqual(wait, res);                             // сверяем
        }
    }
}
