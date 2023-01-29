using static System.Console;
Clear();

// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int[,] array = GetMatrixArray(2, 2, 1, 9);
int[,] array2 = GetMatrixArray(2, 2, 1, 9);
PrintMatrixArray(array, array2);
WriteLine();
WriteLine("Произведение двух матриц: ");
int[,] sumMatrix = SumMatrix(array, array2);
PrintMatrixArray2(sumMatrix);


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

void PrintMatrixArray(int[,] inarray, int[,] inarray2)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Write($"{inarray[i, j],2} ");
        }
        Write("|");
        for (int k = 0; k < inarray.GetLength(0); k++)
        {
            Write($"{inarray2[i, k],2} ");
        }
        if (i < inarray.GetLength(0) - 1)WriteLine();
        
    }
}
void PrintMatrixArray2(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Write($"{inarray[i, j],3} ");
        }
        
        WriteLine();
        
    }
}
     
int[,] SumMatrix(int[,] arr, int[,] arr2)
{
    int[,] resultSum = new int[arr.GetLength(0), arr.GetLength(1)];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                resultSum[i, j] += arr[i,k] * arr2[k,j];
            }
               
        }
    }
    return resultSum;
}
                
                 
                    
               
                


