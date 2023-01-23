using static System.Console;
Clear();

// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Write("Введите координаты двух прямых линий через пробел: b1 k1 b2 k2: ");
string[] aabb = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] intersectionPoint = IntersectionPoint(int.Parse(aabb[0]), int.Parse(aabb[1]), int.Parse(aabb[2]), int.Parse(aabb[3]));
WriteLine($"b1 = {aabb[0]}, k1 = {aabb[1]}, b2 = {aabb[2]}, k2 = {aabb[3]}  -> ({String.Join("; ", intersectionPoint)})");

double[] IntersectionPoint(double A1, double B1, double A2, double B2)
{
    double[] c = new double[2];
    c[0] = Math.Round((A2 - A1) / (B1 - B2), 2);
    c[1] = Math.Round(B1 * c[0] + A1, 2);
    return c;
}






