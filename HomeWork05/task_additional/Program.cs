// Задача со звёздочкой
// Найти в массиве самую длинную последовательность, состоящую из одинаковых элементов. 
// Вывести на экран количество элементов самой длиной последовательности, 
// элемент самой последовательности и номер элемента, который является ее началом.

// программа определяет самую первую из самых длинных последовательноестей одинаковой длины

int[] FillArrayRnd (int[] array)
{
    int arrayLength  = array.Length;
    Random rand = new Random();
    for (int i=0; i<arrayLength ; i++)
    {
        array[i] = rand.Next(1, 10);

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



Console.Clear();
Console.Write("Введите длину массива ");
int arrayLength = int.Parse(Console.ReadLine());

int[] array = new int[arrayLength];

array = FillArrayRnd (array);
PrintArray(array); // вывод массива для проверки
Console.WriteLine ("");

int count = 1;
int countLongest =0;
int startPosition  = 1;
int startPositionLongest = 1;
int num  =  array [0];
int numLongest = array [0];

for (int i = 1; i<arrayLength; i++)
{
    if (array[i-1] == array[i])
    {    count++;
        if (count == 2) 
        {
            startPosition = i-1;
            num = array[i-1];
        }

    }
    else
    {
        if (count>countLongest)
        {
        countLongest = count;
        startPositionLongest = startPosition;
        numLongest = num;
        }
        count = 1;
    }
}

Console.WriteLine ("количество " + countLongest );
Console.WriteLine ("стартовая позиция " + startPositionLongest + ", первый член массива находится на нулевой позиии" );
Console.WriteLine ("число " + numLongest );