// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.Clear();
Console.WriteLine ("введите трехзначное число N:");
string input = Console.ReadLine();
int number  = int.Parse(input);

int num2 = number%10 ;
Console.WriteLine (num2) ; 