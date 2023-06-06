/*
Задача 64: Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

FindNumLine(1, n);

void FindNumLine(int start, int end)
{
    if(start < end)
    FindNumLine(start + 1, end);
    Console.Write($"{start} ");
}