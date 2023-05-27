/*
Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
        Console.Write($"{res[i]} ");
    }
    return res;
}
FindNum(GetArray(7));

void FindNum(int[] arr)
{
    int count = 0;
    int count1 = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count++;
        else count1++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чётных чисел {count}, а нечётных {count1}");
}