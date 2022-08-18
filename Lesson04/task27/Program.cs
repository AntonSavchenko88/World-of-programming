/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

Console.WriteLine("Введите число - ");
string num= Console.ReadLine();
int [] array=num.Select(x=>x-'0').ToArray();
int sum=0;
for(int j=0; j<array.Length; j++)
{
    sum+=array[j];
}  
Console.WriteLine("Сумма цифр в введенном числе = "+sum);

        