// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int length = GetInt("Введи размер массива : ");

int minValElem = -99, maxValElem = 99, sumOddElem = 0;

int[] array = GetRandomArray(length, minValElem, maxValElem);

sumOddElem  = GetSumOddElem(array);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях : " + sumOddElem);


// ************************************************//

int GetSumOddElem(int[] arr)
{
    int sumOdd = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sumOdd += arr[i];
    }
    return sumOdd;
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