Console.Clear();
Console.WriteLine("Введите число строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов  массива");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int[,] frequencyArray = new int[array.GetLength(0)*array.GetLength(1), 2];

frequencyArray = GetFrequencyArray(array);
PrintArray(frequencyArray);


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

int GetFrequencyArray(int[,] array)
{
    int[,] frequencyArray = new int[array.GetLength(0)*array.GetLength(1), 2];
    

    // frequencyArray[0, 0] = array[0, 0];
    int Counter = 1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

                if frequencyArray [k,0]!=array[i,j];
                {
                    frequencyArray [k,0]=array[i,j]
                    Counter++
                }
        }



        }
    }








    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k=0; k < frequencyArray.GetLength(0);k++)
            {
                if (frequencyArray [k,0] == array[i,j])
                {
                    frequencyArray [k,1]++;
                }
            }
            
        }
    }



    return frequencyArray;
}