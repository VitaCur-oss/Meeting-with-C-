using static System.Console;
Clear();

// Напишите программу реализующую методы формирования массива, заполненного 
// случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Write("Введите размер массива из случайных чисел: ");
int size = int.Parse(ReadLine()!);
int[] array = GetArray(size);
PrintArray(array);
int countEven = CountEven(array);
WriteLine($" -> {countEven}");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] prarr)
{
    Write("[");
    for (int i = 0; i < prarr.Length - 1; i++)
    {
        Write($"{prarr[i]}, ");
    }
    Write($"{prarr[prarr.Length - 1]}]");
}

int CountEven(int[] arr)
{
    int res = 0;
    foreach (var a in arr)
    {
        res += (a % 2 == 0)? 1: 0;
    }
    return res;
}