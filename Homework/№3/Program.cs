// Проверка на чётность

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num %2 == 0)
{
    Console.WriteLine(num + " - чётное");
}
else
{
    Console.WriteLine(num + " - нечётное");
}