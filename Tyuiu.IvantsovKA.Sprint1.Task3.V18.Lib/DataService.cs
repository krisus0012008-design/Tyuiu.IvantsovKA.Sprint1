using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.IvantsovKA.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            double squaresByA = Math.Floor(a / c);
            double squaresByB = Math.Floor(b / c);
            return Math.Round(squaresByA * squaresByB, 3);

        }
    }
}