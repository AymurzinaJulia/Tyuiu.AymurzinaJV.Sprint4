using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AymurzinaJV.Sprint4.Task2.V8.Lib
{
    public class DataService : ISprint4Task2V8
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (char num in array)
            {
                if (num % 2 == 1) sum += num;
            }
            return sum;
        }
    }
}
