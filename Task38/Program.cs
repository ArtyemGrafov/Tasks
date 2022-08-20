// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int length = GetInt("Введи размер массива : ");

int minValElem = 1, maxValElem = 99;

int[] array = GetRandomArray(length, minValElem, maxValElem);

int diffMinMaxElem  = GetDiffMinMaxElem(array);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Разница между максимальным и минимальным элементами массива : " + diffMinMaxElem);


// ************************************************//

int GetDiffMinMaxElem(int[] arr)
{
    int min = arr[0];
    int max = arr[0];

    for (int i = 1; i < arr.Length; i += 2)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    //Console.WriteLine($"min = {min}, max = {max}");
    return max - min;
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