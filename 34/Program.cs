/*
Задача 63: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
FindNumbers(n);

int FindNumbers(int num)
{
    if (num != 0)
    {
        FindNumbers(num - 1);
        Console.Write($"{num} ");
    }
    return num;
}

// Второй вариант, через строку:

// Console.Write(FindNumbersToN(1, n));

// string FindNumbersToN(int start, int end)
// {
//     if(start == end) return start.ToString(); 
//     return ((start + " " + FindNumbersToN(start + 1, end)));
// }