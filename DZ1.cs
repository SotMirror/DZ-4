﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Возведение в степень числа ");
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Степерь для возведения B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= numberB; i++)
{
    result = result * numberA;
}
Console.WriteLine(result);