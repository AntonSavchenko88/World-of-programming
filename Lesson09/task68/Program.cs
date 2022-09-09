/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9*/
int Input(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int m = Input("Введите начальное значение: ");
int n = Input("Введите конечное значение: ");
int FunctionAccerman = Ack(m, n);

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}
Console.WriteLine("Функция Аккермана = " + FunctionAccerman);
