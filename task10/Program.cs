Console.Clear();

Console.WriteLine("Input number :");

if (int.TryParse(Console.ReadLine(), out int n))
{
    if (n > 99 & n < 1000)
    {
        Console.WriteLine(n % 100 / 10);
    }
    else
    {
        Console.WriteLine("Not three-digit number");
    }   
}
else
{
    Console.WriteLine("Incorrect input");
}