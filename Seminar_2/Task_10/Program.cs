using static System.Console;
Clear();
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int a = new Random().Next(100, 1000);
WriteLine(a);
// int a1 = a / 10;
// WriteLine(a1 % 10);
WriteLine((a / 10) % 10);