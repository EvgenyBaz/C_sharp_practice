// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите значение N");
int nNumber = int.Parse(Console.ReadLine());

Console.Write("'");
NaturalNumberPrint(nNumber);
Console.Write("'");


void NaturalNumberPrint( int n )
{
    if (n < 0) Console.Write($"{n} не натуральное число");
    if (n == 0) return;
    if (n == 1)
    {
       Console.Write($"{n}"); 
    }
    else
    {
        Console.Write($"{n}, ");
        NaturalNumberPrint (n-1);
    }
}