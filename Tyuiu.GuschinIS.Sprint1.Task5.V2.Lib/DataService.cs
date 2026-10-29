using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GuschinIS.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2                      // подчиняемся интерфейсу
    {
        // Метод принимает Фаренгейты (temp), возвращает Цельсии (int — целое)
        // Именно такой вид требует интерфейс: int FahrenheitToCelsius(double temp)

        public int FahrenheitToСelsius(double temp)
        {
            // Формула: C = (F - 32) * 5 / 9
            double c = (temp - 32) * 5 / 9;

            // Convert.ToInt32(...) округляет до целого и превращает в int

            return Convert.ToInt32(c);
        }
    }
}
