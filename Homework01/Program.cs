// 0.Напишите программу, которая принимает на вход два числа и выдаёт какое число большее , а какое меньшеею

// 5,7 max 7
// 2,10 max 10
// -9, -3 max -3

// Первый вариант кода
// int a = 5;
// int b = 7;
// int max = 0;

// if ( a > b)
// {
//     max = a;
// }
// else
// {
//     max = b;
// }

// Console.WriteLine(max);


// Второй вариант кода

int a = -9;
int b = -3;

int max = a;

if( b > max)
{
    max = b;
}

Console.WriteLine(max);

