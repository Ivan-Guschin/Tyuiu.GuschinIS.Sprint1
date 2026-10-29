using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GuschinIS.Sprint1.Task2.V30.Lib
{
    public class DataService : ISprint1Task2V30
    {
        public double ConvertKmToMetre(double km)
        {
            return Math.Round(km * 1000, 3);
        }
    }
}
