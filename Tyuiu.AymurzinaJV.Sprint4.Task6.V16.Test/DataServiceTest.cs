using Tyuiu.AymurzinaJV.Sprint4.Task6.V16.Lib;

namespace Tyuiu.AymurzinaJV.Sprint4.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            string[] wait = { "Самолет", "Трамвай" };
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
