using static System.Console;
Clear();
// Напишите программу, реализующую метод,который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Write("Введите число A: ");
int a = int.Parse(ReadLine()!);
Write("Введите число B: ");
int b = int.Parse(ReadLine()!);

WriteLine($"Число А в степени В равно {GetPow(a, b)}.");

int GetPow(int x, int y)
{
    int pow = 1;
    for (int i = 1; i <= y; i++)
    {
        pow *= x;
    }
    return pow;
}
    