/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int n = Prompt();
Console.Write($"Сумма чисел от 1 до {n} равна {GetSum(n)}");

int Prompt()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int GetSum(int x)
{
    int summ = 0;
    for (int i = 1; i <= x; i++)
    {
        summ += i;
    }
    return summ;
}
