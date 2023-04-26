
Main(); // Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

void Main()
{
    Console.Write("Введите трёхзначное число: ");
    int n = int.Parse(Console.ReadLine()!);
    CheckNum12Or123Or1234(n);
 
    void CheckNum12Or123Or1234(int num) // Проверяем, что число именно трёхзначное
    {
        if (num > 99 & num < 1000)
        {
            Console.WriteLine("Вторая цифра трёхзначного числа " + num / 10 % 10);
        }
        else
        {
            Console.Write("Введите трёхзначное число!");
        }
    }
}