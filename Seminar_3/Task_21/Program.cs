// Задача 21
// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using static System.Console;
Clear();
Write("Введите координаты первой точки по оси X:");
int x1 = int.Parse(ReadLine()!);
Write("Введите координаты первой точки по оси Y:");
int y1 = int.Parse(ReadLine()!);
Write("Введите координаты первой точки по оси Z:");
int z1 = int.Parse(ReadLine()!);
Write("Введите координаты второй точки по оси X:");
int x2 = int.Parse(ReadLine()!);
Write("Введите координаты второй точки по оси Y:");
int y2 = int.Parse(ReadLine()!);
Write("Введите координаты второй точки по оси Z:");
int z2 = int.Parse(ReadLine()!);

double lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
WriteLine($"Расстояние между точками равно: {lenght:f2}");