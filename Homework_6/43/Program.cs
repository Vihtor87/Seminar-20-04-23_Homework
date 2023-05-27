/*
Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double Prompt(string message)
{
    Console.Write(message);
    double result = double.Parse(Console.ReadLine()!);
    return result;
}

void FindPointIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Точки пересечения заданных прямых ({x};{y})");
}

double a = Prompt("Введите значение: ");
double b = Prompt("Введите значение: ");
double c = Prompt("Введите значение: ");
double d = Prompt("Введите значение: ");
FindPointIntersection(a, b, c, d);
