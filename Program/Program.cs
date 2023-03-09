
string[] FillArray()
{
    Console.Write("Введите длинну массива: ");
    int size = int.Parse(Console.ReadLine()!);

    string[] result = new string[size];
    string value = string.Empty;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е значение массива: ");
        value = Console.ReadLine()!;
        result[i] = value;
    }
    return result;

}


