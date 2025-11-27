using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AymurzinaJV.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            return array.Where(x => x.Length == 7).ToArray();
        }
    }
}
