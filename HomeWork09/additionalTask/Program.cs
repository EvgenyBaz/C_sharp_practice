// Доп задача
// Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом 
// информации из массива info.
// входные данные: data = {0, 1, 1, 1, 1, 0, 0, 0, 1 } info = {2, 3, 3, 1 }выходные данные: 1, 7, 0, 1

Console.Clear();

int[] info = new int[] { 2, 3, 3, 1 };
int[] data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };

int counter = 0;
for (int i = 0; i < info.Length; i++)
{
    int[] newData = new int[info[i]];

    for (int j = 0; j < info[i]; j++)
    {
        newData[j] = data[counter];
        counter++;
    }
    Array.Reverse(newData);

    Console.Write($"{PrintDigitalNumFromBinary(newData)} ");
}

int PrintDigitalNumFromBinary(int[] newData)
{
    int digitNumber = 0;
    for (int i = 0; i < newData.Length; i++)
    {
        digitNumber = digitNumber + (int)Math.Pow(2, i) * newData[i];

    }
    return digitNumber;
}