using Tyuiu.KarpenkoAL.Sprint2.Task5.V2.Lib;

Console.Title = "Спринт #2 | Выполнил: Карпенко А. Л. | ИБКСб-25-1";

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Карпенко Артём Леонидович | ИБКСб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуе *");
Console.WriteLine("* мое значение и возвращает результат. По данному месяцу, определите в ка *");
Console.WriteLine("* кую пору года попадает этот месяц (Зима, Лето, Весна, Осень).           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите номер месяца: ");
int seasonMouth = Convert.ToInt32(Console.ReadLine());

string res;

if ((seasonMouth < 1 ) || (seasonMouth > 12 )) 
{
    res = "Введено неверное значение!";
}
else 
{
    res = "Это пора года: " + ds.FindMonthSeason(seasonMouth);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(res);

Console.ReadKey();



