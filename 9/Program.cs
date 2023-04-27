// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату X: ");
int valueX = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y: ");
int valueY = int.Parse(Console.ReadLine()!);
FindQuarperPlane( valueX, valueY);


void FindQuarperPlane(int x, int y)
{
    if (x > 0 & y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    if (x < 0 & y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    if (x < 0 & y < 0)
    {
        Console.WriteLine("Третья четверть");
    }
    if (x > 0 & y < 0)
    {
        Console.WriteLine("Четвёртая четверть");
    }
}