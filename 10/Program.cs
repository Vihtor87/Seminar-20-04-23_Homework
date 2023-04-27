// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

int plane = Prompt("Введите номер четверти: ");
FindQuarperNum(plane);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void FindQuarperNum(int x)
{
    if (x == 1)
    {
        Console.Write("x > 0 & y > 0");
    }
    else if (x == 2)
    {
        Console.Write("x < 0 & y > 0");
    }
    else if (x == 3)
    {
        Console.Write("x < 0 & y < 0");
    }
    else if (x == 4)
    {
        Console.Write("x > 0 & y < 0");
    }
    else
    {
        Console.Write("Введите корректный номер четверти");
    }
}
