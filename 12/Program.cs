// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

int N = Prompt("Введите число: ");
SquareNum(N);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void SquareNum(int num)
{
    int start = 1;
    while (start <= num)
    {
        Console.Write(Math.Pow(start, 2) + " ");
        start++;
    }
}