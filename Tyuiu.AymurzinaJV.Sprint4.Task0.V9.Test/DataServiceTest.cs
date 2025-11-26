using Tyuiu.AymurzinaJV.Sprint4.Task0.V9.Lib;
namespace Tyuiu.AymurzinaJV.Sprint4.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int wait = 38;
            int res = ds.GetSumEvenArrEl(array);
            Assert.AreEqual(res, wait);
        }
    }
}
