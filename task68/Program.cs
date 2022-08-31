// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();

int m = GetInt("enter m: ");
int n = GetInt("enter n: ");
Console.Write("Result : " + GetAkker(m, n));


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

int GetAkker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return GetAkker(m - 1, 1);
    else return GetAkker(m - 1, GetAkker(m, n - 1));
}

// int Ack(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Ack(m - 1, 1);
//     else return Ack(m - 1, Ack(m, n - 1));
// }