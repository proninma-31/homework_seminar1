﻿// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число 1");
string a = Console.ReadLine();
Console.WriteLine("Введите число 2");
string b = Console.ReadLine();
int A = Convert.ToInt32(a);
int B = Convert.ToInt32(b);

if (A/B == B)
{
   Console.WriteLine ("Да");
}
else
{
   Console.WriteLine ("Нет");
}
