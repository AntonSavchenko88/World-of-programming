/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*Console.WriteLine("Введите пятизначное число- ");// Этот пример был разобран на семинаре.
int a= int.Parse (Console.ReadLine());
int t=a;
int na=0;
while (a!=0)
{
    na= na * 10 + a % 10;
    a/=10;
}
Console.WriteLine ($"a==na: {t==na}");*/
Console.WriteLine("Введите пятизначное число- ");
int a=int.Parse(Console.ReadLine());
string ar=a.ToString();
char [] array = ar.ToCharArray();
if (array.Length==5)
{
    if (array[0]==array[4]&&array[1]==array[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else 
{
    Console.WriteLine("Введите пятизначное число");
}
