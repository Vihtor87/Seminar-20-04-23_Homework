/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
*/
int[,] arr = GetArray();
PrintArray(arr);
Console.WriteLine();
ExchangeRows(arr);
PrintArray(arr);
Console.WriteLine();
ExchangeColumns(arr);
PrintArray(arr);

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

void ExchangeRows(int[,] inArr)
{
    for (int j = 0; j < inArr.GetLength(1); j++)
    {
        int temp = inArr[(inArr.GetLength(0) - 1), j];
        inArr[(inArr.GetLength(0) - 1), j] = arr[0, j];
        inArr[0, j] = temp;
    }
}

void ExchangeColumns(int[,] inArr)
{
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        int temp = inArr[i, inArr.GetLength(1) - 1];
        inArr[i, inArr.GetLength(1) - 1] = inArr[i, 0];
        inArr[i, 0] = temp;
    }
}