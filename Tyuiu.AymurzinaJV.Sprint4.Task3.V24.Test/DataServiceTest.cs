using Tyuiu.AymurzinaJV.Sprint4.Task3.V24.Lib;
namespace Tyuiu.AymurzinaJV.Sprint4.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = {{ 3, 6, 1, 7, 3 },
                            { 2, 3, 7, 1, 1 },
                            { 1, 2, 5, 5, 1 },
                            { 7, 6, 7, 6, 2 },
                            { 7, 6, 4, 5, 8 }};
            int wait = 2;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
