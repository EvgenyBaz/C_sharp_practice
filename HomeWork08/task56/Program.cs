// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Введите число строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов  массива");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine($" минимальная сумма сзначений массива находится в {ArrayRowMinValue(array)+1} строке");// строки нумеруются начиная с первой
PrintArray(array);

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

int ArrayRowMinValue(int[,] array)
{

    int minRow = 0;

    int[] rowElementSum = new int[array.GetLength(0)];


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowElementSum[i] = rowElementSum[i] + array[i, j];
        }
    }

    int minRowSum = rowElementSum[0];

    for (int i = 1; i < rowElementSum.GetLength(0); i++)
    {
        if (rowElementSum[i] < minRowSum)
        {
            minRow = i;
            minRowSum = rowElementSum[i];
        }
    }
    return minRow;

}


