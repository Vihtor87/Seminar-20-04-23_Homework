/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите число m: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write(FindAkkerman(m, n));

int FindAkkerman(int x, int y)
{
    if (x == 0) return y + 1;
    else if (y == 0 && x > 0) return FindAkkerman(x - 1, 1);
    return FindAkkerman(x - 1, FindAkkerman(x, y - 1));
}
