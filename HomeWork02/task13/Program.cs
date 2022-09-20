Console.Clear ();
Console.WriteLine ("Please enter an integer");
int number = int.Parse(Console.ReadLine());
double remainder = 0;
double calcNumber = number;
int count = 0;

if (Math.Abs(number) < 100)
    Console.WriteLine ("entered number hasn't a third digit");
else
{
    while (calcNumber  != 0)
        {
            remainder = calcNumber % 10 ;
            calcNumber = (calcNumber - remainder)/10;
            count += 1;
        }
        calcNumber = (number - number % Math.Pow(10, count-3));
        calcNumber = calcNumber/(Math.Pow(10, count-3));
        remainder = Math.Abs(calcNumber % 10) ;
        Console.WriteLine ("third digit of "+ number + " is " + remainder );
}