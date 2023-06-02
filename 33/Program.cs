/*
Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза 
                            1 встречается 1 раз 
                            2 встречается 1 раз 
                            8 встречается 1 раз 
                            9 встречается 3 раза

1, 2, 3         1 встречается 3 раза 
4, 6, 1         2 встречается 2 раз
2, 1, 6         3 встречается 1 раз
                4 встречается 1 раз 
                6 встречается 2 раза

*/

int[,] arr = GetArray(3, 3, 0, 10);
PrintArray(arr);
Console.WriteLine();
int[] oneArray = GetOneArray(arr);
Console.WriteLine(string.Join(", ", oneArray));
SortArray(oneArray);
Console.WriteLine(string.Join(", ", oneArray));
Console.WriteLine();
CountElements(oneArray);

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] res = new int[row, col];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue);
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
            Console.Write($" {inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetOneArray(int[,] inArray)
{
    int[] res = new int[inArray.Length];
    int z = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            res[z] = inArray[i, j];
            z++;
        }
    }
    return res;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            int temp = 0;
            if (inArray[i] > inArray[j])
            {
                temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }
}

void CountElements(int[] array)
{
    int count = 1;
    int temp = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (temp != array[i])
        {
            Console.WriteLine($"{temp} встречается {count} раз");
            count = 1;
            temp = array[i];
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{temp} встречается {count} раз");

}
