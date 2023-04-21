// Напишите программу, которая принимает трёхзначное число и на выходе показывает его последнюю цифру

Console.WriteLine("Введите трёхзначное чилсо: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 99 & number < 1000)
{
    Console.WriteLine("Последняя цифра трёхзначного чилсла: " + number %10);
}
else
{
    Console.WriteLine("Введите трёхзначное! число.");
}