// /*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 
// Использовать рекурсию 456 -> 378 -> 289126 -> 5*/

// Console.Clear();
// int number = int.Parse(Console.ReadLine());

// Console.WriteLine(CountNumber(number));


// int CountNumber(int num)
// {
//     if (num / 10 < 1) return 1;
    
//     else return 1 + CountNumber(num/10);
// }
_______________________________________
// Console.Write($"Введите число: ");

// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"В числе {num} число знаков равно {CountDigits(num)}");

// int CountDigits(int number, int counter = 0)
// {

//     if (number / 10 == 0) 
//     {
//         return counter + 1;
//     }
//     else
//     {
//         return counter + CountDigits(number / 10) + 1;
//     }

// }
_____________________________________
// Задача: Напишите программу, которая будет рекурсивно выводить каждый элемент массива в консоль

int[] CreateArray()
{
    Console.Write("Введи размерность массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    return array;
}

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(-99, 100);
    }
}

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void RecPrintArray(int[] array, int index = 0)
{
    if (index < array.Length)
    {
        Console.Write($"{array[index]} ");
        index++;
        RecPrintArray(array, index);
    }
}
Console.Clear();
int[] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Рекурсивный: ");
RecPrintArray(array);
