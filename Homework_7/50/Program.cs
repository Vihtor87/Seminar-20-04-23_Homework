/*
Задача 50:
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет
*/

Console.Write("Введите номер строки для поиска: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца для поиска: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr = GetArray();
PrintArray(arr);
FindIndexArray(arr, rows, columns);

int[,] GetArray()
{
    int rand = new Random().Next(3, 9);
    int m = rand;
    int n = rand;
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
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

void FindIndexArray(int[,] inArray, int x, int y)
{
    if (x > inArray.GetLength(0) || y > inArray.GetLength(1))
    {
        Console.Write("Такого числа нет!");
    }
    else
    {
        Console.Write($"В ячейке [{x},{y}] лежит значение {inArray[x - 1, y - 1]}");
    }
}