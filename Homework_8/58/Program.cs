/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] arr = GetArray(3, 4);
PrintArray(arr);
Console.WriteLine();
int[,] arr2 = GetArray(4, 3);
PrintArray(arr2);
int[,]multyArr = MultiplyArray(arr, arr2);
PrintArray(multyArr);


int[,] GetArray(int m, int n)
{
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


int[,] MultiplyArray(int[,] firstMartrix, int[,] secomdMartrix)
{
    int[,] res = new int[firstMartrix.GetLength(0), secomdMartrix.GetLength(1)];
    if (firstMartrix.GetLength(0) == secomdMartrix.GetLength(1))
    {

        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstMartrix.GetLength(1); k++)
                {
                    sum += firstMartrix[i, k] * secomdMartrix[k, j];
                }
                res[i, j] = sum;
            }
        }
    }
    return res;
}