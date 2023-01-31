using static System.Console;
Clear();

// Задача 68: Напишите программу реализующую метод вычисления функции
//  Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Write("Введите неотрицательные числa m, n через пробел: ");
int[] position = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int akkerman = Akkerman(position[0], position[1]);
WriteLine($"m = {position[0]}, n = {position[1]} -> A(m,n) = {akkerman}");


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1); 
    else return Akkerman(m - 1,Akkerman(m, n- 1));
}