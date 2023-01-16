using static System.Console;
Clear();
// Напишите программу, реализующую метод, который формирует 
// массив случайных целых чисел из N элементов и выводит их на экран N диапазоне.

Write("Введите диапазон массива от: ");
int a = int.Parse(ReadLine()!);
Write("Введите диапазон массива до: ");
int b = int.Parse(ReadLine()!);
Write("Введите длинну массива: ");
int c = int.Parse(ReadLine()!);

Write("[");
PrintArray(GetArray(c));
Write("]");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(a, b);
    }
    return result;
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}, ");
    }
}



