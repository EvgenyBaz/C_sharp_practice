Console.Clear();
Console.Write("Введите длину массива");
int arrayLenght = int.Parse(Console.ReadLine());

    Random randGenerator = new Random();
    int[] array  = new int[arrayLenght];

FillArray(array);
PrintArray(array);


void FillArray (int[] array)
{

    for (int i = 0; i < array.Lenght; i++)
    {
        array[i] =  randGenertor.Next(0,2);
    }
}


void PrintArray (int[] array)
{
    for (int i=0;1< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}