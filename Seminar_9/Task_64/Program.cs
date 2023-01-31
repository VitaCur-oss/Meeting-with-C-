using static System.Console;
Clear();

// Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех
//  натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Write("Введите число N: ");
int n = int.Parse(ReadLine()!);
string number = GetNumber(n);
WriteLine($"N = {n} -> '{number}'");

string GetNumber(int num)
{
    return (num == 1)? num.ToString(): $"{num}, {GetNumber(num - 1)}";
}
    