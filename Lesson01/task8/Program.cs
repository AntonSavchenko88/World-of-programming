//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
int a = int.Parse(Console.ReadLine());
int b = 1;
while (b<a)
{
    if (b % 2==0)
    {
     Console.WriteLine (b);
  b = b+1;
    }
    else
    {
        b = b+1;
    }
}
