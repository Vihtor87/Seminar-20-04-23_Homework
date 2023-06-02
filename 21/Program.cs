/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] arr = GetArray(7, 1, 10);
Console.WriteLine($"[{String.Join(" ", arr)}]");
Console.WriteLine($"[{String.Join(" ", GetMult(arr))}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] GetMult(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size++;
    int[] multyArray = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        multyArray[i] = array[i] * array[array.Length - 1 - i];
    }
    multyArray[size - 1] = array[array.Length / 2];
    return multyArray;
}