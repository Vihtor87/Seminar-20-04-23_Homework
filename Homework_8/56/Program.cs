/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] arr = GetArray();
PrintArray(arr);
Console.WriteLine();
// Console.Write($"{String.Join(" ", GetSummRows(arr))}"); //для быстрой проверке правильности расчётов, если рандомный массив болшой)
// Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов {GetMinRows(GetSummRows(arr))}");


int[,] GetArray()
{
    int rand = new Random().Next(3, 6);
    int m = rand;
    int n = rand;
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(1, 10);
        }
    }
    return res;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetSummRows(int[,] inArray)
{
    int[] res = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        res[i] = sum;
    }
    return res;
}

int GetMinRows(int[] inArray)
{
    int minI = 0;
    int min = inArray[0];
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] < min)
        {
            min = inArray[i];
            minI = i;
        }
        else i++;
    }
    return minI + 1;
}