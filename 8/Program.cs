// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Main();

void Main()
{
    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второе число: ");
    int b = int.Parse(Console.ReadLine()!);
    FindLargesNumber(a, b);
}

void FindLargesNumber(int num1, int num2)
{
if (num1 % num2 == 0)
{
    Console.WriteLine("Числа кратные");
}
else
{
    Console.WriteLine("Числа не кратные: " + num1 % num2);
}
}
