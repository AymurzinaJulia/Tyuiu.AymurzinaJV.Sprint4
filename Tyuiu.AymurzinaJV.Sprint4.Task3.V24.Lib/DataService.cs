using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AymurzinaJV.Sprint4.Task3.V24.Lib
{
    public class DataService : ISprint4Task3V24
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int min = 10000;
            int j = 1;
            for (int i = 0; i < rows; i++)
            {
                int num = array[i, j];
                if (num < min) 
                    {
                        min = num;
                    }
            }
            return min;

        }
    }
}
