using Tyuiu.IvantsovKA.Sprint1.Task7.V13.Lib;
namespace Tyuiu.IvantsovKA.Sprint1.Task7.V13.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 0.685;
            var res = ds.Calculate(x, y);
            Assert.Equal(wait, res);
        }
    }
}