using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AymurzinaJV.Sprint4.Task7.V15.Lib
{
    public class DataService : ISprint4Task7V15
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int count = 0;
            foreach(int i in  matrix)
            {
                if (i % 2 == 1) count++;
            }
            return count;
        }
    }
}
