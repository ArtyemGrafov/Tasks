Console.Clear();

int n = GetInt("Input n : ");
int m = GetInt("Input m : ");

// if (m == n)
// {
    int[,] array = GetRandomArray(n, m, 1, 9);
    PrintArray(array);
    Console.WriteLine();
    ModArray(array);
    PrintArray(array);
// }
// else
// {
//     Console.WriteLine("Mission unimposible");
// }


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// void ModArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < i; j++)
//         {
//             if (i != j)
//             {
//                 int tmp = arr[i, j];
//                 arr[i, j] = arr[j, i];
//                 arr[j, i] = tmp;
//             }
//         }
//     }
// }

void ModArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int tmp = arr[0, i];
        arr[0, i] = arr[arr.GetUpperBound(0), i];
        arr[arr.GetUpperBound(0), i] = tmp;
    }
}


//int[] arrayCopy = CopyArray(array);

//array[0] = 1000;

// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"[{string.Join(", ", arrayCopy)}]");
// array[0] = 1000;
// Console.WriteLine($"[{string.Join(", ", array)}]");


// int[] CopyArray(int[] arr)
// {
//     int[] res = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         res[i] = arr[i];
//     }
//     return res;
// }

int[,] GetRandomArray(int n, int m, int min, int max)
{
    int[,] array = new int[n, m];

    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(min, max + 1);
        }
    }
    return array;
}

int GetInt(string msg)
{
    Console.Write(msg);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.WriteLine("Ошибка ввода");
        Console.Write(msg);
    }
}