using Tyuiu.IvantsovKA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.IvantsovKA.Sprint1.Task5.V1.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            double x1 = 1;
            double y1 = 2;
            double x2 = 4;
            double y2 = 6;
            DataService ds = new DataService();
            int res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);

            int wait = 5;
            Assert.Equal(wait, result);

        }
    }
}