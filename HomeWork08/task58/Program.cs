// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Clear();
Console.WriteLine("Введите число строк первой матрицы");
int rowFirstMatrix = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы");
int columnFirstMmatrix = int.Parse(Console.ReadLine());
int[,] matrixOne = new int[rowFirstMatrix, columnFirstMmatrix];
FillArray(matrixOne);
PrintArray(matrixOne);

Console.WriteLine("Введите число строк второй матрицы");
int rowSecondMatrix = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы");
int columnSecondMmatrix = int.Parse(Console.ReadLine());
int[,] matrixTwo = new int[rowSecondMatrix, columnSecondMmatrix];
FillArray(matrixTwo);
PrintArray(matrixTwo);

// Матрицу P можно умножить на матрицу K только в том случае,
//  если число столбцов матрицы P равняется числу строк матрицы K. 
//  Матрицы, для которых данное условие не выполняется, умножать нельзя. 
if (matrixOne.GetLength(1) == matrixTwo.GetLength(0))
{
    int[,] matrixResult = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    matrixResult = MatrixProduct(matrixOne,matrixTwo);
    PrintArray(matrixResult);
}
else
{
    Console.WriteLine("Матрицы нельзя перемножить");
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixRes = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i=0; i < matrixRes.GetLength(0); i++)
    {
        for (int j=0; j < matrixRes.GetLength(1); j++)
        {
            for (int k=0; k < matrixOne.GetLength(1); k++)
            {
            matrixRes[i,j]=matrixRes[i,j]+matrix1[i,k]*matrix2[k,j];
            }
        }
    }
    return matrixRes;
}





void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
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