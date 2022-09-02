// Console.Clear();
// Console.Write("Enter n : ");
// int n = int.Parse(Console.ReadLine() ?? "");
// Console.Write("Enter m : ");
// int m = int.Parse(Console.ReadLine() ?? "");

// Console.WriteLine("Pow : " + GetPow(n, m));

// int GetPow(int num, int rank)
// {
//     if (rank == 0) return 1;
//     if (rank == 1) return num;
//     if (num == 0) return 0;
//     return num * GetPow(num, rank - 1);
// }

// Console.WriteLine("Sum digits : " + GetSumDigits(n));

// int GetSumDigits(int num)
// {
//     if (num / 10 == 0) return num % 10;
//     else 
//         return GetSumDigits(num % 10) + GetSumDigits(num / 10);
// }



// int a = 5; int b = 15;

// Console.Write(GetPrint(a, b));

// string GetPrint(int start, int end) 
// {
//     if (start == end) return end.ToString();
//     return start + ", " + GetPrint(start + 1, end);
// }