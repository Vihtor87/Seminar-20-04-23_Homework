/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int N = Prompt("Задайте число: ");
Console.Write($"В числе {N} сумма цифр равна {SearchSummValue(N)}");

int Prompt(string message)
{
    Console.Write(message);
    int text = int.Parse(Console.ReadLine()!);
    return text;
}

int SearchSummValue(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}