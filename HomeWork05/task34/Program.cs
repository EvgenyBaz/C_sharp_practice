// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArrayRnd (int[] array)
{
    int arrayLength  = array.Length;
    Random rand = new Random();
    for (int i=0; i<arrayLength ; i++)
    {
        array[i] = rand.Next(100,1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    int lengthArray = array.Length;

    Console.Write("[ ");
    for (int i = 0; i < lengthArray; i++)
    {
        Console.Write(array[i]);
        if (i < lengthArray - 1) Console.Write(" , ");
    }
    Console.Write(" ]");
}

int ArrayEvenMemberNumber(int[] array)
{
    int lengthArray = array.Length;
    int count = 0;
    for (int i=0; i<lengthArray; i++)
    {
        if (array[i]%2 == 0) count++;
    }
    return count;
}


Console.Clear();
Console.Write("Введите длину массива ");
int arrayLength = int.Parse(Console.ReadLine());
int[] array = new int[arrayLength];

array = FillArrayRnd (array);
PrintArray(array); // вывод массива для проверки
Console.WriteLine ("");
Console.WriteLine ("Количество четных членов массива = " + ArrayEvenMemberNumber(array));



