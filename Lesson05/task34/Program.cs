/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.WriteLine("Введите размерность массива- ");
int size=int.Parse(Console.ReadLine());
int [] mas= new int [size];
for(int i=0;i<size;i++)
{
    mas[i]=new Random().Next(100,999);
}
Console.WriteLine("[{0}]", string.Join(", ", mas));
int even=0;
for(int i=0;i<size;i++)
{
    if(mas[i]%2==0)
    {
        even=even+1;
    }
}
Console.WriteLine("Количество четных цифр в массиве = "+ even);