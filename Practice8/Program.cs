Console.Clear();
Console.WriteLine ("Enter two numbers");
Console.WriteLine ("Enter the first number");
int number1  =  int.Parse(Console.ReadLine());
Console.WriteLine ("Enter the second number");
int number2  =  int.Parse(Console.ReadLine());

if ((Math.Pow(number1,2) == number2) | (Math.Pow(number2,2) == number1))
    Console.WriteLine ("одно число является квадратом другого");
else
    Console.WriteLine ("одно число не является квадратом другого");