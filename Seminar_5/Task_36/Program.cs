using static System.Console;
Clear();

//  Напишите программу реализующую методы формирования массива,
//   заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Write("Введите размер массива, мин, мах значения диапазона через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
int sumOdd = SumOdd(array);
WriteLine($" -> {sumOdd}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] getarr = new int[size];
    for (int i = 0; i < size; i++)
    {
        getarr[i] = new Random().Next(minValue, maxValue);
    }
    return getarr;
}

void PrintArray(int[] prarr)
{
    Write("[");
    for (int i = 0; i < prarr.Length - 1; i++)
    {
        Write($"{prarr[i]}, ");
    }
    Write($"{prarr[prarr.Length - 1]}]");
}

int SumOdd(int[] sumarr)
{
    int sumres = 0;
    for (int i = 1; i < sumarr.Length; i++)
    {
        sumres += (i % 2 != 0) ? sumarr[i] : 0;
    }
    return sumres;
}

