// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int m = GetInt("Enter m (array m * n) : ");
int n = GetInt("Enter n (array m * n) : ");

int[,] array = GetRandomArray(m, n, 1, 10);

PrintArray(array, "Random array : ");

SortRowsInArray(array);

PrintArray(array, "Array with sorted rows : ");

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

void SortRowsInArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] row = new int[arr.GetLength(1)];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            row[j] = arr[i, j];
        }
        Array.Sort(row);
        Array.Reverse(row);
        for (int k = 0; k < row.Length; k++)
        {
            arr[i, k] = row[k];
        }
    }
}
