// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillDoubleArrayRnd (double[] array)
{
    int arrayLength  = array.Length;
    Random rand = new Random();
    int sign = 1;
    for (int i=0; i<arrayLength ; i++)
    {
        array[i] = rand.NextDouble()*Math.Pow(-1,rand.Next(0,2));
    }
    return array;
}

// void PrintArray(double[] array)
// {
//     int lengthArray = array.Length;

//     Console.Write("[ ");
//     for (int i = 0; i < lengthArray; i++)
//     {
//         Console.Write(array[i]);
//         if (i < lengthArray - 1) Console.Write(" , ");
//     }
//     Console.Write(" ]");
// }

double ArrayMax(double[] array)
{
    int lengthArray = array.Length;
    double num = array[0];
    for (int i=1; i<lengthArray; i++)
    {
        if (array[i] > num) num = array[i];
    }
    return num;
}

double ArrayMin(double[] array)
{
    int lengthArray = array.Length;
    double num = array[0];
    for (int i=1; i<lengthArray; i++)
    {
        if (array[i] < num) num = array[i];
    }
    return num;
}

Console.Clear();
Console.Write("Введите длину массива ");
int arrayLength = int.Parse(Console.ReadLine());

double[] array = new double[arrayLength];

array = FillDoubleArrayRnd (array);
// PrintArray(array); // вывод массива для проверки
// Console.WriteLine ("");

double maxNum = ArrayMax(array);
double minNum = ArrayMin(array);
// //вывод минимума и максимума для проверки
// Console.WriteLine ("минимальное число " + minNum);
// Console.WriteLine ("максимальное число " + maxNum);

Console.WriteLine ("разница между максимумом и минимумом " + (maxNum-minNum));