Console.Clear();

int x1, y1, z1, x2, y2, z2;

try
{
    Console.Write("Input x1 : ");
    x1 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Input y1 : ");
    y1 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Input z1 : ");
    z1 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Input x2 : ");
    x2 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Input y2 : ");
    y2 = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Input z2 : ");
    z2 = int.Parse(Console.ReadLine() ?? "");

}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
    return;
}

double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

Console.WriteLine(Math.Round(result, 2));