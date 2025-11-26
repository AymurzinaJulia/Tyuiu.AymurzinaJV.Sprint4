using Tyuiu.AymurzinaJV.Sprint4.Task1.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Аймурзина Ю. В. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнила: Аймурзина Юлия Владимировна | РППб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив из 13 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать                *");
Console.WriteLine("* сумму нечетных элементов массива.                                       *");
Console.WriteLine("* С клавиатуры: 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    Console.Write("Введите значение " + i + " элемента массива: ");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
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