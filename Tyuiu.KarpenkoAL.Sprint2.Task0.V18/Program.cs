using Tyuiu.KarpenkoAL.Sprint2.Task0.V18.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последо *");
Console.WriteLine("* вательность операций не должна нарушаться) и арифметических выражений,  *");
Console.WriteLine("* которая вернет логическую последовательность(массив): (False, True,     *");
Console.WriteLine("*  True, True, True, False), при x = 5105, y = 475                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 5105;
int y = 475;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++) 
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();



