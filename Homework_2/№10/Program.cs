
Main(); // Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

void Main()
{
    Console.Write("Введите трёхзначное число: ");
    int n = CheckNum123(int.Parse(Console.ReadLine()!));
    Console.Write(FindSecondInNum(n));

    int FindSecondInNum(int num) // Берём вторую цифру из введённого числа
    {
        int x = num / 10 % 10;
        return x;
    }


    int CheckNum123(int num)
    {
        if (num > 99 & num < 1000)
        {
            return num;
        }
        else
        {
            return num * 10; // КАК СДЕЛАТЬ КОНВЕРТАЦИЮ string в int??? Если я хочу вывести в else "Число двезначное!"
        }
    }
}