using Tyuiu.IvantsovKA.Sprint1.Task2.V16.Lib;
namespace Tyuiu.IvantsovKA.Sprint1.Task2.V16.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 2;
            var res = ds.CalculatePerimetrCircle(r);
            Assert.Equal(12.566, res);
        }
    }
}