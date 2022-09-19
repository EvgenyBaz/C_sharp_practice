Console.Clear();

Console.WriteLine ("Enter a number");
int number  =  int.Parse(Console.ReadLine());

if ((number % 7 + number % 23)==0)
    Console.WriteLine ("число кратно 7 и 23");
else
    Console.WriteLine ("число не кратно 7 и 23");