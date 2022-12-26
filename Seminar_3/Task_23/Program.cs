// Задача 23
// Напишите программу, которая принимает на вход
//  число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
using static System.Console;
Clear();
Write("Введите число, до которого будем делать таблицу кубов: ");
int a = int.Parse(ReadLine()!);
int b = 1;
if (a > 0)
{
    while (b <= a)
    {
        Write(Math.Pow(b,3) + " ");
        b++;
    }
}
else
{
    while (b >= a)
    {
        Write(Math.Pow(b,3) + " ");
        b--;
    }
}