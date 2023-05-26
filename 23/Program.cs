/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
int a = Prompt("Введите число: ");
int b = Prompt("Введите число: ");
int c = Prompt("Введите число: ");

int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

void CheckLine(int x, int y, int z)
{
    if (a < b + c && b < a + c && c < a + b) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}

CheckLine(a, b, c);