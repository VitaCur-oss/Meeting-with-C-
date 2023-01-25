using static System.Console;
Clear();
// Задача 47. Напишите программу реализующую метод, который возвращает
//  массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Write("Введите размер двухмерного массива через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

double[,] array = GetMatrixArray(intParams[0], intParams[1]);

PrintMatrixArray(array);


double[,] GetMatrixArray(int cows, int colums)
{
    Random rnd = new Random();
    double[,] resultArray = new double[cows, colums];
    for (int i = 0; i < cows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resultArray[i, j] = Math.Round(rnd.NextDouble(), 1) + new Random().Next(-10 , 10);
        }
    }
    return resultArray;
}

void PrintMatrixArray(double[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Write($"{inarray[i, j],5} ");
        }
        WriteLine();
    }
}



