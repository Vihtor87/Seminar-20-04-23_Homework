/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

void GetNum(int[] arr, int MinNum, int MaxNum)
{
int CountNeadNum = 0;

foreach (int el in arr)
{
    if (el > MinNum && el < MaxNum)
    {
        CountNeadNum += 1;
    }
}
    Console.WriteLine();
    Console.WriteLine($"Количество чисел = {CountNeadNum}");
}

int[] array = GetArray(123, -10, 150);
GetNum(array, 10, 99);