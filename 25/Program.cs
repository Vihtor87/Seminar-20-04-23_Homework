/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
//Console.Clear();

int N = Promrt("Введите число: ");

int Promrt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

void FindListFibon(int x)
{
    int[] numFibon = new int[x];
    numFibon[0] = 0;
    numFibon[1] = 1;
    for (int i = 2; i < x; i++)
    {
        numFibon[i] = numFibon[i - 2] + numFibon[i - 1]; 
    }
    Console.Write(String.Join(" ", numFibon));
}

FindListFibon(N);
