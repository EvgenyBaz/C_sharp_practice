Console.Clear ();
int number = new Random().Next(100,1000);

Console.WriteLine(number);
int firstDigit = number % 10;
int secondDigit = number / 10 % 10;
int thirdDigit = number / 100;
int newNum = thirdDigit*10+firstDigit;
Console.WriteLine (newNum);
