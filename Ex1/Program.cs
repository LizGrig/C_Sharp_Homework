﻿/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());

string result = ">";

if (b>a)
{
    result = "<";
}

Console.WriteLine($"{a} {result} {b}");