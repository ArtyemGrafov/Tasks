// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int length = GetInt("Введи размер массива : ");

int minValElem = 100, maxValElem = 999, evenNumbers = 0;

int[] array = GetRandomArray(length, minValElem, maxValElem);

evenNumbers  = GetEvenNumbers(array);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(evenNumbers);


// ************************************************//

int GetEvenNumbers(int[] arr)
{
    int countEven = 0;
    foreach(int element in arr)
    {
        if (element % 2 == 0) countEven++;
    }
    return countEven;
}



int[] GetRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValElem, maxValElem + 1);
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