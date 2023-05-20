/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int n = Prompt();
Console.Write($"Произведение чисел от 1 до {n} равна {GetMult(n)}");

int Prompt()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GetMult(int x)
{
    int multi = 1;
    for (int i = 1; i <= x; i++)
    {
        multi *= i;
    }
    return multi;
}
