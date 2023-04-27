// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2
int x1 = Prompt("Введите координату X1: ");
int y1 = Prompt("Введите координату Y1: ");
int x2 = Prompt("Введите координату X2: ");
int y2 = Prompt("Введите координату Y2: ");
FindLinePlane(x1, y1, x2, y2);

int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    int coord = Convert.ToInt32(value);
    return coord;
}

double FindLinePlane(int xa, int ya, int xb, int yb)
{
    double ab = Convert.ToDouble(Math.Round(Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2)), 3));
    Console.WriteLine($"Расстояние между точками {ab}");
    return ab;
}