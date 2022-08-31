// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();

int n = GetInt("enter n: ");
int m = GetInt("enter m: ");

int[] arrIter = GetArrayIter(n, m);
Console.Write($"\"\"{String.Join(", ", arrIter)}\"\"");

int[] arrRec = GetArrayRec(n, m);
Console.Write($"\"\"{String.Join(", ", arrRec)}\"\"");

//*****************************************************************************************//

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

int[] GetArrayIter(int min, int max)
{
    int[] result = new int[max - min + 1];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = min;
        min++;
    }
    return result;
}

int[] GetArrayRec(int min, int max)
{
    int[] result = new int[max - min + 1];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = min;
        min++;
    }
    return result;
}