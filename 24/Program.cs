/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
// int a = Prompt("Введите число: ");

// int Prompt(string message)
// {
//     Console.Write(message);
//     int value = int.Parse(Console.ReadLine()!);
//     return value;
// }

int RandomNum()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Рандомное число: " + rand);
    return rand;
}
int a = RandomNum();
string ConvTo(int x)
{
    string binary = String.Empty;
    while (x > 0)
    {
        binary = (x % 2).ToString() + binary;
        x /= 2;
    }
    return binary;
}
Console.Write($"Число {a} в двоичном представлении /{ConvTo(a)}/");