// Найти какое из двух числе больше и какое меньше и вывести их

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 < num2)
{
    Console.Write("Наименьшее число: " + num1 + " Наибольшее число: " + num2);
}
else if (num1 > num2)
{
    Console.Write("Наименьшее число: " + num2 + " Наибольшее число: " + num1);
}
else
{
    Console.Write("Числа " + num1 + " и " + num2 + " равны. Человек! Попробуй ещё раз!");
}
