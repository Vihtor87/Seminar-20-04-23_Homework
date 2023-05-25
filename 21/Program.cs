/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

void GetMult(int[] array)
{
    int multi = 0;
    int iFin = array.Length - 1;
    for (int i = 0; i <= (iFin / 2); i++)
    {
        if (array.Length % 2 == 0)
        {
            multi = array[i] * array[iFin - i];
            Console.Write($"{multi} ");
        }
        else
        {
            multi = array[i] * array[iFin - i];
            Console.Write($"{multi} ");
        }
    }
}

int[] arr = GetArray(7, 1, 10);
Console.WriteLine();
GetMult(arr);