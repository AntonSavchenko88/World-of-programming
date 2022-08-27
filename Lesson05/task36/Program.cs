/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/
Console.WriteLine("Введите размерность массива- ");
int size=int.Parse(Console.ReadLine());
int [] mas= new int [size];
int sum=0;
for(int i=0;i<size;i++)
{
    mas[i]=new Random().Next(1,100);
}
Console.WriteLine("[{0}]", string.Join(", ", mas));
for(int i=0;i<size;i++)
{
    if (i%2!=0)
    {
     sum=sum+mas[i];
    }
}
Console.WriteLine("Сумма элементов массива стоящих на нечетных позициях = "+sum);