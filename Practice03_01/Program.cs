// See https://aka.ms/new-console-template for more information
Console.Clear ();
Console.WriteLine ("enter X");
int x = int.Parse(Console.ReadLine()); 
Console.WriteLine ("enter Y");
int y = int.Parse(Console.ReadLine()); 

if (x>0)
{
    if (y>0)
    {
        Console.WriteLine("I quarte");
    }
    else
    {
        Console.WriteLine("IV quarte");
    }
}
else
{
    if (y>0)
    {
        Console.WriteLine("II quarte");
    }
    else
    {
        Console.WriteLine("III quarte");
    }
}