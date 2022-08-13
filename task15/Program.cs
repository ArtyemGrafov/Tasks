Console.Clear();

Console.WriteLine("Input number :");

if (int.TryParse(Console.ReadLine(), out int n))
{
    if (n > 0 & n < 6)
    {
        Console.WriteLine("NO");
    }
    else if (n > 5 & n < 8)
    {
        Console.WriteLine("YES");
    }
    else Console.WriteLine("Not in range");
}
else
{
    Console.WriteLine("Incorrect input");
}