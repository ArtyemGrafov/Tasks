Console.Clear();

Console.Write("Input five-digit number :");

var inputString = Console.ReadLine();

if (int.TryParse(inputString, out int n))
{
    int arrayLength = inputString.Length;
    int i = 0;
    int[] digits = new int[arrayLength];
    bool flag = true;

    while (i < arrayLength)
    {
        digits[i] = n % 10;
        n = n / 10;
        i++;        
    }

    for (int j = 0; j < arrayLength / 2; j++)
    {
        if (digits[j] != digits[arrayLength - 1 - j]) 
        {
            flag = false;
            break;
        }        
    }

    if (flag) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}
else
{
    Console.WriteLine("Incorrect input");
}