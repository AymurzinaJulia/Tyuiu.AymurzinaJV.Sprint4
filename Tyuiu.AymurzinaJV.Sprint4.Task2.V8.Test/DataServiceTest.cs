using Tyuiu.AymurzinaJV.Sprint4.Task2.V8.Lib;
namespace Tyuiu.AymurzinaJV.Sprint4.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 5, 3, 6, 5, 4, 8, 6, 8, 3, 1 };
            int wait = 18;
            int res = ds.Calculate(array);
            Assert.AreEqual(res, wait);
        }
    }
}
