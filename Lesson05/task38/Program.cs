/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/
Console.WriteLine("Введите размерность массива- ");
int size=int.Parse(Console.ReadLine());
double [] mas= new double [size];
double max=mas[0];
for(int i=0;i<size;i++)
{
    mas[i]=new Random().NextDouble()*100;
    mas[i]=Math.Round(mas[i],2);
      if(mas[i]>max)
        {
            max=mas[i];
        } 
}
double min=mas[0];
for(int k=0;k<size;k++)
{
    if(mas[k]<min)
    {
        min=mas[k];
    }
}
double result=max-min;
Console.WriteLine("[{0}]", string.Join("; ",mas));
Console.WriteLine("Разница между max и min элементами массива = "+result);