using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.IvantsovKA.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
        public double Calculate(double x, double y)
        {
            double res1 = Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            double res2 = Math.Pow(x, 2) - Math.Sin(Math.Pow(y, 2)) + 12;
            double res = res1 / res2;
            return Math.Round(res, 3);
        }
    }
}
