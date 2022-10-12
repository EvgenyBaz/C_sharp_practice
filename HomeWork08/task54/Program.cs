// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("Введите число строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов  массива");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
ArraySortRowToMin (array);
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

void ArraySortRowToMin (int[,] array)
{
    int temp = 0;
    int maxNumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {


        for (int k = 1; k < array.GetLength(1); k++)
        {
            for (int j = k; j < array.GetLength(1); j++)
            {

                if (array[i,j] > array[i,k-1])
                {
                    temp = array[i,k-1];
                    array[i,k-1]=array[i,j];
                    array[i,j] = temp;
                }


            }
        }
    }
}