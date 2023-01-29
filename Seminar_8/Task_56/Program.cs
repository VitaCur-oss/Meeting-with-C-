using static System.Console;
Clear();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка
Write("Введите размер двумерного массива, мин, мах значения диапазона через пробел: ");
int[] position = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(position[0], position[1], position[2], position[3]);
PrintMatrixArray(array);
WriteLine();
int row = MinSumRow(array);
WriteLine($"Номер строки с наименьшей суммой элементов: {row}");


int[,] GetMatrixArray(int cows, int colums, int minvalue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[cows, colums];
    for (int i = 0; i < cows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i, j] = rnd.Next(minvalue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Write($"{inarray[i, j],4} ");
        }
        WriteLine();
    }
}

int MinSumRow(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            sum[i] += arr[i,j];
        int min = sum[0];
        for (int k = 0; k < sum.Length; k++)
        {
            if (sum[k] < min) min = sum[k];
        }
        res = (Array.IndexOf(sum, min)) + 1;
    }
    return res;
}

        
            


