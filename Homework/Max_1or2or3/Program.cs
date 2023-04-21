// Найти наименьшее из трёх введённых чисел

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число: ");
int num3 = int.Parse(Console.ReadLine()!);
int maxnum = num1;
if (num2 > num3 & num2 > maxnum)
{
    maxnum = num2;
}
else if (num3 > num1 & num3 > maxnum)
{
    maxnum = num3;
}
Console.Write("Наибольшее число: " + maxnum);