using static System.Console;
Clear();

// Напишите программу, реализующую метод, который формирует 
// массив случайных целых чисел из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]
Write("[");
PrintArray(GetArray(8));
Write("]");


int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100);
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