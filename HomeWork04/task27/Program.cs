// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
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

int NumLenght(int x)
{
    int result = 0;
    while (x != 0)
    {
        x = x / 10;
        result++;
    }
    return result;
}

int SumNumDigits(int x)
{
    int result = 0;
    int lenghtNum  = NumLenght(x);
    for (int i = 0; i<lenghtNum; i++)
    {
        result = result + x / NumPower(10, i) %10;
    }
    
    return result;
}

Console.Clear();
Console.Write("Введиче число ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine (SumNumDigits(number));

