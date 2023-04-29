// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

int x1 = Prompt("Введите координату X1: ");
int y1 = Prompt("Введите координату Y1: ");
int z1 = Prompt("Введите координату Y1: ");
int x2 = Prompt("Введите координату X2: ");
int y2 = Prompt("Введите координату Y2: ");
int z2 = Prompt("Введите координату Y1: ");
FindLinePlane(x1, y1, x2, y2, z1, z2);

int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    int coord = Convert.ToInt32(value);
    return coord;
}

double FindLinePlane(int xa, int ya, int xb, int yb, int za, int zb)
{
    double ab = Convert.ToDouble(Math.Round(Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2)), 3));
    Console.WriteLine($"Расстояние между точками {ab}");
    return ab;
}