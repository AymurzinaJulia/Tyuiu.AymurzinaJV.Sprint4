using Tyuiu.AymurzinaJV.Sprint4.Task7.V15.Lib;
namespace Tyuiu.AymurzinaJV.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "10293847";
            int rows = 4;
            int cols = 2;

            int wait = 4;
            int res = ds.Calculate(rows, cols, str);
            Assert.AreEqual(wait, res);
        }
    }
}
