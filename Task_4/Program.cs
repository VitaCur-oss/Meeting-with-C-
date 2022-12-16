//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

using static System.Console;
Clear();

WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел");
Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);
Write("Введите третье число: ");
int c = int.Parse(ReadLine()!);

int max = a;
if (a >= b && a >= c) {max = a;}
    else if (b >= a && b >= c) {max = b;}
    else if (c >= a && c >= b) {max = c;}

WriteLine($"Максимальное число из чисел: {a}, {b}, {c}, равно: {max}");