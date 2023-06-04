/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

string value = Convert.ToString(number, 2);
Console.WriteLine($"Число {number} в двоичной системе исчисления -> {value}");