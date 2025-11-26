using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AymurzinaJV.Sprint4.Task0.V9.Lib
{
    public class DataService : ISprint4Task0V9
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int i;
            int sum = 0;
            for (i = 0; i <= 9; i += 2)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
