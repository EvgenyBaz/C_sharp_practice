// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// HOMEWORK 01 / task 06
Console.Clear();
Console.WriteLine ("Enter integer number");
int number1  =  int.Parse(Console.ReadLine());
if ((number1 % 2) == 0)
{
    Console.WriteLine("entered number is honest");
}
else 
{
    Console.WriteLine("entered number is odd");
}