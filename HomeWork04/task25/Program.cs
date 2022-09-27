// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

int NumPower (int x, int y)
{
    int result = 1;
    for (int i=0; i<y; i++)
    {
        result = result * x;
    }
    return result;
}


Console.Clear();
Console.Write("Введиче число А ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введиче число B ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine ("число " + a + " в степени " + b + " равно " + NumPower(a,b));