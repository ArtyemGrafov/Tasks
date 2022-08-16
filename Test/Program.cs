Console.Clear();

int num = getInt();

int n = getLength(num);

int getInt()
{
    Console.Write("Введи число : ");
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out int result))
            return result;
        Console.WriteLine("Error");
    }
}

int getLength(int n)
{
    int result = 0;
    while (num > 0)
    {
        num /= 10;
        ++result;
    }

    return result;
}

Console.WriteLine($"Количество цифр = {n}");