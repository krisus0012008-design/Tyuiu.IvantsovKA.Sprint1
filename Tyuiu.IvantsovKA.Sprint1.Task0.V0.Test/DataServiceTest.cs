using Tyuiu.IvantsovKA.Sprint1.Task0.V0.Lib;
namespace Tyuiu.IvantsovKA.Sprint1.Task0.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.Equal(2, res);
        }
    }
}