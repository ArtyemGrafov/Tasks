//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int m = GetInt("Enter m : ");
int n = GetInt("Enter n : ");

int[,] array = GetRandomArray(m, n, -10, 10);

PrintArray(array);

GetAverageColounms(array);

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

void GetAverageColounms(int[,] arr)
{
    int sum;
    Console.WriteLine("AverageColoumns :");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write(Math.Round((double)sum / arr.GetLength(0), 1).ToString().PadRight(5));
    }
}