Console.Clear();
Console.Write("Введите длину массива");
int arrayLenght = int.Parse(Console.ReadLine());


FillArray(array);
PrintArray(array);


void FillArray (int[] array)
{
    Random randGenerator = naw Random();
    int [] array  = new int[arrayLenght];
    for i (int i = 0; i < array.Lenght; i++)
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