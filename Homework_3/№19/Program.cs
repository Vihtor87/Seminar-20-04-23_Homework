//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int number = Prompt("Введите число: ");
int numberMirr = FindMirrorNumber(number);
FindPalindron(number, numberMirr);

int Prompt(string message)
{
    Console.Write(message);
    int mess = int.Parse(Console.ReadLine()!);
    return mess;
}

int FindMirrorNumber(int x)
{
    int x1 = x * 10;
    while (((x1 /= 10) != 0))
    {
        int result = (x1 % 10);
        return result;
    }
}

void FindPalindron(int a, int b)
{
    if (number == numberMirr)
    {
        Console.Write("YES");
    }
    else
    {
        Console.Write("NO");
    }
}