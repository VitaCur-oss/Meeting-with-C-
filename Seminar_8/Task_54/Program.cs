using static System.Console;
Clear();

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Write("Введите размер и диапазон двумерного массива: ");

int[] position = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(position[0], position[1], position[2], position[3]);
PrintMatrixArray(array);
WriteLine("Отсортированный двумерный массив:");
int[,] array1 = SortRowsDown(array);
PrintMatrixArray(array1);

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
            Write($"{inarray[i, j],2} ");
        }
        WriteLine();
    }
}

int[,] SortRowsDown(int[,] arr)
{
    int[] temp = new int[arr.GetLength(1)];
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            temp[j] = arr[i,j];
        Array.Sort(temp);    
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            resultArr[i,k] = temp[temp.Length-1-k];
        }
    }
    return resultArr;
}
        


