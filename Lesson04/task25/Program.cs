﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Введите число А-");

int numA= int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В-");

int numB=int.Parse (Console.ReadLine());
int result=1;
for (int i=0;i<numB;i++)
{
    result=result*numA;
}
Console.WriteLine("Число А в натуральной степени числа В = "+result);