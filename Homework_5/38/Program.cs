/*
Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();
double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().NextDouble() * 1000;
        res[i] = Math.Round(res[i], 3);
    }
    return res;
}

void FindMaxMinusMin(double[] array)
{
    double minNum = array[0];
    double maxNum = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum) maxNum = array[i];
        else if (array[i] < minNum) minNum = array[i];
    }
    Console.WriteLine();
    Console.Write($"В данном массиве разница между максимальным и минимальным элементами равна {Math.Round(maxNum - minNum, 3)}");
}                       // при некоторой комбинации, в вычислении после "," было много знаков, поэтому добавил округление и в вычисление

double[] arr1 = GetArray(5);
Console.Write(String.Join(" | ", arr1));
Console.WriteLine();
FindMaxMinusMin(arr1);