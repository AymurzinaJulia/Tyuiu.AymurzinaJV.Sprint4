using Tyuiu.AymurzinaJV.Sprint4.Task5.V16.Lib;
namespace Tyuiu.AymurzinaJV.Sprint4.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = {{ -3, 6, 1, 5, 3 },
                            { 2, 3, 5, -1, -1 },
                            { -1, -2, -5, 5, 1 },
                            { 3, 6, 5, 6, 2 },
                            { 3, -6, -4, 5, -5 }};

            int[,] wait =  {{ -3, 1, 1, 1, 1 },
                            { 1, 1, 1, -1, -1 },
                            { -1, -2, -5, 1, 1 },
                            { 1, 1, 1, 1, 1 },
                            { 1, -6, -4, 1, -5 }};
            int[,] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
