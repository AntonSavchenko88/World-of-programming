/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
int x = Input("Введите количество строк в массиве:");
int y = Input("Введите количество столбцов в массиве:");
int z = Input("Введите количество строк в глубину в массиве:");
int[,,] array3D = new int[x, y, z];
int Input(string text)
{
    System.Console.Write(text);
    int number =int.Parse(Console.ReadLine());
    return number;
}
void FillArray(int[,,] array3D)
{
    int m = array3D.GetLength(0);
    int n = array3D.GetLength(1);
    int q = array3D.GetLength(2);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < q; k++)
            {
                array3D[i, j, k] = new Random().Next(10, 99);
            }

        }
    }
}
void PrintArray(int[,,] array3D)
{
    int m = array3D.GetLength(0);
    int n = array3D.GetLength(1);
    int q = array3D.GetLength(2);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < q; k++)
            {
                Console.Write($"{array3D[i, j, k]}"+$"({i},{j},{k});",7);
                       
            }
            Console.WriteLine();
        }

    }
}
FillArray(array3D);
PrintArray(array3D);
