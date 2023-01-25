using static System.Console;
Clear();
// Задача 50. Напишите программу реализующую метод,принимающий позиции
//  элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9


Write("Введите позицию элемента в двумерном массиве через пробел: ");

int[] position = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(4, 5, 1, 10);
PrintMatrixArray(array);
WriteLine();
string finder = FindPosition(array, position[0], position[1]);
WriteLine($"{position[0]};{position[1]} -> {finder}");


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

string FindPosition(int[,] arr, int a, int b)
{
    string find = (a < arr.GetLength(0) && b < arr.GetLength(1)) ? arr[a,b].ToString(): "такого элемента в массиве нет";
    return find;
}    
    
            
            