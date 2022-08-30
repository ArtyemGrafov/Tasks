// Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Clear();

Console.Write("Enter matrix type (s = square/r = rectangle): ");
string realize = Console.ReadLine() ?? "";
int[,] array;

switch (realize)
{
    case "s":
        int size = GetInt("enter size: ");
        array = GetSpiralArray(size, size);
        PrintArray(array, "Result : ");
        break;
    case "r":
        int n = GetInt("enter n: ");
        int m = GetInt("enter m: ");
        array = GetSpiralArray(n, m);
        PrintArray(array, "Result : ");
        break;
    default:
        Console.WriteLine("Input error");
        break;
}



//**************************************************************//

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

int[,] GetSpiralArray(int n, int m)
{
    int[,] result = new int[n, m];
    int x = 0, y = 0;
    int dx = 1, dy = 0;
    int nx, ny;
    for (int i = 1; i < n * m + 1; i++)
    {
        result[y, x] = i;
        nx = x + dx;
        ny = y + dy;
        
        if ((IsInRange(nx, m) && IsInRange(ny, n)) && result[ny, nx] == 0)
        {
            x = nx;
            y = ny;
        }
        else
        {
            int tmp = dx;
            dx = -dy;
            dy = tmp;
            x = x + dx;
            y = y + dy;
        }
    }
    return result;
}

void PrintArray(int[,] arr, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j].ToString("00").PadRight(4));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool IsInRange(int num, int max)
{
    return num >= 0 && num < max;
}