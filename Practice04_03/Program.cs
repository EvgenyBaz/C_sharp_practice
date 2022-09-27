Console.Clear();
int[] array = new int[] {6,7,19,345, -3, 6};

Console.Write ("Введите число ");
int number = int.Parse(Console.ReadLine()!);
int count = 0;

for (int i=0; i<=array.Length-1; i++)
{
    if (array[i]==number)
    {
        count = count + 1;
    }
//    else
//        count = count + 0;
}
    Console.WriteLine ("число " + number + " встречалось " + count + " раз");
