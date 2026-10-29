using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GuschinIS.Sprint1.Task4.V14.Lib
{
    public class DataService : ISprint1Task4V19
    {
        // Метод принимает x и y, возвращает результат по формуле
        public double Calculate(double x, double y)
        {
            // Считаем верх дроби: корень из (7 + модуль(x-y))
            // Math.Abs(x-y)  -> модуль разности
            // Math.Sqrt(...) -> корень квадратный
            double top = Math.Sqrt(7 + Math.Abs(x - y));

            // Считаем низ дроби: 3 * x * y^2
            // Math.Pow(y, 2) -> y во второй степени (y^2)
            double bottom = 3 * x * Math.Pow(y, 2);

            // Делим верх на низ, округляем до 3 знаков
            // Math.Round(..., 3) -> округление до 3 цифр после запятой
            double res = Math.Round(top / bottom, 3);

            return res;                                             // возвращаем результат
        }
    }
}
