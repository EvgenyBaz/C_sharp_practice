Console.Clear();
Console.WriteLine ("enter first point X coordinate");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine ("enter first point Y coordinate");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine ("enter first point Z coordinate");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine ("enter second point X coordinate");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine ("enter second point Y coordinate");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine ("enter second point Z coordinate");
double z2 = double.Parse(Console.ReadLine());
double lenght = Math.Pow((Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2)),0.5);
Console.WriteLine ("{0:f2}", lenght );