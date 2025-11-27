using Tyuiu.AymurzinaJV.Sprint4.Task2.V8.Lib;
Random rnd  = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Аймурзина Ю. В. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнила: Аймурзина Юлия Владимировна | РППб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
Console.WriteLine("* случайными в диапазоне от 2 до 7 подсчитать                             *");
Console.WriteLine("* сумму нечетных элементов массива.                                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    numsArray[i] = rnd.Next(2, 7);
}

Console.WriteLine("Массив: ");
for (int i = 0; i <= len - 1; i++)
{
    Console.Write(numsArray[i] + "\t");
}

Console.WriteLine();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(numsArray);

Console.WriteLine(res);
Console.ReadKey();