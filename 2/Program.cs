// Определить является первое число квадратом второго
Console.WriteLine("Ввведите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (b * b == a)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");