using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GuschinIS.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public DataService() // пустой конструктор
        {
        }

        // Слон может перейти за один ход, если разница по X = разнице по Y
        public bool ElephCanMove(double x1, double y1, double x2, double y2)
        {
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }
    }
}
