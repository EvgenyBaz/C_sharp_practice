// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Введите число строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов  массива");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

Console.WriteLine("Введите позицию строки массива");
int mPosition = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию столбца массива");
int nPosition = int.Parse(Console.ReadLine());

if (mPosition < 0 || mPosition >= array.GetLength(0) || nPosition < 0 || nPosition >= array.GetLength(1))
{
    Console.WriteLine("элемента с такими порядковыми значениями в массиве нет");
}
else
{
    Console.WriteLine($"значение элемента массива на позиции [{mPosition},{nPosition}]={array[mPosition, nPosition]}");
}




void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}


void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}