using static System.Console;
Clear();
// Задача 52. Напишите программу реализующую методы, формирования двумерного массива
//  и массива средних арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Write("Введите размер двухмерного массива и диапазон через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);
WriteLine();
double[] array1 = SumMedColums(array);
WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ",array1)}");

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

double[] SumMedColums(int[,] arr)
{
    double[] resultSumMed = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            resultSumMed[j] += Math.Round( arr[i, j] / (double)arr.GetLength(0), 1);
        }
    }
    return resultSumMed;
}
    
            
    