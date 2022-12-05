//Задача 2: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
//Напримет: 4 -> да; -3 -> нет; 7 -> нет.

// int number = 7;

// if(number % 2 == 0)
// {
    // Console.WriteLine("Четное число");
// }
// else
// {
    // Console.WriteLine("Нечетное число");
// }

Console.Write("Введите число");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    if ( i % 2 == 0)
    {
        Console.Write(i+" ");
    }
}
Console.ReadKey();