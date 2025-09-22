using Tyuiu.KarpenkoAL.Sprint2.Task4.V20.Lib;

Console.Title = "Спринт #2 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использовани *");
Console.WriteLine("* ем тернарного оператора, где пользователь вводит значение переменных х, *");
Console.WriteLine("* у с клавиатуры, если х + 10>у * 2, то z = x * ((y + 1)/(x - 1))^x иначе *");
Console.WriteLine("* х^2 - (1/y)                                                             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());

double res = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Значение функции = " + res);

Console.ReadKey();
