// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// HOMEWORK 01 / task 02
Console.Clear();
Console.WriteLine ("Enter two numbers");
Console.WriteLine ("Enter the first number");
double number1  =  double.Parse(Console.ReadLine());
Console.WriteLine ("Enter the second number");
double number2  =  double.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"First number is MAX and equal to {number1}, Second number is MIN and equal to {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Second number is MAX and equal to {number2}, First number is MIN and equal to {number1}");
}
else
{
    Console.WriteLine($"Both numbers are the same and equal to  {number1}");
}