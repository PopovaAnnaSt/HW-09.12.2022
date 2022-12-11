﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine());

GetPointIntersection(b1, k1, b2, k2);

void GetPointIntersection(int b1, int k1, int b2, int k2)
{
    if(k1 == k2)
    {
        if(b1 == b2)
        {
            Console.WriteLine("Прямые совпадают, бесконечно много решений");
        }
        else
        {
            Console.WriteLine("Прямые не пересекаются, они параллельны");
        }
    }
    else
    {
        Double x = (double)(b2 - b1)/(k1 - k2);
        Double y = (double) (k2 * x + b2);
        Console.WriteLine($"Координаты точки пересечения прямых: ({x}, {y})");
    }
}
