using Tyuiu.GuschinIS.Sprint1.Task3.V19.Lib;

namespace Tyuiu.SpirinIS.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x1 = 1;                 // первая клетка
            double y1 = 1;
            double x2 = 3;                 // вторая клетка (по диагонали)
            double y2 = 3;

            var res = ds.ElephCanMove(x1, y1, x2, y2);   // вызываем метод
            Assert.AreEqual(true, res);                  // ожидаем true
        }
    }
}

