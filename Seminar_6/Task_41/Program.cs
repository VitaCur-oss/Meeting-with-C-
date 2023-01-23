// Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

Write("Введите числа через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int poscount = PositiveCount(array);
WriteLine($"{String.Join(", ",array)}  -> {poscount}");

int PositiveCount(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (int.Parse(arr[i]) > 0) count++;
        count += 0;
    }
    return count;
}