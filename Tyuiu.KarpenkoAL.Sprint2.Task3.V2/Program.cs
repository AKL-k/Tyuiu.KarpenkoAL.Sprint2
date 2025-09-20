using Tyuiu.KarpenkoAL.Sprint2.Task3.V2.Lib;

Console.Title = "Спринт #2 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
Console.WriteLine("* использованием вложенных операторов if-else, где пользователь вводит    *");
Console.WriteLine("* X с клавиатуры. Округлить полученное значение до трех знаков после ,    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());
double res = ds.Calculate(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции = " + res);

Console.ReadKey();