//Задача 41: Пользователь вводит с клавиатуры число M, 
// потом вводит M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите длину цепочки чисел: ");
int number = int.Parse(Console.ReadLine());
int[] array =  new int[number];


array = InputArray (number);
Console.WriteLine($"количество положительных введенных чисел = {PositiveNumbersValue(array)}");


int[] InputArray (int num)
{
    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {   
        Console.WriteLine("введите число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
} 

int PositiveNumbersValue(int[] array)
{
    int value = 0;
    for (int i = 0; i< array.Length; i++)
        if (array[i] > 0) value++;
    return value;
}
