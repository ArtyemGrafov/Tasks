Console.Clear();

Console.WriteLine("Input number :");

if (int.TryParse(Console.ReadLine(), out int n))
{
    if (n > 99)
    {
        while (n > 1000) {
            n = n / 10;
        }
        
        Console.WriteLine(n % 10);
    }
    else
    {
        Console.WriteLine("The third digit is missing");
    }   
}
else
{
    Console.WriteLine("Incorrect input");
}