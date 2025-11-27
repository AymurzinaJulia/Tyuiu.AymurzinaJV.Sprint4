using Tyuiu.AymurzinaJV.Sprint4.Task5.V16.Lib;

Random rnd = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Аймурзина Ю. В. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнила: Аймурзина Юлия Владимировна | РППб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от -6 до 3                            *");
Console.WriteLine("* Заменить положительные элементы на 1.                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int rows;
Console.WriteLine("Введите количество строк в массиве: ");
rows = Convert.ToInt32(Console.ReadLine());

int columns;
Console.WriteLine("Введите количество столбцов в массиве: ");
columns = Convert.ToInt32(Console.ReadLine());

int[,] numsArray = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        numsArray[i, j] = rnd.Next(-6, 3);
    }

}

Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(numsArray[i, j] + "\t");
    }

}

Console.WriteLine();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int[,] res = ds.Calculate(numsArray);

foreach (int i in res)
    Console.Write(i + "\t");

Console.ReadKey();