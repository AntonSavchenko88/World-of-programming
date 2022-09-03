/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
 этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет*/
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
            Console.Write($"{array[row, column],5}");
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
    int pos1 = Input("Введите позицию по строке: ");
    int pos2 = Input("Введите позицию по столбцу: ");
    if (pos1 < 0 | pos1 > matrix.GetLength(0) | pos2 < 0 | pos2 > matrix.GetLength(1))
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", matrix[pos1-1, pos2-1]);
    }
    return matrix[m, n];
}
/*void Challenge()
{
    int[,] array = { };
    Massive();
    int pos1 = Input("Введите позицию по строке: ");
    int pos2 = Input("Введите позицию по столбцу: ");
    if (pos1 < 0 | pos1 > array.GetLength(0) - 1 | pos2 < 0 | pos2 > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
    }
    Console.ReadLine();
    return;
}
Challenge();*/
Massive();





