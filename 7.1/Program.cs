Main(); // Программа, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

void Main()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Рандомное число: " + rand);
    Console.WriteLine(FirstInNum(rand));
}
int FirstInNum(int num)
{
    int a = num / 100;
    int b = num % 10;
    int r = a * 10 + b;
    return r;
}
