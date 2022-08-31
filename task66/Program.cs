// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

int n = GetInt("enter n: ");
int m = GetInt("enter m: ");
Console.Write("Result : " + GetSum(n, m));

//*****************************************************************************************//

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

int GetSum(int a, int b)
{
    int res = 0;
    for (int i = a; i <= b; i++) res += i;
    return res;
}