/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите число - ");
int a = int.Parse(Console.ReadLine());
if (a < 1000 && a > 100)
{
    string str = a.ToString();
    char[] ar = str.ToCharArray();
    Console.WriteLine(ar[1]);
}
else
{
    Console.WriteLine("Введено неправильное число!");
}