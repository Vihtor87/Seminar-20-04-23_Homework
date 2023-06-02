/*
Напишите программу, является ли заданное шестизначное число счастливым.
У счастливого шестизначного числа сумма первых трёх чисел равна сумме последних трёх.
*/
Console.Clear();
Console.Write("Введите шестизначное число: ");
string number = Console.ReadLine()!;
int[] arr = GetArray(number);
// Console.Write(String.Join(" ", arr));
Console.WriteLine();
FindLuckyNum(arr);

int[] GetArray(string value)
{
    int[] res = new int[value.Length];
    for (int i = 0; i < value.Length; i++)
    {
        res[i] = Convert.ToInt32(value[i].ToString());
    }
    return res;
}

void FindLuckyNum(int[] array)
{
    if(array.Length == 6)
    {
        if (array[0]+ array[1]+array[2]==array[3]+ array[4]+array[5])
        {
            Console.Write("УРА! Число счастливое!");
        }
        else Console.Write("Число не счастливое((");
    }
    else Console.Write("Число не шестизначное!");
}
