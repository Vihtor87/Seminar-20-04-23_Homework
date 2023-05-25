/*
Задача 25: Напишите программу, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int a = Prompt("Введите число: ");
int b = Prompt("Введите степень числа: ");
Console.Write($"Число {a} в степени {b} равно {NumInDegree(a, b)}");

int Prompt(string message)
{
    Console.Write(message);
    int text = int.Parse(Console.ReadLine()!);
    return text;
}

int NumInDegree(int x, int y)
{
    if (y != 0)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }
    else
    {
        return 1;
    }
}



