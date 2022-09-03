/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
int[,] CreateArray(int line, int column)
{
    return new int[line, column];
}
void FillArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            array[row, column] = new Random().Next(1, 50);
        }
    }
}
void Print(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write($"{array[row, column],10}");
        }
        Console.WriteLine();
    }
}
int Input(string text)
{
    System.Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int Massive()
{
    int m = Input("Введите количество строк массива:");
    int n = Input("ВВедите количество столбцов массива:");
    int[,] matrix = CreateArray(m, n);
    FillArray(matrix);
    Print(matrix);
    int sum = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int j = 0;
        sum = sum + matrix[i+1, j];
    }
    Console.Write("Сумма=" + sum);
    return matrix[m, n];
}
Massive();