// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int start = 1;
while (start <= number)
{
     if (start % 2 == 0)
     Console.Write(start + " ");
     start++;
}