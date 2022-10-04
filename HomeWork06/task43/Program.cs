// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double[,] lineArray = new double[2,2];

Console.Write("Введите параметры двух уравнений прямых 'y = kx + b' => k и b  ");

for (int i = 0; i < 2; i++)
    {
        Console.WriteLine ($"введите параметры уравнения {i+1}, k и b");
        for (int j = 0; j < 2; j++)
        {
            lineArray[i,j] = int.Parse(Console.ReadLine());
        }
    }

for (int j = 0; j<2; j++)
{
    lineArray[0,j] = lineArray[0,j] - lineArray[1,j];
}

double x = -lineArray[0,1]/lineArray[0,0];
double y = lineArray[1,0] * x + lineArray[1,1];

Console.WriteLine ($"точка пересечения имеет координаты X= {x} , Y = {y}");

