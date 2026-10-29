using Tyuiu.GuschinIS.Sprint1.Task2.V30.Lib;

namespace Tyuiu.GuschinIS.Sprint1.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;                       // 2 км
            var res = ds.ConvertKmToMetre(x);   // вызыввем метод, получаем метры
            Assert.AreEqual(2000, res);         // ожидаем увидеть 2000 метров
        }
    }
}
