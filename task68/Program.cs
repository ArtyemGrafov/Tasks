// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
// A(3, 2) = 29; A(2, 3) = 9

Console.Clear();

int m = GetInt("enter m: ");
int n = GetInt("enter n: ");
Console.Write("Result : " + CalculateAckermannFunction(m, n));


//**********************************************************************************************************//

int GetInt(string msg)
{
    Console.Write(msg);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int result)) return result;
        Console.WriteLine("Input error");
        Console.Write(msg);
    }
}

int CalculateAckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return CalculateAckermannFunction(m - 1, 1);
    else return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
}