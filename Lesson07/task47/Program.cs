/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Введите количество строк массива");// Огромная просьба подскажите как можно обернуть в функцию введение с консоли значений line и column?
int line = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");//
int column = int.Parse(Console.ReadLine());//

double[,] array = new double[line, column];//

void FillArray(double[,] array)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().NextDouble() * 100-50;
            array[i,j]= Math.Round(array[i,j],2);
        }
    }
}
void Print(double[,] array)
{
    FillArray(array);
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write($"{array[row, column]}"+"; ");
        }
        Console.WriteLine();
    }
}
Print(array);