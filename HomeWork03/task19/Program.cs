Console.Clear();
Console.WriteLine("Enter a fivedigit integer");
int number = Math.Abs(int.Parse(Console.ReadLine()));
if ((number / 10000 == number % 10) && (number / 1000 % 10 == number % 100 / 10))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}