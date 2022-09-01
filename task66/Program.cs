// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

Console.Write("Select method (i - iterative/r - recursive): ");
String mod = Console.ReadLine() ?? "";
int n = GetInt("enter n: ");
int m = GetInt("enter m: ");

switch (mod)
{
    case "i":
    Console.WriteLine("Iterative method result: " + GetSumIter(n, m));
    break;
    case "r":
    Console.WriteLine("Recursive method result: " + GetSumRec(n, m));
    break;
    default: 
    Console.WriteLine("Incorrect input");
    break;
}

// var sumBetween = (int x, int y) =>
// {
//     int res = 0;
//     for (int i = x; i <= y; i++) res += i;
//     return res;
// };

// Console.WriteLine("sumBetween : " + sumBetween(n, m));

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

int GetSumIter(int a, int b)
{
    int res = 0;
    for (int i = a; i <= b; i++) res += i;
    return res;
}

int GetSumRec(int n, int m)
{
    if (n == m) return m; 
    return n + GetSumRec(n + 1, m);
}