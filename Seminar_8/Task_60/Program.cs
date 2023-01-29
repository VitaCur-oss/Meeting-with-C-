using static System.Console;
Clear();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Write("Введите размер трехмерного массива через пробел: ");
int[] position = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,,] array = GetMatrixArray(position[0], position[1], position[2]);
PrintMatrixArray(array);
WriteLine();


int[,,] GetMatrixArray(int x, int y, int z)
{
    Random rnd = new Random();
    int[,,] resultArray = new int[x, y, z];
    int[] Array = new int[x * y * z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                for (int t = 0; t < x * y * z; t++)
                {
                    int a = rnd.Next(10,100);
                    if (Array.Contains(a)) t--;
                    else Array[t] = a;
                    resultArray[i,j,k] = a;
                }
            }
        }
    }
    return resultArray;
}
                   
void PrintMatrixArray(int[,,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            for (int k = 0; k < inarray.GetLength(2); k++)
            {
                Write($"{inarray[i, j, k],4}({i},{j},{k}) ");

            }
            WriteLine();
        }
    }
}







