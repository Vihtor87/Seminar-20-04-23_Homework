
Main(); // Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

void Main()
{
    Console.Write("Введите трёхзначное число: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write(FindSecondInNum(n));

    int FindSecondInNum(int num) // Берём вторую цифру из введённого числа
    {
        int x = num / 10 % 10;
        return x;
    }
}