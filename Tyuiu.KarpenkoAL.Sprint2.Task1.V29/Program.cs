using Tyuiu.KarpenkoAL.Sprint2.Task1.V29.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #29                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последо *");
Console.WriteLine("* вательность можно чередовать, но использовать один раз в выражении) и л *");
Console.WriteLine("* огических операций (|, &, ||, &&, !, ^, последовательность операций не  *");
Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернет ло *");
Console.WriteLine("* гическую последовательность(массив): (True, True, True, False, True, Tr *");
Console.WriteLine("* ue), при a = 657, b = 654, c = 657, d = 657                             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int a = 657;
int b = 654;
int c = 657;
int d = 657;

bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();
