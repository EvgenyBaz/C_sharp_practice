// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Введите число строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов  массива");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
Print2DArray(array);
Console.WriteLine("Среднее арифметическое каждого из столбцов:");
Print1DArray(ArrayColunmAverage(array));

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

double[] ArrayColunmAverage(int[,] array)
{
    double[] columnAverage = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            columnAverage[j] = columnAverage[j] + array[i, j];
        }
        columnAverage[j] = columnAverage[j] / array.GetLength(1);
    }
    return columnAverage;
}

void Print2DArray(int[,] array)

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

void Print1DArray(double[] array)
{
    string result = "";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        result = string.Format("{0:f1}", array[i]);
        if (i < array.GetLength(0) - 1)
        {
            Console.Write(result + "; ");
        }
        else
        {
            Console.Write(result + ".");
        }
    }
    Console.WriteLine();
}