//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите число строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов  массива");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];
FillArray(array);

PrintArray(array);


void FillArray(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (rand.NextDouble() * 10) * Math.Pow(-1, rand.Next(0, 2));
        }
    }
}


void PrintArray(double[,] array)

{
    string printResult = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            printResult = string.Format("{0:f1}", array[i, j]);
            Console.Write(printResult + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}