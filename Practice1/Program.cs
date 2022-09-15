// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.Clear();
//Console.WriteLine ("введите число:");
//string input = Console.ReadLine();
//int number  = int.Parse(input);

//int square = number*number;
//int PowRez = (int)Math.Pow(number, 3);
//Console.WriteLine (square);
//Console.WriteLine (PowRez);

Console.Clear();
Console.WriteLine ("введите первое число:");
double num1 = int.Parse(Console.ReadLine());
Console.WriteLine ("введите второе число:");
double num2 = int.Parse(Console.ReadLine());

if (Math.Pow(num2, 2) == num1)
{
    Console.WriteLine ("да");
}
else
{
    Console.WriteLine ("нет");
}




Console.Clear();
Console.WriteLine ("введите порядковый номер дня от 1 до 7:");
string dayNum = Console.ReadLine();

if (dayNum == "1" )  
{
    Console.WriteLine ("Понедельник");
}
if (dayNum == "2" )
{
    Console.WriteLine ("Вторник");
}
if (dayNum == "3" )
{
    Console.WriteLine ("Среда");
}
if (dayNum == "4" )
{
    Console.WriteLine ("Четверг");
}
if (dayNum == "5" )
{
    Console.WriteLine ("Пятница");
}
if (dayNum == "6" )
{
    Console.WriteLine ("Суббота");
}
if (dayNum == "7" )
{
    Console.WriteLine ("Воскресенье");
}
else
{
    Console.WriteLine ("в неделе только семь дней!");
}