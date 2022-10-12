Console.Clear();

Console.WriteLine("Введите число строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов  массива");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
ArrayChangeRowPlaces(array);
PrintArray(array);



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
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

void ArrayChangeRowPlaces(int[,] array)
{
    int number = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        number = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = array[0,j];
        array[0,j] = number;
    }

}