/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"[{res[i]}] ");
    }
    return res;
}

int[] array = GetArray(5, -2, 3);

Console.WriteLine();

void GetNum(int[] arr)
{
    foreach (int el in arr)
    {
        if (el == number)
        {
            Console.WriteLine("YES");
            return;
        }
    }
    Console.WriteLine("NO");
}

GetNum(array);