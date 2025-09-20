using Tyuiu.KarpenkoAL.Sprint2.Task2.V6.Lib;

Console.Title = "Спринт #2 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и в *");
Console.WriteLine("* ычисляет находится ли точка с координатами X,Y в заштрихованной области *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
int y = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
if (res) 
{
    Console.WriteLine("Точка находится в заштрихованной области");
}
else 
{ 
    Console.WriteLine("Точка не находится в заштрихованной области");
}

Console.ReadKey();