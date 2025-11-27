using Tyuiu.AymurzinaJV.Sprint4.Task4.V8.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Аймурзина Ю. В. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнила: Аймурзина Юлия Владимировна | РППб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 6.                          *");
Console.WriteLine("* Заменить четные элементы массива на 1.                                  *");
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
        Console.Write($"Введите {i},{j} элемент массива: ");
        numsArray[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    
}

Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(numsArray[i,j] + "\t");
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