/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/
int[] Fill(int size)
{
    int[] num = new int[size];
    for (int i = 0; i < size; i++)
    {
        int result = 0;
        Console.WriteLine("Введите {0}-ое число", i + 1);
        num[i] = int.Parse(Console.ReadLine());
    }
        Console.WriteLine("[{0}]", string.Join(", ", num));
    return num;
}
Console.WriteLine("Введите количество чисел которые необходимо проанализировать - ");
int size = int.Parse(Console.ReadLine());
int []nums=Fill(size);
void analising()
{
    
    int result=0;
    for(int i=0;i<size;i++)
    {
        if(nums[i]>0)
        {
            result=result+1;
        }
        
    }
    Console.WriteLine("Количество введенных цифр > 0 = "+result);
    return;
}
analising();// Пытался уменьшить количество переменных вне функций. Но ничего не получилось.Честно не очень понимаю как он заработал.
//Больше 5 часов убил на решение. 