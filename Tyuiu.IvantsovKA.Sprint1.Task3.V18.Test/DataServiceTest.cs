using Tyuiu.IvantsovKA.Sprint1.Task3.V18.Lib;
namespace Tyuiu.IvantsovKA.Sprint1.Task3.V18.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 9;
            double b = 6;
            double c = 4;
            double wait = 2;
            var res = ds.HowManySquares(a, b, c);
            Assert.Equal(wait, res, 3);
        }
    }
}