/*
Задача 52:
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3;
*/

int[,] arr = GetArray();
PrintArray(arr);
double[] result = FindSummInArray(arr);
Console.Write(String.Join(" ", result));

int[,] GetArray()
{
    int rand = new Random().Next(3, 9);
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

double[] FindSummInArray(int[,] inArray)
{
    double[] res = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            summ += inArray[i, j];
        }
        res[j] = Math.Round(summ / inArray.GetLength(0), 2);
    }
    return res;
}


