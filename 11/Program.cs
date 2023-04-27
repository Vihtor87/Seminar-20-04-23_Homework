// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2

double x1 = Prompt("Введите координату X1: ");
double y1 = Prompt("Введите координату Y1: ");
double x2 = Prompt("Введите координату X2: ");
double y2 = Prompt("Введите координату Y2: ");
FindLinePlane(x1, y1, x2, y2);

double Prompt(string message)
{
    Console.Write(message);
    double coordNumber = double.Parse(Console.ReadLine()!);
    return coordNumber;
}

void FindLinePlane(double xa, double ya, double xb, double yb)
{
    double ab = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
    Console.WriteLine($"Расстояние между точками {ab}");
}