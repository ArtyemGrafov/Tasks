// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int size = GetInt("Введите размер массива : ");

int[] array = GetArray(size);

int countPositiveNumbers = GetPositiveNumbers(array);

Console.Write("Количество положительных элементов : " + countPositiveNumbers);

//***********************************************//

int GetInt(string msg)
{
    Console.Write(msg);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int res)) return res;
        Console.Write("Ошибка ввода!");
        Console.Write(msg);
    }
}

int[] GetArray(int len)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = GetInt($"Введите элемент массива {i+1} из {len} : ");
    }
    return res;
}

int GetPositiveNumbers(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) res++;
    }
    return res;
}