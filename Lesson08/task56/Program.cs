/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
int row = Input("Введите количество строк в массиве:");
int column = Input("Введите количество столбцов массива:");
int[,] array = new int[row, column];
int Input(string text)
{
    System.Console.Write(text);
    int number =int.Parse(Console.ReadLine());
    return number;
}
void FillArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]};", 5);
        }
        Console.WriteLine();
    }
}
FillArray(array);
int minSum = 0;
int sumLine = SumLine(array, 0);
int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
for (int i = 1; i < array.GetLength(0); i++)// Так и не смог придумать как воткнуть этот цикл в функцию
{
    int sum = SumLine(array, i);
    if (sumLine > sum)
    {
        sumLine = sum;
        minSum = i;
    }
}
PrintArray(array);
Console.WriteLine($"\n{minSum + 1} - строкa с наименьшей суммой  элементов. Сумма элементов в {minSum + 1} строке={sumLine} ");

