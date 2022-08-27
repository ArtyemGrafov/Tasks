// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int m = GetInt("Enter m : ");
int n = GetInt("Enter n : ");
int round = GetInt("Enter round : ");

double[,] array = GetRandomArray(m, n, -10, 10);

PrintArray(array);

//******************************************************************************************//

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

double[,] GetRandomArray(int rows, int coloumns, int minValue, int maxValue)
{
    double[,] array = new double[rows, coloumns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloumns; j++)
        {
            array[i, j] = random.NextDouble() * random.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             Console.Write(Math.Round(arr[i, j], round).ToString().PadRight(round + 4));
        }
        Console.WriteLine();
    }
}