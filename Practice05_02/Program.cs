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

int[] SumArray (int[] arrOne, int[] arrTwo)
{
    int[] resArray =  new  int[arrOne.Length]; 
    for ( int i = 0; i<arrOne.Length; i++)
    {
        resArray[i] = arrOne[i] + arrTwo[i];
    }

return resArray;
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
string inputTwo = Console.ReadLine();
int [] arrayTwo = StringToArray(inputTwo);
int[] arrayThree =  new  int[arrayOne.Length];

if (arrayOne.Length != arrayTwo.Length)
{
    Console.WriteLine ("длины массивов не совпадают");
}
else
{  
    arrayThree = SumArray (arrayOne, arrayTwo);
    PrintArray(arrayThree);
}


