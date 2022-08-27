// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int m = GetInt("Enter m : ");
int n = GetInt("Enter n : ");

int i = GetInt($"Enter i (0 <= i <= {m - 1}) : ");
int j = GetInt($"Enter j (0 <= j <= {n - 1}) : ");

int[,] array = GetRandomArray(m, n, -10, 10);

PrintArray(array);

PrintElement(array, i, j);

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

int[,] GetRandomArray(int rows, int coloumns, int minValue, int maxValue)
{
    int[,] array = new int[rows, coloumns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloumns; j++)
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine("Array : ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             Console.Write(arr[i, j].ToString().PadRight(5));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintElement(int[,] arr, int i, int j)
{
    try
    {
        Console.WriteLine("Element : " + arr[i, j]);
    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine(e.Message);
    }
}