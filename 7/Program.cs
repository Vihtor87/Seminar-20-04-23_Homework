// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int rand = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число: " + rand);
int a = FirstInNum(rand);
int b = EndInNum(rand);
Console.WriteLine(a * 10 + b);

int FirstInNum(int num) // первая цифра рандомного числа
{
    int r = num / 100;
    return r;
}

int EndInNum(int num) // вторая цифра рандомного числа
{
    int r = num % 10;
    return r;
}