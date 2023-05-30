/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

int[] arr1 = { 1, 2, 34, 4, 5 };
Console.Write(String.Join(" ", arr1));
Console.WriteLine();
int[] arr2 = {2, 3, 827, 3, 3, 0};
Console.Write(String.Join(" ", arr2));
Console.WriteLine();

CopyArray(arr1);
Console.WriteLine();
CopyArray(arr2);

void CopyArray(int[] inArray)
{
    int[] res = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        res[i] = inArray[i];
    }
    Console.Write(String.Join(" ", res));
}