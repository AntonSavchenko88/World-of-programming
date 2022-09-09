/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""*/
int Input(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int m = Input("Введите начальное значение: ");
int n = Input("Введите конечное значение: ");
void NaturalNumber(int m, int n)
{
    while (m <= n)
    {
        Console.Write($"{m},");
        m++;
    }
}
NaturalNumber(m,n);