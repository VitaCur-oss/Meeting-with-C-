using static System.Console;
Clear();

// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Write("Введите числa N, M через пробел: ");
int[] position = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int summ = GetSum(position[0], position[1]);
WriteLine($"N = {position[0]}; M = {position[1]} -> {summ}");

int GetSum(int N, int M)
{
    if (N < M)return (N < M)? GetSum(N, M - 1) + M: M;
    else return (M < N)? GetSum(N - 1, M) + N: N;
}

    
   
