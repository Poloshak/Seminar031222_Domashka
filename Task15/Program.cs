﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной");
}else
{
    Console.WriteLine("Не выходной");
}
