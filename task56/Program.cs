// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int m = GetInt("Enter m (array m * n) : ");
int n = GetInt("Enter n (array m * n) : ");

int[,] array = GetRandomArray(m, n, 1, 10);

PrintArray(array, "Random array : ");

RowMinSumElements(array);

//******************************************************************************//

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

void PrintArray(int[,] arr, string msg)
{
    Console.WriteLine(msg);
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

void RowMinSumElements(int[,] arr)
{
    int min = int.MaxValue;
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (min > sum)
        {
            min = sum;
            index = i;
        }
    }
    Console.Write("Row with minimum sum of elements : " + index);
}
