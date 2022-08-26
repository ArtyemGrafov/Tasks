Console.Clear();

// int a = GetInt("Input a : ");
// int b = GetInt("Input b : ");
// int c = GetInt("Input c : ");

// if (a < b + c & b < a + c & c < a + b) Console.Write("Yes");
// else Console.Write("NO");


// int a1 = 0;
// int a2 = 1;

// int i = Convert.ToInt32(n);

// String s = Convert.ToString(i, 2);
// Console.WriteLine(s);

// String res = String.Empty;

// do 
// {
//     //Console.Write(n % 2);
//     res += n % 2;
//     n /= 2;
// }
// while (n > 0);

// Console.Write(res.Reverse().ToArray());

// Console.Write(a1 + " " + a2 + " ");

// for (int i = 0; i < n - 2; i++)
// {
//     int a3 = a1 + a2;
//     Console.Write(a3 + " ");
//     a1 = a2;
//     a2 = a3;
// }



int n = GetInt("Input n : ");
//int m = GetInt("Input m : ");

int[,] array = GetRandomArray(n, n, 2, 9);

PrintArray(array);

// Console.WriteLine();

// ModArray(array);

// PrintArray(array);

GetSum(array);

void GetSum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j) sum += arr[i, j];
        }
        
    }
    Console.WriteLine("Сумма элементов главной диагонали " + sum);
}

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

void ModArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
        }
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