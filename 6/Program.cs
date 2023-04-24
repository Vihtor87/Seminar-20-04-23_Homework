// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Main();

void Main()
{
    int rand = new Random().Next(10, 100);
    Console.WriteLine("Рандомное число " + rand);
    int a1 = FindFirstDigitNumber(rand); // первая цифра рандомного числа
    int b1 = FindSecondDigitNumber(rand); // вторая цифра рандомного числа
    FindMaxInNum(a1, b1);

    int rand1 = new Random().Next(10, 100);
    Console.WriteLine("Рандомное число " + rand1);
    int a2 = FindFirstDigitNumber(rand1); // первая цифра рандомного числа
    int b2 = FindSecondDigitNumber(rand1); // вторая цифра рандомного числа
    FindMaxInNum(a2, b2);
}

void FindMaxInNum(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.WriteLine("Наибольшая цифра числа " + num1);
    }
    else if (num1 < num2)
    {
        Console.WriteLine("Наибольшая цифра числа " + num2);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}

int FindFirstDigitNumber(int r)
{
    int result = r / 10;
    return result;
}

int FindSecondDigitNumber(int r)
{
    int result = r % 10;
    return result;
}