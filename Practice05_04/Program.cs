int[] StringToArray (string str)
{
    string[] stringArray =  str.Split(" ");
    int[] result  = new int [stringArray.Length];

    for (int i = 0; i<stringArray.Length; i++)
    {
        result[i] = int.Parse (stringArray[i]);
    }
    return result;
}

int[] InvertArray (int[] array)
{
    int a = 0;

    for(int i = 0; i<array.Length/2; i++)
    {
        a = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = a;
    }

return  array;
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

Console.Clear ();
Console.WriteLine ("введите числа  массива через пробел");

string inputOne = Console.ReadLine();
int [] arrayOne = StringToArray(inputOne);

arrayOne  = InvertArray(arrayOne );
PrintArray(arrayOne);