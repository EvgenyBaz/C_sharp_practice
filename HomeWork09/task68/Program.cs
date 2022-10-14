// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите число M:");
int mNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int nNumber= int.Parse(Console.ReadLine());

Console.WriteLine($"А({mNumber},{nNumber}) = {Ackerman(mNumber, nNumber)}");

int Ackerman (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ackerman(m - 1, 1);
    if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
return Ackerman(m, n);
}

