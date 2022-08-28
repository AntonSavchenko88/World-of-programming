/*Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


Console.WriteLine("Введите b1 - ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1 - ");
double k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите b2 - ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2 - ");
double k2 = int.Parse(Console.ReadLine());

double intersection()
{
    double X = (b1 - b2) / (k2 - k1);
    double Y = k1 * X + b1;
    Console.Write("Координаты точки пересечения этих двух прямых = "+"(" + X + " ; " + Y + ")");
    return X + Y;
}
intersection();