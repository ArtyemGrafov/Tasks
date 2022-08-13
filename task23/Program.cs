Console.Clear();

int n, i = 1;

try
{
    Console.Write("Input number : ");
    n = int.Parse(Console.ReadLine() ?? "");
    while (i <= n)
    {
    Console.Write(Math.Pow(i, 3) + " ");
    i++;
    }
}
catch (Exception exception)
{
    Console.WriteLine($"Error : {exception.Message}");
}