// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/// HOMEWORK 01 / task 08
Console.Clear();
Console.WriteLine ("Enter positive integer number");
int number1  =  int.Parse(Console.ReadLine());
if (number1<=1)
{
    Console.WriteLine ("the entered number does not satisfy the conditions of the task");
}
else
{
    int count = 1;
    while (count <= number1)
    {
        if ((count % 2) == 0 )
        {
            Console.Write ($"{count}, ");
        }
        count += 1;
    }   
}



