/*
Задача 67: Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(FindSumm(m));

int FindSumm(int x)
{
    if(x == 0) return 0;
    return (FindSumm(x / 10) + x % 10);
}