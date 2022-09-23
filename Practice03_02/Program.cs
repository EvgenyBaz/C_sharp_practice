Console.Clear();

Console.Write("Введите число ");
string num = Console.ReadLine();

switch(num)
{
    case "1":
        Console.WriteLine("x > 0, y > 0");
        break;
    case "2":
        Console.WriteLine("x < 0, y > 0");
        break;
    case "3":
        Console.WriteLine("x < 0, y < 0");
        break;
    case "4":
        Console.WriteLine("x > 0, y < 0");
        break;
    default:
        Console.WriteLine("Введено некорректное число");
        break;
}
