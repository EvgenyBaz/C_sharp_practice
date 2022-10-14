Consolw.Clear();
Console.Write("введите превое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("введите длину последовотельности: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"{num1} {num2} ");
for (int i = 1; i <= n-2 ; i++)
{
    int num3 = num1 + num2;
    Console.Write($"{num3} ");
    num1 = num2;
    num2 = num3;
}
