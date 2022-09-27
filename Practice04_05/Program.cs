Console.Clear();

Console.Write("введите длину массива ");
int arrayLenght = int.Parse(Console.ReadLine()); 

CreateArray(arrayLenght);

//Console.WriteLine(CheckNum(CreateArray ()));

if (arrayLenght%2 ==0)
    {
        int[] newArray = new int[arrayLenght/2];

        for (int i=0; i<=(arrayLenght-1)/2; i++)
        {
            newArray[i] = array[i]*array[arrayLenght-i];
        }
    }
else       
    {
        int[] newArray = new int[arrayLenght/2+1];

        for (int i=0; i<=(arrayLenght-1)/2; i++)
        {
            newArray[i] = array[i]*array[arrayLenght-i];
        }
        newArray[arrayLenght%2+1] = 
    }

int[] CreateArray (int arrayLenght)
{
    int[] array = new int[arrayLenght];
    Random rand = new Random();
    for (int i=0; i<=arrayLenght-1 ; i++)
    {
        array[i] = rand.Next(0,11);
    }
    return array;
}