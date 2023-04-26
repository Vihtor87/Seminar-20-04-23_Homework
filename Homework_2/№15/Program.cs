Main(); // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Main()
{
    Console.Write("Введите день недели: ");
    int day = int.Parse(Console.ReadLine()!);
    WhichDay(day);

    void WhichDay(int num)
    {
        if (num == 1 || num == 2 || num == 3 || num == 4)
        {
            Console.WriteLine("no");
        }
        else if (num == 5)
        {
            Console.WriteLine("FrIdYa!");
        }
        else if (num == 6 || num == 7)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("Are you shure?");
        }
    }
}