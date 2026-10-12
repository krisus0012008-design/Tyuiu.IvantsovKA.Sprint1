using Tyuiu.IvantsovKA.Sprint1.Task6.V9.Lib;
namespace Tyuiu.IvantsovKA.Sprint1.Task6.V9.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void ValidString()
        {
            string strTest = "привет hello"
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(strTest);
            string wait = "тприве ohell";
            Assert.Equal(wait, res);
        }
    }
}