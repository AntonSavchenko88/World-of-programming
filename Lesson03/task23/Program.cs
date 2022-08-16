/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.WriteLine("Введите число-");
int a=int.Parse(Console.ReadLine());
int b=1;
for (int i=0; i<a;i++)
{
    double c=Math.Pow(b,3);
    b=b+1;
    Console.WriteLine(c);
}