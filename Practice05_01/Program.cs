Console.Clear ();
Console.WriteLine ("введите числа через пробел");

string  = input Console.ReadLine();
int [] array = ParceToArray(input);
Console.WriteLine("положительная сумма");
Console.WriteLine(PositiveSum(array));
Console.WriteLine("отрицательная  сумма");
Console.WriteLSum(NegativeSum(array));



int[] StringToArray (string str)
{
    string[] stringArray =  str.Split(" ");
    int result  = new int[stringArray.Length];

    for (int i = 0; i<stringArray.Length; i++)
    {
        result[i] = int.Parse (stringArray[i]);
    }
    return result;
}

int PositiveSum (int[] array)
{
    int count = 0;
    for int i=0; i< array.Length; i++
    {
        if (array[i]>0)
            count = count +array[i];
    }    
}

int NegativeSum (int[] array)
{
    int count = 0;
    for int i=0; i< array.Length; i++
    {
        if (array[i]<0)
            count = count +array[i];
    }    
}

