﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int N = Prompt("Введите число: ");
SquareNum(N);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void SquareNum(int num)
{                                                                   
    for (int i = 1; i <= num; i++)                                  
    {                                                               
        Console.Write(Math.Pow(i, 3) + " ");                        
    }                                                               
}