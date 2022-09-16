// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// HOMEWORK 01 / task 04
Console.Clear();
Console.WriteLine ("Enter three numbers");
Console.WriteLine ("Enter the first number");
double number1  =  double.Parse(Console.ReadLine());
Console.WriteLine ("Enter the second number");
double number2  =  double.Parse(Console.ReadLine());
Console.WriteLine ("Enter the third number");
double number3  =  double.Parse(Console.ReadLine());
double max_number = number1;
string maxPosition  = "first";
if (number2 > max_number)
{
    max_number = number2;
    maxPosition  = "second";
}
if (number3 > max_number)
{
    max_number = number3;
    maxPosition  = "third";
}
Console.WriteLine($"max number is {maxPosition} and equal to {max_number}");
// equality check of two or three variables wasn't realised