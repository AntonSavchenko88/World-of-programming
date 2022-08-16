/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Введите кординату X- точки А");
double X= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кординату Y- точки А");
double Y= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кординату Z- точки А");
double Z= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите кординату X- точки B");
double Xx=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кординату Y- точки B");
double Yy=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кординату Z- точки B");
double Zz=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Координаты точки А="+X+","+Y+","+Z+".");
Console.WriteLine("Координаты точки B="+Xx+","+Yy+","+Zz+".");

double AB=Math.Sqrt(Math.Pow((Xx-X),2) + Math.Pow((Yy-Y),2)+Math.Pow((Zz-Z),2));
Console.WriteLine("Расстояние между точками А и В="+Math.Round(AB,2));