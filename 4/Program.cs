// Напишите прошрамму, котторая на входе принимает число, а на выходе выдаёт все числа от -N до N

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int start = -number;
while (start <= number)
{
    Console.Write(start + " ");
    start++;
}