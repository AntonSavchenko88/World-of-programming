/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int Input(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int m = Input("Введите начальное значение: ");
int n = Input("Введите конечное значение: ");

void SumNaturalNumber(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        sum=sum+i;
    }
    Console.WriteLine("Сумма натуральных элементов в указанном промежутке = " + sum);
}
SumNaturalNumber(m, n);