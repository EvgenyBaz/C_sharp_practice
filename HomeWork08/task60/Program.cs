// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.WriteLine("введите количество строк");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество ячеек в глубину");
int deep = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,,] array3D = new int[row, column, deep];
FillArrayUnique(array3D);
PrintArray3D(array3D);

void PrintArray3D(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}[{i},{j},{k}] ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

void FillArrayUnique(int[,,] array)
{
    Random generator = new Random();
    int token = 0;
    int number = 0;
    int counter = 0;

    int[] checkArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];

    for (int i = 0; i < checkArray.GetLength(0); i++)
    {
        while (token == 0)
        {
            number = generator.Next(10, 100);
            if (CheckUnique(checkArray, counter, number))
            {
                checkArray[counter] = number;
                token = 1;
                counter++;
            }
        }
        token = 0;
    }
    array = TransformArray1Dto3D(checkArray, array);
}

int[,,] TransformArray1Dto3D(int[] array1D, int[,,] array3Dim)
{
    int count = 0;
    for (int i = 0; i < array3Dim.GetLength(0); i++)
    {
        for (int j = 0; j < array3Dim.GetLength(1); j++)
        {
            for (int k = 0; k < array3Dim.GetLength(2); k++)
            {
                array3Dim[i, j, k] = array1D[count];
                count++;
            }
        }
    }
    return array3Dim;
}

bool CheckUnique(int[] array, int iBorder, int numberToCheck)
{
    bool result = true;
    for (int i = 0; i <= iBorder; i++)
    {
        if (array[i] == numberToCheck)
        {
            result = result && false;
        }
    }
    return result;
}