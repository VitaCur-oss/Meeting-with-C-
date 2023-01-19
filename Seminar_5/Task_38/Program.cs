using static System.Console;
Clear();

//  Напишите программу реализующую методы формирования массива, 
//  заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76
Write("Введите размер массива: ");
int size = int.Parse(ReadLine()!);

double[] array = GetArray(size);
PrintArray(array);
double diff = Diff(array);
WriteLine($" -> {diff}");



double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 100;
        res[i] = Math.Round(res[i], 1);
    }
    return res;
}

void PrintArray(double[] prarr)
{
    Write("[");
    for (int i = 0; i < prarr.Length - 1; i++)
    {
        Write($"{prarr[i]} ");
    }
    Write($"{prarr[prarr.Length - 1]}]");
}

double Diff(double[] darr)
{
    double maxValue = darr[0];
    double minValue = darr[0];
    for (int i = 0; i < darr.Length; i++)
    {
        maxValue = (darr[i] > maxValue) ? darr[i] : maxValue;
        minValue = (darr[i] < minValue) ? darr[i] : minValue;
    }
    return maxValue - minValue;
}
        
    
