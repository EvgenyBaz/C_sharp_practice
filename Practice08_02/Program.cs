Console.Clear();
Console.WriteLine("Введите число строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов  массива");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

if (m != n)
{
    Console.WriteLine("массив не квадратный");
}
else
{
    ArrayDiagMirror(array);
    PrintArray(array);
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

void ArrayDiagMirror(int[,] array)
{
    int number = 0;
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            number = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = number;
        }
    }
}
