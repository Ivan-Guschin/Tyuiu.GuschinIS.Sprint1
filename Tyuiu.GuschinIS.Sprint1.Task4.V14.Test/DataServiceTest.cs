using Tyuiu.GuschinIS.Sprint1.Task4.V14.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();                     // создаём объект

            double x = 1;                                           // первое число
            double y = 2;                                           // второе число

            // Считаем ожидаемый ответ вручную:
            // 7 + |1-2| = 7 + 1 = 8
            // √8 = 2.828... (корень из 8)
            // 3 * 1 * 2^2 = 3 * 1 * 4 = 12
            // 2.828... / 12 = 0.2357... -> округляем до 3 знаков = 0.236
            double wait = 0.236;                                    // ожидаемый результат

            var res = ds.Calculate(x, y);                           // вызываем метод
            Assert.AreEqual(wait, res);
        }
    }
}
