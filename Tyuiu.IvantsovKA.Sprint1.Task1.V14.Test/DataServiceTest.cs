using Tyuiu.IvantsovKA.Sprint1.Task1.V14.Lib;
namespace Tyuiu.IvantsovKA.Sprint1.Task1.V14.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3.0;
            double b = 1.0;
            double c = 2.0;
            var res = ds.Calculate(a, b, c);
            Assert.Equal(2.5, res);
        }
    }
}