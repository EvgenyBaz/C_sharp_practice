// "Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30"

Console.Clear();
Console.WriteLine("Введите  число M:");
int mNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите  число M:");
int nNumber = int.Parse(Console.ReadLine());
NumberSumMtoN (mNumber, nNumber, 0);


void NumberSumMtoN (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    NumberSumMtoN(m, n, sum);
}

