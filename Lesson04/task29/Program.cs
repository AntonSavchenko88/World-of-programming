/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/
Console.WriteLine("Введите размерность массива - ");
int size=int.Parse(Console.ReadLine());
int [] mas= new int [size];
for(int i=0;i<size;i++)
{
    Console.WriteLine("Введите {0}-й элемент массива",i+1);
    mas[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("[{0}]", string.Join(", ", mas));