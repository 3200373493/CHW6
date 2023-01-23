﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Используйте ( , ) для ввода десятичных дробей");

Console.Write("ВВЕДИТЕ b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("ВВЕДИТЕ k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("ВВЕДИТЕ b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("ВВЕДИТЕ k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());



if ((k1 == k2) && (b1 == b2)) { Console.Write("ПРЯМЫЕ СОВПАДАЮТ"); }
else if (k1 == k2) { Console.Write("ПРЯМЫЕ ПАРАЛЛЕЛЬНЫ"); }
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / ((k1 - k2) + b1);
    Console.WriteLine($"КООРДИНАТЫ ТОЧКИ ПЕРЕСЕЧЕНИЯ: ({Math.Round(x, 2)};{Math.Round(y, 2)})");
}