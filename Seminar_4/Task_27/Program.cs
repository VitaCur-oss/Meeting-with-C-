using static System.Console;
Clear();
//  Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Write("Введите число: ");
int a = int.Parse(ReadLine()!);

WriteLine($"Сумма цифр в числе {a} равна {GetSum(a)}.");

int GetSum(int x)
{
    int sum = 0;
    while (x > 0)
    {
        sum += x % 10;
        x = x / 10;
    }
    return sum;
}