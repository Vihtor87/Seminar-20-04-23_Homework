/*
Задача 65: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.Write("Введите начальное значение: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное значение: ");
int n = int.Parse(Console.ReadLine()!);

FindNumbers(m, n);

void FindNumbers(int start, int end)
{
    if (start > end) return;
    Console.Write($"{start} ");
    FindNumbers(start + 1, end);
}

// Второй вариант, через строку

// Console.Write(FindNumbersToN(m, n));

// string FindNumbersToN(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return ((start + " " + FindNumbersToN(start + 1, end)));
// }

