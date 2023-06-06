/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите начальное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write(GetSumNum(n, m));

int GetSumNum(int start, int end)
{
    if (start == end) return end;
    return (GetSumNum(start + 1, end) + start);
}