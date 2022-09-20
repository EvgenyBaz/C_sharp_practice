Console.Clear ();
Console.WriteLine ("Please enter a three-digit positive integer");
int number = int.Parse(Console.ReadLine());
int secondDigit = number / 10 % 10;
Console.WriteLine ("secong number of entered digit is " + secondDigit );
