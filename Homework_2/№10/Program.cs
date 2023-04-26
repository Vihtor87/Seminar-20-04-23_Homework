
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

    void CheckNum12Or123Or1234(int num)
    {
        if (num > 99 & num < 1000)
        {
            Console.Write(num);
        }
        else
        {
            Console.Write("Введите трёхзначное число!"); // Как конвентировть string в int, чтобы вывести сообщение с ошибкой при вводе
        }
    }
