// Задача3: Напишите програму, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// Например: 5 -> 2, 4; 8 -> 2, 4, 6, 8

int number = 5 ;

int start = 2;


while(start <= number)                                     
{
    if(start % 2 == 0)
    Console.WriteLine(start);
    start++;
}
