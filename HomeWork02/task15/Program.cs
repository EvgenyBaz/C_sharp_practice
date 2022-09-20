Console.Clear ();
Console.WriteLine ("Please enter a week day number, we will check is it weekand or not!");
int number = int.Parse(Console.ReadLine());
if (( number < 1) | (number > 7 ))
    Console.WriteLine ("It is not a week day number! Try one more!");
else if (number < 6)
    Console.WriteLine ("Oh NO! This is still not a weekend :|");
else if ((6 <= number) && (number <= 7))
    Console.WriteLine ("Yeah! Time to rest!");