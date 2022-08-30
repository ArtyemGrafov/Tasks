// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// C = A · B =  
// 1 2 3
// 4 5 6
//   ·  
// 1 2 3
// 4 5 6
// 7 8 9
//   =  
// 30 36 42
// 66 81 96

// Умножение матриц онлайн:
// https://ru.onlinemschool.com/math/assistance/matrix/multiply/

Console.Clear();
Console.Write("Enter type of realization (t = test/r = random): ");
string realize = Console.ReadLine() ?? "";
int[,] arrayA;
int[,] arrayB;
int[,] result;

switch (realize)
{
    case "t":
        arrayA = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        arrayB = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        result = new int[,] { { 30, 36, 42 }, { 66, 81, 96 } };
        PrintArray(arrayA, "ArrayA : ");
        PrintArray(arrayB, "ArrayB : ");
        PrintArray(result, "Expected result : ");
        PrintArray(MatrixMultiplication(arrayA, arrayB), "Miltiplication arrayA arrayB : ");
        break;
    case "r":
        int mA = GetInt("Enter mA (arrayA mA * nA) : ");
        int nA = GetInt("Enter nA (arrayA mA * nA) : ");
        int mB = GetInt("Enter mB (arrayB mB * nB) : ");
        int nB = GetInt("Enter nB (arrayB mB * nB) : ");

        if (nA != mB) Console.Write("Multiplication unimpossible");
        else
        {
            arrayA = GetRandomArray(mA, nA, 0, 10);
            arrayB = GetRandomArray(mB, nB, 0, 10);
            result = MatrixMultiplication(arrayA, arrayB);
            PrintArray(arrayA, "ArrayA : ");
            PrintArray(arrayB, "ArrayB : ");
            PrintArray(result, "Miltiplication arrayA arrayB : ");
        }
        break;
    default:
        Console.Write("Exit");
        break;
}

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

int[,] MatrixMultiplication(int[,] arrA, int[,] arrB)
{
    int[,] result = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                result[i, j] += arrA[i, k] * arrB[k, j];
            }
        }

    }
    return result;
}
