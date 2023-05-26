/*
Задача 36:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();
int[] GetArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100, 101);
    }
    return res;
}

void GetSumNegativPosition(int[] array)
{
    int summNegativ = 0;
    int summPositiv = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) summNegativ += array[i];
        else summPositiv += array[i];
    }
    Console.WriteLine();
    Console.Write($"Сумма элементов на отрицательных местах {summNegativ}, сумма элементов на положительных местах {summPositiv}");
}

int[] arr1 = GetArray(5);
Console.WriteLine(String.Join(" | ", arr1));
GetSumNegativPosition(arr1);