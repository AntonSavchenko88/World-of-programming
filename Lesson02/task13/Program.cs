/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */


Console.WriteLine ("Введите число - ");
int a= int.Parse(Console.ReadLine());
string str = a.ToString();
char [] ar = str.ToCharArray();
if (ar.Length>=3)
{
    Console.WriteLine (ar[2]);
    }
else
{
    Console.WriteLine ("Третьей цифры нет!");
}


