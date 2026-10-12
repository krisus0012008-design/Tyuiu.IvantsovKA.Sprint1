using Tyuiu.IvantsovKA.Sprint1.Task4.V18.Lib;
namespace Tyuiu.IvantsovKA.Sprint1.Task4.V18.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.14;
            var res = ds.Calculate(x, y);
            Assert.Equal(wait, res, 3);
        }
    }
}