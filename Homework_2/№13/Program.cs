// Напишите программу, которая выводит третью цифру числа или сообщает, что её нет!

Console.Write("Введите число: ");


int FindThirdInNum(int num)
{
    if (num > 100)
    {
        x = num / 100;
        return x;
    }
    else
    {
        return "Третьей цифры нет!";
    }
}