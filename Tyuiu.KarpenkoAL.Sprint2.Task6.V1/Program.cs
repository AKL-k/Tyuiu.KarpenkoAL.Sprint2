using Tyuiu.KarpenkoAL.Sprint2.Task6.V1.Lib;

Console.Title = "Спринт #2 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Получение результата из switch                                    *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует сокращенную форму записи операто *");
Console.WriteLine("* ра switch вычисляет требуемое значение и возвращает результат. По данно *");
Console.WriteLine("* му номеру месяца, определите количество дней в этом месяце.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите номер месяца: ");
int DaysCountMonth = Convert.ToInt32(Console.ReadLine());

string res;

if ((DaysCountMonth < 1) || (DaysCountMonth > 12))
{
    res = "Введено неверное значение!";
}
else
{
    res = "В этом месяце следующее количество дней: " + ds.FindMonthDaysCount(DaysCountMonth);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(res);

Console.ReadKey();
