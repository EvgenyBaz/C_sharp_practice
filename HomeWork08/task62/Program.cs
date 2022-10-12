// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();
Console.WriteLine("Введите число строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов  массива");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArraySpiral(array);
PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((array[i, j])<10)
            {
                Console.Write("0"+array[i, j] + " ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArraySpiral(int[,] array)
{
    int count = 1;
    int k = 0; // токен строк
    int l = 0; // токен столбцов
    
    while (count <= array.GetLength(1)*array.GetLength(0))
    {
        // PrintArray(array);
        // Console.ReadKey();

        for (int j = l; j<=array.GetLength(1)-1-l; j++) //подобного рода записи сделаны для наглядности. Очевидно, что j<=x-1 тоже самое , что j<x  
        {
            array[k,j]= count;
            count++;
        }

        // PrintArray(array);
        // Console.ReadKey();

        l = array.GetLength(1)-1-l;

        for (int i = k+1; i<=array.GetLength(0)-1-k; i++)
        {
            array[i,l]= count;
            count++;
        }        
        // PrintArray(array);
        // Console.ReadKey();

        k = array.GetLength(0)-1-k;

        for (int j = l - 1; j>=array.GetLength(1)-1-l; j=j-1)
        {
            array[k,j]= count;
            count++;
        }
        // PrintArray(array);
        // Console.ReadKey();

        l = array.GetLength(1)-1-l;

        for (int i = k-1; i>=array.GetLength(0)-1-k+1; i=i-1)
        {
            array[i,l]= count;
            count++;
        } 
        // PrintArray(array);
        // Console.ReadKey(); 

        k = array.GetLength(0)-1-k+1; // подобного рода записи сделаны для наглядности. Очевидно, что можно не записывать -1 +1 
        l = l+1; 
    }

}