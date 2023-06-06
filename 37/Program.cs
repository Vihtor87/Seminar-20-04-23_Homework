/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 
*/

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(FindPow(m, n));

int FindPow(int x, int y)
{
    if (y == 0) return 1;
    if (y == 1) return x;
    return (FindPow(x, y - 1) * x);
}
