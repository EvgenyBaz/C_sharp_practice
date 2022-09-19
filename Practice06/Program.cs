Console.Clear();
Console.WriteLine ("Enter two numbers");
Console.WriteLine ("Enter the first number");
int number1  =  int.Parse(Console.ReadLine());
Console.WriteLine ("Enter the second number");
int number2  =  int.Parse(Console.ReadLine());

int ostatok = number2 % number1;
if (ostatok ==0)
    Console.WriteLine ("число кратно");
else
    Console.WriteLine ($" остаток {ostatok}");