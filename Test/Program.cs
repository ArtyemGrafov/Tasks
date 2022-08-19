Console.Clear();

int len = getLength(getInt());

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
    while (n > 0)
    {
        n /= 10;
        ++result;
    }

    return result;
}

Console.WriteLine($"Количество цифр = {len}");

// int len = Factorial(getInt());

// int getInt()
// {
//     Console.Write("Введи число : ");
//     while(true)
//     {
//         if (int.TryParse(Console.ReadLine(), out int result))
//             return result;
//         Console.WriteLine("Error");
//     }
// }

// int Factorial(int n)
// {
//     if (n == 1) return 1;
 
//     return n * Factorial(n - 1);
// }

// Console.WriteLine($"Факториал = {len}");