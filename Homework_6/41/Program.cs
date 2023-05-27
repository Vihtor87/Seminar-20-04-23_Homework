/*
Задача 41:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();

string Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()!;
    return value;
}

void FindPositivNum(string words)
{
    string[] text = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    int count = 0;
    int N = 0;
    foreach (string s in text)
    {
        N = Convert.ToInt32(s);
        if (N > 0) count++;
    }
    Console.WriteLine($"Количество чисел больше нуля -> {count}.");
}

string num = Prompt("Введите числа через пробел: ");
FindPositivNum(num);