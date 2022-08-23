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

int[] array = GetRandomArray(n, 0, 100);

int[] arrayCopy = CopyArray(array);

//array[0] = 1000;

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", arrayCopy)}]");
array[0] = 1000;
Console.WriteLine($"[{string.Join(", ", array)}]");


int[] CopyArray(int[] arr)
{
    int[] res = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        res[i] = arr[i];
    }
    return res;
}

int[] GetRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);
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