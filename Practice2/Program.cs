// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Clear();
Console.WriteLine ("введите число положительное N:");
string input = Console.ReadLine();
int number  = int.Parse(input);

int i = number*(-1);

while (i <= number)
    {
      Console.WriteLine (i) ; 
        i+=1;
    }

