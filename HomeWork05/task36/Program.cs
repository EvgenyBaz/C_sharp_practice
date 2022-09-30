// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArrayRnd (int[] array)
{
    int arrayLength  = array.Length;
    Random rand = new Random();
    for (int i=0; i<arrayLength ; i++)
    {
        array[i] = rand.Next(-99, 100);
//      array[i] = rand.Next(); ???
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

int ArraySumNumOddPlaces(int[] array)
{
    int lengthArray = array.Length;
    int count = 0;
    for (int i=0; i<lengthArray; i+=2)
    {
        count = count + array[i] ;
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
Console.WriteLine ("Cумма членов массива на нечетных позициях = " + ArraySumNumOddPlaces(array));
