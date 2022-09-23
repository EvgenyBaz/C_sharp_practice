Console.Clear();

Console.WriteLine("Введите N");
int num = int.Parse(Console.ReadLine()!);
int count = 1;
while (count<=num)
{
    Console.Write(Math.Pow(count , 3));
    count+=1;
    if (count <= num)
        Console.Write(",");
}
