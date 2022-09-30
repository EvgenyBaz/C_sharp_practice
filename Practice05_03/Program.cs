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

int[] NewArray (int[] arrOne, int[] arrTwo)
{
    int[] arrayRes = new int[arrOne.Length + arrTwo.Length];
    for (int i = 0; i<arrOne.Length; i++)
        {
            arrayRes[i] =  arrOne[i];
        }
    for (int i=arrOne.Length; i< (arrOne.Length + arrTwo.Length);i++)
        {
            arrayRes[i] =  arrTwo[i - arrOne.Length];
        }

return arrayRes;

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
Console.WriteLine ("введите числа первого массива через пробел");

string inputOne = Console.ReadLine();
int [] arrayOne = StringToArray(inputOne);


Console.WriteLine ("введите числа второго массива через пробел");

string inputTwo = Console.ReadLine();
int [] arrayTwo = StringToArray(inputTwo);

int[] arrayThree = new int[arrayOne.Length + arrayTwo.Length];

arrayThree = NewArray (arrayOne, arrayTwo);
PrintArray(arrayThree);