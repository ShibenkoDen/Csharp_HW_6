﻿/*
Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
у=k1*х+b1, y=k2*x+b2, значения b1,k1,b2,k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5;-0,5)
*/

double getUserData(string message)
{
    Console.WriteLine(message);
    double userData = double.Parse(Console.ReadLine()!);
    return userData;
}

double b1 = getUserData ("Введите b1"); 
double k1 = getUserData ("Введите k1");
double b2 = getUserData ("Введите b2");
double k2 = getUserData ("Введите k2");

if (k1 == k2)
{
    Console.WriteLine ("Две прямые не пересекаются");
}
else
{
double x = (b2-b1)/(k1-k2);
double y = k1*((b2-b1)/(k1-k2))+b1;

Console.WriteLine ($"Две прямые пересекаются в точке [{x}, {y}]");
}


