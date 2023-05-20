/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int Prompt()
{
    Console.Write("Введите число: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int QuantumNum(int x)
{
    int count = 0;
    if (x != 0)
    {
        while (x > 0 || x < 0)
        {
            x /= 10;
            count++;
        }
        return count;
    }
    return 1;
}

int num = Prompt();
Console.Write($"В числе {num} количество цифр {QuantumNum(num)}");