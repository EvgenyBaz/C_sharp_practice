// Задача 44: Напишите программу, которая принимает на вход 2 числа,
//  количество строк и количество столбцо, создаёт матрицуданного размера
// и заполняет нулями или единицами в случайном порядке и выводит в 
// консоль.
Console.Clear();
int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());

int[,] array = new int[row, col];

FillArray(array);
PrintArray(array);




void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(0,2);
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
