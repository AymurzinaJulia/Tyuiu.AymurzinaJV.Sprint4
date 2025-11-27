using Tyuiu.AymurzinaJV.Sprint4.Task7.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Аймурзина Ю. В. | РППб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнила: Аймурзина Юлия Владимировна | РППб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр 10293847.                             *");
Console.WriteLine("* Преобразуйте ее в матрицу 4 на 2, подсчитайте количество нечетных чисел *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int rows = 4;
int columns = 2;
string str = "10293847";

int index = 0;

Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(str[index] + "\t");
        index++;
    }
    Console.WriteLine();

}


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(rows, columns, str);

Console.WriteLine(res);
Console.ReadKey();