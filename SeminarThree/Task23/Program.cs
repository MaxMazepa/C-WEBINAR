﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите цифру или число: ");
double N = Convert.ToInt32(System.Console.ReadLine());
double num = 1;

for (int i = 1; i <= N; i++)
{
    num = Math.Pow(i,3);
    System.Console.WriteLine($"{i} --> {num}");
}